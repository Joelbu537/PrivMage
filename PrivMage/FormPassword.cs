using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivMage
{
    public partial class FormPassword : Form
    {
        public System.Security.Cryptography.Rfc2898DeriveBytes Key { get; private set; }
        public byte[] Salt;
        public FormPassword(byte[] _salt)
        {
            InitializeComponent();
            Salt = _salt;
        }
        public FormPassword()
        {
            InitializeComponent();
            labelPassword.Text = "Enter a password to encrypt your library.";
            Salt = new byte[16];
            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                rng.GetBytes(Salt);
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if(textBoxPassword.Text.Length >= 8)
            {
                buttonConfirm.Enabled = true;
            }
            else
            {
                buttonConfirm.Enabled = false;
            }
        }

        private async void buttonConfirm_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text.Length >= 8)
            {
                buttonConfirm.Enabled = false;
                labelPassword.Text = "Processing...";

                string password = textBoxPassword.Text;
                textBoxPassword.Clear();

                Key = await Task.Run(() => new System.Security.Cryptography.Rfc2898DeriveBytes(password, Salt, 50000));

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
