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
        private string m_UserName = String.Empty;
        private string m_Password = String.Empty;

        private FormMain m_Main;

        public FormLogin()
        {
            InitializeComponent();
            if (DesignMode) return;

            m_Main = new FormMain();
            m_Main.FormClosing += new FormClosingEventHandler(m_Main_FormClosing);
        }

        private void m_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            m_Main.Hide();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.m_UserName = this.tbUsername.Text;
            this.m_Password = this.tbPassword.Text;

            DbInterface dbInterface = DbInterface.Instance;
            string errMsg = String.Empty;
            if (!dbInterface.AuthenticateUser(m_UserName, m_Password, out errMsg))
            {
                DialogResult result = MessageBox.Show(errMsg, "Login Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            else
            {
                this.Hide();
                m_Main.SetAppUser(this.m_UserName);
                m_Main.Show();
            }
        }
    }
}
