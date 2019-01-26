using System;
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
        public string EncryptedName { get; set; }
        public string EncryptedAdress { get; set; }
        public string EncryptedPay { get; set; }
        public string EncryptedPass { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
            resultGroup.Visible = false;

            PaymentListInit();
            
        }

        private void PaymentListInit()
        {
            var option1 = new ComboBox("Visa", 1);
            PaymentCombo.Items.Add(option1.Name);

            var option2 = new ComboBox("Paypal", 2);
            PaymentCombo.Items.Add(option2.Name);

            var option3 = new ComboBox("Mastercard", 3);
            PaymentCombo.Items.Add(option3.Name);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        public void SendButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.TextLength > 0 && AdressTextBox.TextLength > 0 && PaymentCombo.SelectedItem != null && PasswordTextBox.TextLength > 0)
            {
                EncryptedName = PasswordEncryptor.Encrypt(NameTextBox.Text);
                NameEncryptLabel.Text = EncryptedName;

                EncryptedAdress = PasswordEncryptor.Encrypt(AdressTextBox.Text);
                AdressEncryptLabel.Text = EncryptedAdress;


                EncryptedPay = PasswordEncryptor.Encrypt(PaymentCombo.SelectedItem.ToString());
                PaymentEncryptLabel.Text = EncryptedPay;

                EncryptedPass = PasswordEncryptor.Encrypt(PasswordTextBox.Text);
                PasswordEncryptLabel.Text = EncryptedPass;


                resultGroup.Visible = true;
            }

        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
        }

        private void PaymentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DecryptButton_Click_1(object sender, EventArgs e)
        {
            NameEncryptLabel.Text = PasswordEncryptor.Decrypt(EncryptedName);
            AdressEncryptLabel.Text = PasswordEncryptor.Decrypt(EncryptedAdress);
            PaymentEncryptLabel.Text = PasswordEncryptor.Decrypt(EncryptedPay);
            PasswordEncryptLabel.Text = PasswordEncryptor.Decrypt(EncryptedPass);


            //NameEncryptLabel.Text = EncryptedName;
            //AdressEncryptLabel.Text = EncryptedAdress;
            //PaymentEncryptLabel.Text = EncryptedPay;
            //PasswordEncryptLabel.Text = EncryptedPass;
        }
    }
}
