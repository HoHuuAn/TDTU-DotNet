using System;
using System.Windows.Forms;
namespace Exercise4
{
    public partial class MainForm : Form
    {
        private ObservableList<string> itemList;

        public MainForm()
        {
            InitializeComponent();
            itemList = new ObservableList<string>();
            itemList.OnAdd += ItemAdded;
            itemList.OnRemove += ItemRemoved;
            itemList.OnInsert += ItemInserted;
            itemList.OnUpdate += ItemUpdated;
        }

        private void ItemAdded(string item)
        {
            listBox.Items.Add(item);
        }

        private void ItemRemoved(string item)
        {
            listBox.Items.Remove(item);
        }

        private void ItemInserted(int index, string item)
        {
            listBox.Items.Insert(index, item);
        }

        private void ItemUpdated(int index, string item)
        {
            listBox.Items[index] = item;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string newItem = inputTextBox.Text;
            itemList.Add(newItem);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                string selectedItem = listBox.SelectedItem.ToString();
                itemList.Remove(selectedItem);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                string selectedItem = listBox.SelectedItem.ToString();
                string updatedItem = inputTextBox.Text;
                int index = listBox.SelectedIndex;
                itemList[index] = updatedItem;
            }
        }
    }
}