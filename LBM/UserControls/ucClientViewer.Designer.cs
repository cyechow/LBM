namespace LBM
{
    partial class ucClientViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.pClientDetails = new System.Windows.Forms.Panel();
            this.lblClientOrderHistory = new System.Windows.Forms.Label();
            this.dgvClientHistory = new System.Windows.Forms.DataGridView();
            this.tbClientContactNumber = new System.Windows.Forms.TextBox();
            this.lblClientContactNumber = new System.Windows.Forms.Label();
            this.lblClientContactEmail = new System.Windows.Forms.Label();
            this.tbClientEmailContact = new System.Windows.Forms.TextBox();
            this.tbClientMainContact = new System.Windows.Forms.TextBox();
            this.lblClientMainContact = new System.Windows.Forms.Label();
            this.lblClientAccountOpen = new System.Windows.Forms.Label();
            this.dtpAccountOpened = new System.Windows.Forms.DateTimePicker();
            this.btnSaveClientDetails = new System.Windows.Forms.Button();
            this.tbClientNameFull = new System.Windows.Forms.TextBox();
            this.lblClientNameFull = new System.Windows.Forms.Label();
            this.pClientList = new System.Windows.Forms.Panel();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudClientId = new System.Windows.Forms.NumericUpDown();
            this.pClientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientHistory)).BeginInit();
            this.pClientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClientId)).BeginInit();
            this.SuspendLayout();
            // 
            // lbClients
            // 
            this.lbClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbClients.FormattingEnabled = true;
            this.lbClients.Location = new System.Drawing.Point(0, 0);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(123, 527);
            this.lbClients.TabIndex = 0;
            this.lbClients.SelectedIndexChanged += new System.EventHandler(this.lbClients_SelectedIndexChanged);
            // 
            // pClientDetails
            // 
            this.pClientDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pClientDetails.Controls.Add(this.nudClientId);
            this.pClientDetails.Controls.Add(this.label1);
            this.pClientDetails.Controls.Add(this.lblClientOrderHistory);
            this.pClientDetails.Controls.Add(this.dgvClientHistory);
            this.pClientDetails.Controls.Add(this.tbClientContactNumber);
            this.pClientDetails.Controls.Add(this.lblClientContactNumber);
            this.pClientDetails.Controls.Add(this.lblClientContactEmail);
            this.pClientDetails.Controls.Add(this.tbClientEmailContact);
            this.pClientDetails.Controls.Add(this.tbClientMainContact);
            this.pClientDetails.Controls.Add(this.lblClientMainContact);
            this.pClientDetails.Controls.Add(this.lblClientAccountOpen);
            this.pClientDetails.Controls.Add(this.dtpAccountOpened);
            this.pClientDetails.Controls.Add(this.btnSaveClientDetails);
            this.pClientDetails.Controls.Add(this.tbClientNameFull);
            this.pClientDetails.Controls.Add(this.lblClientNameFull);
            this.pClientDetails.Location = new System.Drawing.Point(129, 51);
            this.pClientDetails.Name = "pClientDetails";
            this.pClientDetails.Size = new System.Drawing.Size(775, 479);
            this.pClientDetails.TabIndex = 1;
            // 
            // lblClientOrderHistory
            // 
            this.lblClientOrderHistory.AutoSize = true;
            this.lblClientOrderHistory.Location = new System.Drawing.Point(3, 101);
            this.lblClientOrderHistory.Name = "lblClientOrderHistory";
            this.lblClientOrderHistory.Size = new System.Drawing.Size(71, 13);
            this.lblClientOrderHistory.TabIndex = 12;
            this.lblClientOrderHistory.Text = "Order History:";
            // 
            // dgvClientHistory
            // 
            this.dgvClientHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientHistory.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClientHistory.Location = new System.Drawing.Point(3, 117);
            this.dgvClientHistory.Name = "dgvClientHistory";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClientHistory.Size = new System.Drawing.Size(769, 311);
            this.dgvClientHistory.TabIndex = 11;
            this.dgvClientHistory.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientHistory_CellContentDoubleClick);
            // 
            // tbClientContactNumber
            // 
            this.tbClientContactNumber.Location = new System.Drawing.Point(481, 33);
            this.tbClientContactNumber.Name = "tbClientContactNumber";
            this.tbClientContactNumber.Size = new System.Drawing.Size(140, 20);
            this.tbClientContactNumber.TabIndex = 10;
            // 
            // lblClientContactNumber
            // 
            this.lblClientContactNumber.AutoSize = true;
            this.lblClientContactNumber.Location = new System.Drawing.Point(447, 36);
            this.lblClientContactNumber.Name = "lblClientContactNumber";
            this.lblClientContactNumber.Size = new System.Drawing.Size(28, 13);
            this.lblClientContactNumber.TabIndex = 9;
            this.lblClientContactNumber.Text = "Tel.:";
            // 
            // lblClientContactEmail
            // 
            this.lblClientContactEmail.AutoSize = true;
            this.lblClientContactEmail.Location = new System.Drawing.Point(260, 36);
            this.lblClientContactEmail.Name = "lblClientContactEmail";
            this.lblClientContactEmail.Size = new System.Drawing.Size(35, 13);
            this.lblClientContactEmail.TabIndex = 8;
            this.lblClientContactEmail.Text = "Email:";
            // 
            // tbClientEmailContact
            // 
            this.tbClientEmailContact.Location = new System.Drawing.Point(301, 33);
            this.tbClientEmailContact.Name = "tbClientEmailContact";
            this.tbClientEmailContact.Size = new System.Drawing.Size(140, 20);
            this.tbClientEmailContact.TabIndex = 7;
            // 
            // tbClientMainContact
            // 
            this.tbClientMainContact.Location = new System.Drawing.Point(114, 33);
            this.tbClientMainContact.Name = "tbClientMainContact";
            this.tbClientMainContact.Size = new System.Drawing.Size(140, 20);
            this.tbClientMainContact.TabIndex = 6;
            // 
            // lblClientMainContact
            // 
            this.lblClientMainContact.AutoSize = true;
            this.lblClientMainContact.Location = new System.Drawing.Point(3, 36);
            this.lblClientMainContact.Name = "lblClientMainContact";
            this.lblClientMainContact.Size = new System.Drawing.Size(104, 13);
            this.lblClientMainContact.TabIndex = 5;
            this.lblClientMainContact.Text = "Main Contact Name:";
            // 
            // lblClientAccountOpen
            // 
            this.lblClientAccountOpen.AutoSize = true;
            this.lblClientAccountOpen.Location = new System.Drawing.Point(3, 67);
            this.lblClientAccountOpen.Name = "lblClientAccountOpen";
            this.lblClientAccountOpen.Size = new System.Drawing.Size(105, 13);
            this.lblClientAccountOpen.TabIndex = 4;
            this.lblClientAccountOpen.Text = "Account Open Date:";
            // 
            // dtpAccountOpened
            // 
            this.dtpAccountOpened.Location = new System.Drawing.Point(114, 61);
            this.dtpAccountOpened.Name = "dtpAccountOpened";
            this.dtpAccountOpened.Size = new System.Drawing.Size(140, 20);
            this.dtpAccountOpened.TabIndex = 3;
            // 
            // btnSaveClientDetails
            // 
            this.btnSaveClientDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveClientDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveClientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClientDetails.Location = new System.Drawing.Point(630, 434);
            this.btnSaveClientDetails.Name = "btnSaveClientDetails";
            this.btnSaveClientDetails.Size = new System.Drawing.Size(142, 42);
            this.btnSaveClientDetails.TabIndex = 2;
            this.btnSaveClientDetails.Text = "Save Changes";
            this.btnSaveClientDetails.UseVisualStyleBackColor = true;
            this.btnSaveClientDetails.Click += new System.EventHandler(this.btnSaveClientDetails_Click);
            // 
            // tbClientNameFull
            // 
            this.tbClientNameFull.Location = new System.Drawing.Point(114, 7);
            this.tbClientNameFull.Name = "tbClientNameFull";
            this.tbClientNameFull.Size = new System.Drawing.Size(140, 20);
            this.tbClientNameFull.TabIndex = 1;
            // 
            // lblClientNameFull
            // 
            this.lblClientNameFull.AutoSize = true;
            this.lblClientNameFull.Location = new System.Drawing.Point(3, 10);
            this.lblClientNameFull.Name = "lblClientNameFull";
            this.lblClientNameFull.Size = new System.Drawing.Size(67, 13);
            this.lblClientNameFull.TabIndex = 0;
            this.lblClientNameFull.Text = "Client Name:";
            // 
            // pClientList
            // 
            this.pClientList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pClientList.Controls.Add(this.lbClients);
            this.pClientList.Location = new System.Drawing.Point(3, 3);
            this.pClientList.Name = "pClientList";
            this.pClientList.Size = new System.Drawing.Size(123, 527);
            this.pClientList.TabIndex = 13;
            // 
            // btnNewClient
            // 
            this.btnNewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewClient.Location = new System.Drawing.Point(697, 3);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(207, 42);
            this.btnNewClient.TabIndex = 13;
            this.btnNewClient.Text = "Create New Client";
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Client ID:";
            // 
            // nudClientId
            // 
            this.nudClientId.Location = new System.Drawing.Point(316, 7);
            this.nudClientId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudClientId.Name = "nudClientId";
            this.nudClientId.ReadOnly = true;
            this.nudClientId.Size = new System.Drawing.Size(56, 20);
            this.nudClientId.TabIndex = 14;
            // 
            // ucClientViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.pClientList);
            this.Controls.Add(this.pClientDetails);
            this.Name = "ucClientViewer";
            this.Size = new System.Drawing.Size(907, 533);
            this.pClientDetails.ResumeLayout(false);
            this.pClientDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientHistory)).EndInit();
            this.pClientList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudClientId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.Panel pClientDetails;
        private System.Windows.Forms.TextBox tbClientNameFull;
        private System.Windows.Forms.Label lblClientNameFull;
        private System.Windows.Forms.Button btnSaveClientDetails;
        private System.Windows.Forms.Label lblClientAccountOpen;
        private System.Windows.Forms.DateTimePicker dtpAccountOpened;
        private System.Windows.Forms.TextBox tbClientMainContact;
        private System.Windows.Forms.Label lblClientMainContact;
        private System.Windows.Forms.Label lblClientContactEmail;
        private System.Windows.Forms.TextBox tbClientEmailContact;
        private System.Windows.Forms.TextBox tbClientContactNumber;
        private System.Windows.Forms.Label lblClientContactNumber;
        private System.Windows.Forms.DataGridView dgvClientHistory;
        private System.Windows.Forms.Label lblClientOrderHistory;
        private System.Windows.Forms.Panel pClientList;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudClientId;
    }
}
