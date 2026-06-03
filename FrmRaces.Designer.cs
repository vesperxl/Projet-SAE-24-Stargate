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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblHosti = new System.Windows.Forms.Label();
            this.btnRes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(276, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(975, 788);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // chkBoxTriAlpha
            // 
            this.chkBoxTriAlpha.AutoSize = true;
            this.chkBoxTriAlpha.ForeColor = System.Drawing.Color.White;
            this.chkBoxTriAlpha.Location = new System.Drawing.Point(6, 47);
            this.chkBoxTriAlpha.Name = "chkBoxTriAlpha";
            this.chkBoxTriAlpha.Size = new System.Drawing.Size(197, 29);
            this.chkBoxTriAlpha.TabIndex = 1;
            this.chkBoxTriAlpha.Text = "Tri Alphabétique";
            this.chkBoxTriAlpha.UseVisualStyleBackColor = true;
            this.chkBoxTriAlpha.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkBoxTriCoul
            // 
            this.chkBoxTriCoul.AutoSize = true;
            this.chkBoxTriCoul.ForeColor = System.Drawing.Color.White;
            this.chkBoxTriCoul.Location = new System.Drawing.Point(6, 91);
            this.chkBoxTriCoul.Name = "chkBoxTriCoul";
            this.chkBoxTriCoul.Size = new System.Drawing.Size(146, 29);
            this.chkBoxTriCoul.TabIndex = 2;
            this.chkBoxTriCoul.Text = "Tri Couleur";
            this.chkBoxTriCoul.UseVisualStyleBackColor = true;
            this.chkBoxTriCoul.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // cboNom
            // 
            this.cboNom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNom.FormattingEnabled = true;
            this.cboNom.Location = new System.Drawing.Point(8, 409);
            this.cboNom.Name = "cboNom";
            this.cboNom.Size = new System.Drawing.Size(244, 33);
            this.cboNom.TabIndex = 3;
            this.cboNom.SelectedIndexChanged += new System.EventHandler(this.cboNom_SelectedIndexChanged);
            // 
            // cboColor
            // 
            this.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(6, 243);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(245, 33);
            this.cboColor.TabIndex = 4;
            this.cboColor.SelectedIndexChanged += new System.EventHandler(this.cboColor_SelectedIndexChanged);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(6, 75);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(244, 33);
            this.cboType.TabIndex = 5;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBoxTriAlpha);
            this.groupBox1.Controls.Add(this.chkBoxTriCoul);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNom);
            this.groupBox2.Controls.Add(this.lblColor);
            this.groupBox2.Controls.Add(this.lblHosti);
            this.groupBox2.Controls.Add(this.cboColor);
            this.groupBox2.Controls.Add(this.cboType);
            this.groupBox2.Controls.Add(this.cboNom);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(13, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 513);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtre";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 381);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(56, 25);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "Nom";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(6, 215);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(88, 25);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Couleur";
            // 
            // lblHosti
            // 
            this.lblHosti.AutoSize = true;
            this.lblHosti.Location = new System.Drawing.Point(6, 47);
            this.lblHosti.Name = "lblHosti";
            this.lblHosti.Size = new System.Drawing.Size(89, 25);
            this.lblHosti.TabIndex = 6;
            this.lblHosti.Text = "Hostilité";
            // 
            // btnRes
            // 
            this.btnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRes.Location = new System.Drawing.Point(13, 679);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(258, 122);
            this.btnRes.TabIndex = 8;
            this.btnRes.Text = "Réinitialiser";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // frmRaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1263, 813);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmRaces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRaces";
            this.Load += new System.EventHandler(this.frmRaces_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chkBoxTriAlpha;
        private System.Windows.Forms.CheckBox chkBoxTriCoul;
        private System.Windows.Forms.ComboBox cboNom;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblHosti;
    }
}