namespace Projet_SAE_24_Stargate
{
    partial class Stats
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
            this.cboStats = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboStats
            // 
            this.cboStats.FormattingEnabled = true;
            this.cboStats.Location = new System.Drawing.Point(13, 13);
            this.cboStats.Name = "cboStats";
            this.cboStats.Size = new System.Drawing.Size(930, 28);
            this.cboStats.TabIndex = 0;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 600);
            this.Controls.Add(this.cboStats);
            this.Name = "Stats";
            this.Text = "Stats";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboStats;
    }
}