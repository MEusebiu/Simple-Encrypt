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
            System.Windows.Forms.TextBox UserTextBox;
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserGroupBox = new System.Windows.Forms.GroupBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptedPassList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.hiddenDecryptLabel = new System.Windows.Forms.Label();
            UserTextBox = new System.Windows.Forms.TextBox();
            this.UserGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(6, 84);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(91, 20);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "Username :";
            this.UserLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserGroupBox
            // 
            this.UserGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.UserGroupBox.Controls.Add(this.SendButton);
            this.UserGroupBox.Controls.Add(this.PasswordTextBox);
            this.UserGroupBox.Controls.Add(this.PasswordLabel);
            this.UserGroupBox.Controls.Add(UserTextBox);
            this.UserGroupBox.Controls.Add(this.UserLabel);
            this.UserGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGroupBox.Location = new System.Drawing.Point(24, 25);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Size = new System.Drawing.Size(356, 295);
            this.UserGroupBox.TabIndex = 1;
            this.UserGroupBox.TabStop = false;
            this.UserGroupBox.Text = "Complete user information";
            // 
            // UserTextBox
            // 
            UserTextBox.BackColor = System.Drawing.SystemColors.Window;
            UserTextBox.Location = new System.Drawing.Point(124, 81);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new System.Drawing.Size(208, 26);
            UserTextBox.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(11, 153);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(86, 20);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password :";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(124, 150);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(208, 26);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(142, 212);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(95, 51);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Encrypt";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encrypted Password";
            // 
            // EncryptedPassList
            // 
            this.EncryptedPassList.FormattingEnabled = true;
            this.EncryptedPassList.ItemHeight = 20;
            this.EncryptedPassList.Location = new System.Drawing.Point(26, 82);
            this.EncryptedPassList.Name = "EncryptedPassList";
            this.EncryptedPassList.Size = new System.Drawing.Size(350, 24);
            this.EncryptedPassList.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DecryptButton);
            this.groupBox1.Controls.Add(this.EncryptedPassList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(396, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 145);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptButton.Location = new System.Drawing.Point(346, 32);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(30, 24);
            this.DecryptButton.TabIndex = 6;
            this.DecryptButton.Text = "Decrypt ";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // hiddenDecryptLabel
            // 
            this.hiddenDecryptLabel.AutoSize = true;
            this.hiddenDecryptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenDecryptLabel.Location = new System.Drawing.Point(546, 41);
            this.hiddenDecryptLabel.Name = "hiddenDecryptLabel";
            this.hiddenDecryptLabel.Size = new System.Drawing.Size(75, 16);
            this.hiddenDecryptLabel.TabIndex = 7;
            this.hiddenDecryptLabel.Text = "Hidden text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.hiddenDecryptLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UserGroupBox);
            this.Name = "Form1";
            this.Text = "Encription ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UserGroupBox.ResumeLayout(false);
            this.UserGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.GroupBox UserGroupBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox EncryptedPassList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label hiddenDecryptLabel;
    }
}

