namespace Exercise2
{
    public partial class HomeForm : Form
    {
        private UpdateTextBoxDelegate _updateTextBoxDelegate;
        public HomeForm()
        {
            InitializeComponent();
        }

        public void SetUpdateTextBoxDelegate(UpdateTextBoxDelegate updateTextBoxDelegate)
        {
            _updateTextBoxDelegate = updateTextBoxDelegate;
        }

        private void access_Click(object sender, EventArgs e)
        {
            var loginScreenForm = new Login(_updateTextBoxDelegate);
            loginScreenForm.ShowDialog();
        }

        public void UpdateTextBox(string text)
        {
            txtHome.Text = text;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}