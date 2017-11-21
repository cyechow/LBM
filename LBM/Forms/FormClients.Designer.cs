namespace LBM
{
    partial class FormClients
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
            this.ucClientDisplay = new LBM.ucClientViewer();
            this.SuspendLayout();
            // 
            // ucClientDisplay
            // 
            this.ucClientDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucClientDisplay.Location = new System.Drawing.Point(0, 0);
            this.ucClientDisplay.Name = "ucClientDisplay";
            this.ucClientDisplay.Size = new System.Drawing.Size(922, 569);
            this.ucClientDisplay.TabIndex = 0;
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 569);
            this.Controls.Add(this.ucClientDisplay);
            this.Name = "FormClients";
            this.Text = "LB Clients";
            this.ResumeLayout(false);

        }

        #endregion

        private ucClientViewer ucClientDisplay;
    }
}