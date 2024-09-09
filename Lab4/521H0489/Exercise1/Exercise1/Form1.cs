using System.Windows.Forms;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            username.Text = string.Empty;
            password.Text = string.Empty;
        }

        private void login_Click(object sender, EventArgs e)
        {
            string error = "Login error";
            if (username.Text.Length < 6)
            {
                string message = $"Username must be longer than 6 letters";          
                MessageBox.Show(message, error);
            }
            else if (!username.Text.Equals("hohuuan"))
            {
                MessageBox.Show("Username is incorrect", error);
            }
            else if (password.Text.Length < 6)
            {
                MessageBox.Show("Password must be longer than 6 letters", error);
            }
            else if (!password.Text.Equals("123qwe"))
            {
                MessageBox.Show("Password is incorrect", error);
            }
            else
            {
                if (remember.Checked)
                {
                    Program.username = username.Text;
                    Program.password = password.Text;
                }
                MessageBox.Show($"Congratulations {username.Text}! Successful login", "Welcome");
            }
        }
    }
}