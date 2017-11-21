namespace LBM
{
    partial class FormClientCreator
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
            this.ucDisplay = new LBM.ucClientNew();
            this.SuspendLayout();
            // 
            // ucDisplay
            // 
            this.ucDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDisplay.Location = new System.Drawing.Point(0, 0);
            this.ucDisplay.Name = "ucDisplay";
            this.ucDisplay.Size = new System.Drawing.Size(662, 167);
            this.ucDisplay.TabIndex = 0;
            // 
            // FormClientNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 167);
            this.Controls.Add(this.ucDisplay);
            this.Name = "FormClientNew";
            this.Text = "Create New Client";
            this.ResumeLayout(false);

        }

        #endregion

        private ucClientNew ucDisplay;
    }
}