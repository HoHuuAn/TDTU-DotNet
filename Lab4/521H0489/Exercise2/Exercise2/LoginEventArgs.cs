using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public delegate void UpdateTextBoxDelegate(string text);

    public class LoginEventArgs : EventArgs
    {
        public string EnteredText { get; }

        public LoginEventArgs(string enteredText)
        {
            EnteredText = enteredText;
        }
    }
}
