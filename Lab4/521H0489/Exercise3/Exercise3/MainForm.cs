using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class MainForm : Form
    {
        private WebClient webClient;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtDirectoryPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string directoryPath = txtDirectoryPath.Text;

            string fileName = Path.GetFileName(url);
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Invalid URL. Unable to extract file name.");
                return;
            }

            string filePath = Path.Combine(directoryPath, fileName);

            webClient = new WebClient();
            webClient.DownloadProgressChanged += (s, args) =>
            {
                progressBar.Value = args.ProgressPercentage;
            };

            webClient.DownloadFileCompleted += (s, args) =>
            {
                if (args.Error != null)
                {
                    MessageBox.Show($"An error occurred during the download: {args.Error.Message}");
                }
                else if (args.Cancelled)
                {
                    MessageBox.Show("The download was cancelled.");
                }
                else
                {
                    MessageBox.Show("Download complete!");
                    txtUrl.Text = string.Empty;
                    txtDirectoryPath.Text = string.Empty;
                    progressBar.Value = 0;
                }
            };

            try
            {
                webClient.DownloadFileAsync(new Uri(url), filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while starting the download: {ex.Message}");
            }
        }
    }
}