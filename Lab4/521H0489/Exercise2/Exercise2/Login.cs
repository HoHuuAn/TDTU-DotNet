using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercise2
{
    public partial class Login : Form
    {
        private UpdateTextBoxDelegate _updateTextBoxDelegate;


        public Login(UpdateTextBoxDelegate updateTextBoxDelegate)
        {
            InitializeComponent();
            _updateTextBoxDelegate = updateTextBoxDelegate;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var enteredText = txtLogin.Text;
            _updateTextBoxDelegate?.Invoke(enteredText);
            Close();
        }
    }
}
