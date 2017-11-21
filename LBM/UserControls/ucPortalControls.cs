using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LBM
{
    public partial class ucPortalControls : UserControl
    {
        private FormClients m_Clients;

        public ucPortalControls()
        {
            InitializeComponent();
            if (DesignMode) return;
            Init();
        }

        private void Init()
        {
            m_Clients = new FormClients();
            m_Clients.FormClosing += new FormClosingEventHandler(m_Clients_FormClosing);
        }

        private void m_Clients_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            m_Clients.Hide();
        }

        public void SetUser(string username)
        {
            this.lblGreeting.Text = String.Format("LB Management: Welcome {0}!", username);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            m_Clients.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
