namespace LBM
{
    partial class ucClientNew
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
            this.tbClientContactNumber = new System.Windows.Forms.TextBox();
            this.lblClientContactNumber = new System.Windows.Forms.Label();
            this.lblClientContactEmail = new System.Windows.Forms.Label();
            this.tbClientEmailContact = new System.Windows.Forms.TextBox();
            this.tbClientMainContact = new System.Windows.Forms.TextBox();
            this.lblClientMainContact = new System.Windows.Forms.Label();
            this.lblClientAccountOpen = new System.Windows.Forms.Label();
            this.dtpAccountOpened = new System.Windows.Forms.DateTimePicker();
            this.tbClientNameFull = new System.Windows.Forms.TextBox();
            this.lblClientNameFull = new System.Windows.Forms.Label();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbClientContactNumber
            // 
            this.tbClientContactNumber.Location = new System.Drawing.Point(481, 36);
            this.tbClientContactNumber.Name = "tbClientContactNumber";
            this.tbClientContactNumber.Size = new System.Drawing.Size(140, 20);
            this.tbClientContactNumber.TabIndex = 3;
            // 
            // lblClientContactNumber
            // 
            this.lblClientContactNumber.AutoSize = true;
            this.lblClientContactNumber.Location = new System.Drawing.Point(447, 39);
            this.lblClientContactNumber.Name = "lblClientContactNumber";
            this.lblClientContactNumber.Size = new System.Drawing.Size(28, 13);
            this.lblClientContactNumber.TabIndex = 19;
            this.lblClientContactNumber.Text = "Tel.:";
            // 
            // lblClientContactEmail
            // 
            this.lblClientContactEmail.AutoSize = true;
            this.lblClientContactEmail.Location = new System.Drawing.Point(260, 39);
            this.lblClientContactEmail.Name = "lblClientContactEmail";
            this.lblClientContactEmail.Size = new System.Drawing.Size(35, 13);
            this.lblClientContactEmail.TabIndex = 18;
            this.lblClientContactEmail.Text = "Email:";
            // 
            // tbClientEmailContact
            // 
            this.tbClientEmailContact.Location = new System.Drawing.Point(301, 36);
            this.tbClientEmailContact.Name = "tbClientEmailContact";
            this.tbClientEmailContact.Size = new System.Drawing.Size(140, 20);
            this.tbClientEmailContact.TabIndex = 2;
            // 
            // tbClientMainContact
            // 
            this.tbClientMainContact.Location = new System.Drawing.Point(114, 36);
            this.tbClientMainContact.Name = "tbClientMainContact";
            this.tbClientMainContact.Size = new System.Drawing.Size(140, 20);
            this.tbClientMainContact.TabIndex = 1;
            // 
            // lblClientMainContact
            // 
            this.lblClientMainContact.AutoSize = true;
            this.lblClientMainContact.Location = new System.Drawing.Point(3, 39);
            this.lblClientMainContact.Name = "lblClientMainContact";
            this.lblClientMainContact.Size = new System.Drawing.Size(104, 13);
            this.lblClientMainContact.TabIndex = 15;
            this.lblClientMainContact.Text = "Main Contact Name:";
            // 
            // lblClientAccountOpen
            // 
            this.lblClientAccountOpen.AutoSize = true;
            this.lblClientAccountOpen.Location = new System.Drawing.Point(3, 70);
            this.lblClientAccountOpen.Name = "lblClientAccountOpen";
            this.lblClientAccountOpen.Size = new System.Drawing.Size(105, 13);
            this.lblClientAccountOpen.TabIndex = 14;
            this.lblClientAccountOpen.Text = "Account Open Date:";
            // 
            // dtpAccountOpened
            // 
            this.dtpAccountOpened.Location = new System.Drawing.Point(114, 64);
            this.dtpAccountOpened.Name = "dtpAccountOpened";
            this.dtpAccountOpened.Size = new System.Drawing.Size(140, 20);
            this.dtpAccountOpened.TabIndex = 4;
            // 
            // tbClientNameFull
            // 
            this.tbClientNameFull.Location = new System.Drawing.Point(114, 10);
            this.tbClientNameFull.Name = "tbClientNameFull";
            this.tbClientNameFull.Size = new System.Drawing.Size(140, 20);
            this.tbClientNameFull.TabIndex = 0;
            // 
            // lblClientNameFull
            // 
            this.lblClientNameFull.AutoSize = true;
            this.lblClientNameFull.Location = new System.Drawing.Point(3, 13);
            this.lblClientNameFull.Name = "lblClientNameFull";
            this.lblClientNameFull.Size = new System.Drawing.Size(67, 13);
            this.lblClientNameFull.TabIndex = 11;
            this.lblClientNameFull.Text = "Client Name:";
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateClient.Location = new System.Drawing.Point(3, 90);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(650, 48);
            this.btnCreateClient.TabIndex = 5;
            this.btnCreateClient.Text = "Create Client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.CreateNewClient);
            // 
            // ucClientNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCreateClient);
            this.Controls.Add(this.tbClientContactNumber);
            this.Controls.Add(this.lblClientContactNumber);
            this.Controls.Add(this.lblClientContactEmail);
            this.Controls.Add(this.tbClientEmailContact);
            this.Controls.Add(this.tbClientMainContact);
            this.Controls.Add(this.lblClientMainContact);
            this.Controls.Add(this.lblClientAccountOpen);
            this.Controls.Add(this.dtpAccountOpened);
            this.Controls.Add(this.tbClientNameFull);
            this.Controls.Add(this.lblClientNameFull);
            this.Name = "ucClientNew";
            this.Size = new System.Drawing.Size(656, 141);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbClientContactNumber;
        private System.Windows.Forms.Label lblClientContactNumber;
        private System.Windows.Forms.Label lblClientContactEmail;
        private System.Windows.Forms.TextBox tbClientEmailContact;
        private System.Windows.Forms.TextBox tbClientMainContact;
        private System.Windows.Forms.Label lblClientMainContact;
        private System.Windows.Forms.Label lblClientAccountOpen;
        private System.Windows.Forms.DateTimePicker dtpAccountOpened;
        private System.Windows.Forms.TextBox tbClientNameFull;
        private System.Windows.Forms.Label lblClientNameFull;
        private System.Windows.Forms.Button btnCreateClient;
    }
}
