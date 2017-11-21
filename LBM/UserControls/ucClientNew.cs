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
    public partial class ucClientNew : UserControl
    {
        private DbInterface m_DbInterface = DbInterface.Instance;

        public ucClientNew()
        {
            InitializeComponent();
            if (DesignMode) { return; }

            Init();
        }

        private void Init()
        {
            // Set to current date:
            this.dtpAccountOpened.Value = DateTime.Now.Date;
        }

        public void Reset()
        {
            this.tbClientNameFull.Text = String.Empty;
            this.tbClientMainContact.Text = String.Empty;
            this.tbClientEmailContact.Text = String.Empty;
            this.tbClientContactNumber.Text = String.Empty;
            this.dtpAccountOpened.Value = DateTime.Now.Date;
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tbClientNameFull.Text))
            {
                MessageBox.Show("Client's name must be populated");
                return;
            }

            LbClient clientDataNew = new LbClient(this.tbClientNameFull.Text, this.dtpAccountOpened.Value.Date, this.tbClientMainContact.Text, this.tbClientEmailContact.Text, this.tbClientContactNumber.Text);

            string errMsg = "";
            if (!m_DbInterface.SaveClientDataToDB(-1, clientDataNew, out errMsg))
            {
                MessageBox.Show(errMsg, "DB Storage Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Client saved successfully!");
                Reset();
            }
        }
    }
}
