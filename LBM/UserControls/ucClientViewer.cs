using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LBM
{
    public partial class ucClientViewer : UserControl
    {
        private DbInterface dbInterface = DbInterface.Instance;
        private FormClientCreator clientCreator;

        private int idxClientSelected = -1;

        public ucClientViewer()
        {
            InitializeComponent();
            if (DesignMode) return;

            Init();
        }

        private void Init()
        {
            PopulateClientList();
            clientCreator = new FormClientCreator();
            clientCreator.FormClosing += new FormClosingEventHandler(clientCreator_FormClosing);
        }
        private void PopulateClientList()
        {
            ReadOnlyCollection<int> lClientIds = dbInterface.QueryClientIdList();
            if (lClientIds.Count == 0) { return; }

            foreach (int clientId in lClientIds)
            {
                string clientName = dbInterface.RetrieveClientNameFromDb(clientId);
                if (clientName == "Unknown") { clientName = clientId.ToString(); }
                this.lbClients.Items.Add(clientName);
            }
        }
        private void UpdateClientList()
        {
            this.lbClients.Items.Clear();
            PopulateClientList();
        }

        private void clientCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            clientCreator.Hide();
            UpdateClientList();
        }

        private void dgvClientHistory_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // TBD: Detect order selected based on row and open up order details.

        }

        private void btnSaveClientDetails_Click(object sender, EventArgs e)
        {
            // TBD: Save any changes made to the client details to the DB.
            LbClient clientDataUpdated = RetrieveClientDataFromDisplay();
            int clientId = Convert.ToInt32(this.nudClientId.Value);
            if (clientDataUpdated != null)
            {
                string errMsg = "";
                if (!dbInterface.SaveClientDataToDB(clientId, clientDataUpdated, out errMsg))
                {
                    MessageBox.Show(errMsg, "DB Storage Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            clientCreator.Refresh();
            clientCreator.Show();
        }

        private void lbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idxClientSelected == this.lbClients.SelectedIndex || this.lbClients.SelectedIndex < 0) { return; }
            idxClientSelected = this.lbClients.SelectedIndex;

            int clientId = dbInterface.RetrieveClientIdFromDb(this.lbClients.SelectedItem.ToString());

            UpdateClientDataDisplay(clientId);
        }

        private void ResetViewerDisplay()
        {
            this.nudClientId.Value = 0;
            this.tbClientNameFull.Text = "";
            this.tbClientMainContact.Text = "";
            this.tbClientEmailContact.Text = "";
            this.tbClientContactNumber.Text = "";
            this.dtpAccountOpened.Value = DateTime.Now;
        }

        private void UpdateClientDataDisplay(int clientId)
        {
            if (clientId < 0)
            {
                ResetViewerDisplay();
                return;
            }

            LbClient clientData = dbInterface.RetrieveClientDetailsFromDb(clientId);

            this.nudClientId.Value = clientId;
            this.tbClientNameFull.Text = clientData.ClientName;
            this.tbClientMainContact.Text = clientData.ContactName;
            this.tbClientEmailContact.Text = clientData.ContactEmail;
            this.tbClientContactNumber.Text = clientData.ContactPhoneNumber;
            this.dtpAccountOpened.Value = clientData.AccountOpened;
        }

        private LbClient RetrieveClientDataFromDisplay()
        {
            if (String.IsNullOrEmpty(this.tbClientNameFull.Text)) { return null; }

            LbClient clientData = new LbClient(this.tbClientNameFull.Text, this.dtpAccountOpened.Value.Date, this.tbClientMainContact.Text, this.tbClientEmailContact.Text, this.tbClientContactNumber.Text);

            return clientData;
        }
    }
}
