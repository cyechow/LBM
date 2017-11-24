using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.SqlServer.Server;

namespace LBM
{
    public partial class FormLogin : Form
    {
        private string userName = String.Empty;
        private string userPassword = String.Empty;

        private DbInterface dbInterface = DbInterface.Instance;

        private FormMain mainInterface;

        public FormLogin()
        {
            InitializeComponent();
            if (DesignMode) return;

            InitializeInterface();
        }

        private void InitializeInterface()
        {
            mainInterface = new FormMain();
            mainInterface.FormClosing += new FormClosingEventHandler(HandleMainUIClosing);
        }

        /// <summary>
        /// Exit from program handled only in the login form so main UI close event is canceled and login UI is shown.
        /// </summary>
        private void HandleMainUIClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            mainInterface.Hide();
            this.Show();
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginToProgram(object sender, EventArgs e)
        {
            GetUserCredentials();
            ValidateUserCredentials();
            DisplayMainInterface();
        }

        private void GetUserCredentials()
        {
            this.userName = this.tbUsername.Text;
            this.userPassword = this.tbPassword.Text;
        }

        private void ValidateUserCredentials()
        {
            try
            {
                dbInterface.AuthenticateUser(this.userName, this.userPassword);
            }
            catch (Exception exc)
            {
                string errMsg = ExceptionHandler.GetExceptionDetails(exc);
                ShowLoginErrorRetryPopup(errMsg);
            }
        }

        private void DisplayMainInterface()
        {
            if (!dbInterface.IsUserAuthenticated) { return; }

            this.Hide();
            mainInterface.SetAppUser(this.userName);
            mainInterface.Show();
        }

        private void ShowLoginErrorRetryPopup(string errMsg)
        {
            DialogResult result = MessageBox.Show(errMsg, "Login Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
