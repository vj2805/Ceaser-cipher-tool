using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeaserCipher
{
    public partial class CeaserCipherForm : Form
    {
        public CeaserCipherForm()
        {
            InitializeComponent();
        }

        private void ClearButtonClicked(object sender, EventArgs e)
        {
            messageTextBox.Clear();
            shiftSpinBox.Value = 0;
            encryptedMessageTextBox.Clear();
            decryptedMessageTextBox.Clear();
        }

        private void EncryptButtonClicked(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;
            int shift = (int) shiftSpinBox.Value;
            encryptedMessageTextBox.Text = CeaserCipher.Encrypt(message, shift);
        }

        private void DecryptButtonClicked(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;
            int shift = (int) shiftSpinBox.Value;
            decryptedMessageTextBox.Text = CeaserCipher.Decrypt(message, shift);
        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void decryptedMessageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void encryptedMessageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void shiftSpinBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
