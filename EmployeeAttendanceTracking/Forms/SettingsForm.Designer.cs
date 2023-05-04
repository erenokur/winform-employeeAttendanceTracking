
using System.Windows.Forms;

namespace EmployeeAttendanceTracking.Forms
{
    partial class SettingsForm
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
            this.serverLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.receiverMailLabel = new System.Windows.Forms.Label();
            this.receiverMailText = new System.Windows.Forms.TextBox();
            this.SSLStatus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(12, 20);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(88, 13);
            this.serverLabel.TabIndex = 0;
            this.serverLabel.Text = "SMTP Sunucusu";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(12, 50);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(65, 13);
            this.portLabel.TabIndex = 1;
            this.portLabel.Text = "SMTP Portu";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(12, 80);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(63, 13);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Kullanıcı adı";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 110);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(28, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Şifre";
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(104, 17);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(100, 20);
            this.serverTextBox.TabIndex = 4;
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(104, 47);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 20);
            this.portTextBox.TabIndex = 5;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(104, 80);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(104, 110);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(212, 20);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Kaydet";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(212, 91);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Iptal";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // receiverMailLabel
            // 
            this.receiverMailLabel.AutoSize = true;
            this.receiverMailLabel.Location = new System.Drawing.Point(12, 144);
            this.receiverMailLabel.Name = "receiverMailLabel";
            this.receiverMailLabel.Size = new System.Drawing.Size(69, 13);
            this.receiverMailLabel.TabIndex = 6;
            this.receiverMailLabel.Text = "Yönetici Maili";
            // 
            // receiverMailText
            // 
            this.receiverMailText.Location = new System.Drawing.Point(104, 141);
            this.receiverMailText.Name = "receiverMailText";
            this.receiverMailText.Size = new System.Drawing.Size(100, 20);
            this.receiverMailText.TabIndex = 7;
            // 
            // SSLStatus
            // 
            this.SSLStatus.AutoSize = true;
            this.SSLStatus.Location = new System.Drawing.Point(104, 168);
            this.SSLStatus.Name = "SSLStatus";
            this.SSLStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SSLStatus.Size = new System.Drawing.Size(70, 17);
            this.SSLStatus.TabIndex = 8;
            this.SSLStatus.Text = "SSL Açık";
            this.SSLStatus.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 189);
            this.Controls.Add(this.SSLStatus);
            this.Controls.Add(this.receiverMailText);
            this.Controls.Add(this.receiverMailLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.serverTextBox);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.portTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMTP Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label receiverMailLabel;
        private Label serverLabel;
        private Label portLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox serverTextBox;
        private TextBox portTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private TextBox receiverMailText;
        private Button saveButton;
        private Button cancelButton;
        private CheckBox SSLStatus;
    }
}