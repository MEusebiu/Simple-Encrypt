namespace Security01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserGroupBox = new System.Windows.Forms.GroupBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.resultGroup = new System.Windows.Forms.GroupBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.PaymentDrop = new System.Windows.Forms.Label();
            this.PaymentCombo = new System.Windows.Forms.ComboBox();
            this.NameEncryptLabel = new System.Windows.Forms.Label();
            this.AdressEncryptLabel = new System.Windows.Forms.Label();
            this.PaymentEncryptLabel = new System.Windows.Forms.Label();
            this.PasswordEncryptLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.UserGroupBox.SuspendLayout();
            this.resultGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(11, 49);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(59, 20);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "Name :";
            this.UserLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserGroupBox
            // 
            this.UserGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.UserGroupBox.Controls.Add(this.NameTextBox);
            this.UserGroupBox.Controls.Add(this.PaymentCombo);
            this.UserGroupBox.Controls.Add(this.PaymentDrop);
            this.UserGroupBox.Controls.Add(this.AdressTextBox);
            this.UserGroupBox.Controls.Add(this.AdressLabel);
            this.UserGroupBox.Controls.Add(this.SendButton);
            this.UserGroupBox.Controls.Add(this.PasswordTextBox);
            this.UserGroupBox.Controls.Add(this.PasswordLabel);
            this.UserGroupBox.Controls.Add(this.UserLabel);
            this.UserGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGroupBox.Location = new System.Drawing.Point(24, 12);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Size = new System.Drawing.Size(356, 308);
            this.UserGroupBox.TabIndex = 1;
            this.UserGroupBox.TabStop = false;
            this.UserGroupBox.Text = "Complete user information";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(237, 247);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(95, 37);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Encrypt";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(124, 190);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(208, 26);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(11, 196);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(86, 20);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password :";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // resultGroup
            // 
            this.resultGroup.Controls.Add(this.DecryptButton);
            this.resultGroup.Controls.Add(this.PasswordEncryptLabel);
            this.resultGroup.Controls.Add(this.PaymentEncryptLabel);
            this.resultGroup.Controls.Add(this.AdressEncryptLabel);
            this.resultGroup.Controls.Add(this.NameEncryptLabel);
            this.resultGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultGroup.Location = new System.Drawing.Point(396, 12);
            this.resultGroup.Name = "resultGroup";
            this.resultGroup.Size = new System.Drawing.Size(400, 307);
            this.resultGroup.TabIndex = 6;
            this.resultGroup.TabStop = false;
            this.resultGroup.Text = "Result";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(11, 95);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(67, 20);
            this.AdressLabel.TabIndex = 5;
            this.AdressLabel.Text = "Adress :";
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(124, 95);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(208, 26);
            this.AdressTextBox.TabIndex = 1;
            // 
            // PaymentDrop
            // 
            this.PaymentDrop.AutoSize = true;
            this.PaymentDrop.Location = new System.Drawing.Point(11, 142);
            this.PaymentDrop.Name = "PaymentDrop";
            this.PaymentDrop.Size = new System.Drawing.Size(79, 20);
            this.PaymentDrop.TabIndex = 7;
            this.PaymentDrop.Text = "Payment :";
            // 
            // PaymentCombo
            // 
            this.PaymentCombo.FormattingEnabled = true;
            this.PaymentCombo.Location = new System.Drawing.Point(124, 144);
            this.PaymentCombo.Name = "PaymentCombo";
            this.PaymentCombo.Size = new System.Drawing.Size(208, 28);
            this.PaymentCombo.TabIndex = 2;
            this.PaymentCombo.SelectedIndexChanged += new System.EventHandler(this.PaymentCombo_SelectedIndexChanged);
            // 
            // NameEncryptLabel
            // 
            this.NameEncryptLabel.AutoSize = true;
            this.NameEncryptLabel.Location = new System.Drawing.Point(18, 49);
            this.NameEncryptLabel.Name = "NameEncryptLabel";
            this.NameEncryptLabel.Size = new System.Drawing.Size(51, 20);
            this.NameEncryptLabel.TabIndex = 0;
            this.NameEncryptLabel.Text = "label1";
            // 
            // AdressEncryptLabel
            // 
            this.AdressEncryptLabel.AutoSize = true;
            this.AdressEncryptLabel.Location = new System.Drawing.Point(18, 95);
            this.AdressEncryptLabel.Name = "AdressEncryptLabel";
            this.AdressEncryptLabel.Size = new System.Drawing.Size(51, 20);
            this.AdressEncryptLabel.TabIndex = 1;
            this.AdressEncryptLabel.Text = "label2";
            // 
            // PaymentEncryptLabel
            // 
            this.PaymentEncryptLabel.AutoSize = true;
            this.PaymentEncryptLabel.Location = new System.Drawing.Point(18, 147);
            this.PaymentEncryptLabel.Name = "PaymentEncryptLabel";
            this.PaymentEncryptLabel.Size = new System.Drawing.Size(51, 20);
            this.PaymentEncryptLabel.TabIndex = 2;
            this.PaymentEncryptLabel.Text = "label3";
            this.PaymentEncryptLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // PasswordEncryptLabel
            // 
            this.PasswordEncryptLabel.AutoSize = true;
            this.PasswordEncryptLabel.Location = new System.Drawing.Point(18, 190);
            this.PasswordEncryptLabel.Name = "PasswordEncryptLabel";
            this.PasswordEncryptLabel.Size = new System.Drawing.Size(51, 20);
            this.PasswordEncryptLabel.TabIndex = 3;
            this.PasswordEncryptLabel.Text = "label4";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(124, 46);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(208, 26);
            this.NameTextBox.TabIndex = 0;
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(22, 247);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(90, 37);
            this.DecryptButton.TabIndex = 0;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 331);
            this.Controls.Add(this.resultGroup);
            this.Controls.Add(this.UserGroupBox);
            this.Name = "Form1";
            this.Text = "Encription ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UserGroupBox.ResumeLayout(false);
            this.UserGroupBox.PerformLayout();
            this.resultGroup.ResumeLayout(false);
            this.resultGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.GroupBox UserGroupBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.GroupBox resultGroup;
        private System.Windows.Forms.ComboBox PaymentCombo;
        private System.Windows.Forms.Label PaymentDrop;
        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.Label PasswordEncryptLabel;
        private System.Windows.Forms.Label PaymentEncryptLabel;
        private System.Windows.Forms.Label AdressEncryptLabel;
        private System.Windows.Forms.Label NameEncryptLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button DecryptButton;
    }
}

