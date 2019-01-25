﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
            hiddenDecryptLabel.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            var password = PasswordTextBox.Text;
          
            //Show encrypted password
            var encrypted = PasswordEncryptor.Encrypt(password);
            EncryptedPassList.Items.Add(encrypted);
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            var encrypted = EncryptedPassList.Items[0].ToString();
            var decrypted = PasswordEncryptor.Decrypt(encrypted);

            hiddenDecryptLabel.Text = decrypted;
            hiddenDecryptLabel.Visible = true;
        }
    }
}
