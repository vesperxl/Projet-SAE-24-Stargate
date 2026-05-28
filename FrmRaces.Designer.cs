namespace Projet_SAE_24_Stargate
{
    partial class frmRaces
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkBoxTriAlpha = new System.Windows.Forms.CheckBox();
            this.chkBoxTriCoul = new System.Windows.Forms.CheckBox();
            this.cboNom = new System.Windows.Forms.ComboBox();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(920, 537);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // chkBoxTriAlpha
            // 
            this.chkBoxTriAlpha.AutoSize = true;
            this.chkBoxTriAlpha.ForeColor = System.Drawing.Color.White;
            this.chkBoxTriAlpha.Location = new System.Drawing.Point(14, 575);
            this.chkBoxTriAlpha.Name = "chkBoxTriAlpha";
            this.chkBoxTriAlpha.Size = new System.Drawing.Size(177, 24);
            this.chkBoxTriAlpha.TabIndex = 1;
            this.chkBoxTriAlpha.Text = "Triage Alphabétique";
            this.chkBoxTriAlpha.UseVisualStyleBackColor = true;
            this.chkBoxTriAlpha.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkBoxTriCoul
            // 
            this.chkBoxTriCoul.AutoSize = true;
            this.chkBoxTriCoul.ForeColor = System.Drawing.Color.White;
            this.chkBoxTriCoul.Location = new System.Drawing.Point(196, 575);
            this.chkBoxTriCoul.Name = "chkBoxTriCoul";
            this.chkBoxTriCoul.Size = new System.Drawing.Size(138, 24);
            this.chkBoxTriCoul.TabIndex = 2;
            this.chkBoxTriCoul.Text = "Triage Couleur";
            this.chkBoxTriCoul.UseVisualStyleBackColor = true;
            this.chkBoxTriCoul.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // cboNom
            // 
            this.cboNom.FormattingEnabled = true;
            this.cboNom.Location = new System.Drawing.Point(342, 575);
            this.cboNom.Name = "cboNom";
            this.cboNom.Size = new System.Drawing.Size(193, 28);
            this.cboNom.TabIndex = 3;
            this.cboNom.SelectedIndexChanged += new System.EventHandler(this.cboNom_SelectedIndexChanged);
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(542, 575);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(194, 28);
            this.cboColor.TabIndex = 4;
            this.cboColor.SelectedIndexChanged += new System.EventHandler(this.cboColor_SelectedIndexChanged);
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(741, 575);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(176, 28);
            this.cboType.TabIndex = 5;
            // 
            // frmRaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(928, 629);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.cboNom);
            this.Controls.Add(this.chkBoxTriCoul);
            this.Controls.Add(this.chkBoxTriAlpha);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmRaces";
            this.Text = "frmRaces";
            this.Load += new System.EventHandler(this.frmRaces_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chkBoxTriAlpha;
        private System.Windows.Forms.CheckBox chkBoxTriCoul;
        private System.Windows.Forms.ComboBox cboNom;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.ComboBox cboType;
    }
}