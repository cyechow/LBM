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
		private DbInterface dbInterface = DbInterface.Instance;
		private bool isClientCreated;

		public ucClientNew()
		{
			InitializeComponent();
			if (DesignMode) { return; }

			Init();
		}

		private void Init()
		{
			this.dtpAccountOpened.Value = DateTime.Now.Date;
			this.isClientCreated = false;
		}

		public void ResetDisplay()
		{
			this.tbClientNameFull.Text = String.Empty;
			this.tbClientMainContact.Text = String.Empty;
			this.tbClientEmailContact.Text = String.Empty;
			this.tbClientContactNumber.Text = String.Empty;
			this.dtpAccountOpened.Value = DateTime.Now.Date;
		}

		private void CreateNewClient(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(this.tbClientNameFull.Text))
			{
				DisplayMessageBox("Client's name must be populated");
				return;
			}

			LbClient clientDataNew = GetClientInfo();
			SaveClientData(clientDataNew);
			if (!isClientCreated) { return; }

			ShowClientCreationSuccess();
			ResetDisplay();
		}

		private void SaveClientData(LbClient clientData)
		{
			try
			{
				dbInterface.SendClientDataToDb(-1, clientData);
				isClientCreated = true;
			}
			catch (Exception exc)
			{
				string errMsg = ExceptionHandler.GetExceptionDetails(exc);
				ShowClientCreationError(errMsg);
			}
		}

		private LbClient GetClientInfo()
		{
			LbClient clientDataNew = new LbClient(this.tbClientNameFull.Text, this.dtpAccountOpened.Value.Date, this.tbClientMainContact.Text, this.tbClientEmailContact.Text, this.tbClientContactNumber.Text);
			return clientDataNew;
		}

		private void DisplayMessageBox(string message)
		{
			MessageBox.Show(message);
		}

		private void ShowClientCreationSuccess()
		{
			DisplayMessageBox("Client saved successfully!");
		}
		private void ShowClientCreationError(string errMsg)
		{
			MessageBox.Show(errMsg, "DB Storage Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
