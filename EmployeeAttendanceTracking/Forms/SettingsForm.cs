using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeAttendanceTracking.Forms
{
    public partial class SettingsForm : Form
    {
        /// <summary>
        /// This form get email user information.(There is no default mail.)
        /// </summary>
        public SettingsForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Save settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            if ((new[] { serverTextBox.Text, portTextBox.Text, usernameTextBox.Text, passwordTextBox.Text, receiverMailText.Text }).Any(string.IsNullOrEmpty))
            {
                Properties.Settings.Default.SMTP_SERVER = serverTextBox.Text;
                Properties.Settings.Default.SMTP_PORT = portTextBox.Text;
                Properties.Settings.Default.SMTP_USERNAME = usernameTextBox.Text;
                Properties.Settings.Default.SMTP_PASSWORD = passwordTextBox.Text;
                Properties.Settings.Default.ADMIN_EMAIL = receiverMailText.Text;
                Properties.Settings.Default.SSL_ENABLED = SSLStatus.Checked;
            }
        }

        /// <summary>
        /// Cancel operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
