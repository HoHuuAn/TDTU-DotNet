using System;
using System.Threading;
using System.Net;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercise4
{
    public partial class MainForm : Form
    {
        private WebClient client;

        public MainForm()
        {
            InitializeComponent();
            client = new WebClient();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string link = txtLink.Text.Trim();
            if (!string.IsNullOrEmpty(link))
            {
                Thread downloadThread = new Thread(() => DownloadFile(link));
                downloadThread.Start();
            }
        }

        private void DownloadFile(string link)
        {
            try
            {
                string fileName = Path.GetFileName(link);

                AddItemToListView(fileName);

                client.DownloadFile(link, fileName);

                RemoveItemFromListView(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while downloading the file: {ex.Message}");
            }
        }

        private void AddItemToListView(string itemName)
        {
            if (listView.InvokeRequired)
            {
                listView.Invoke(new Action<string>(AddItemToListView), itemName);
            }
            else
            {
                listView.Items.Add(itemName);
                int count = listView.Items.Count;

                process.Text = $"{count}  {(count > 1 ? "downloads" : "download")}  in process";
            }
        }

        private void RemoveItemFromListView(string itemName)
        {
            if (listView.InvokeRequired)
            {
                listView.Invoke(new Action<string>(RemoveItemFromListView), itemName);
            }
            else
            {
                listView.Items.Remove(itemName);
                int count = listView.Items.Count;
                if (count > 0)
                {
                    process.Text = $"{count} {(count > 1 ? "downloads" : "download")} in process";
                }
                else
                {
                    process.Text = "download in process";
                }
            }
        }
    }
}