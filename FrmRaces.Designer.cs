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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(275, 8);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(884, 508);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // chkBoxTriAlpha
            // 
            this.chkBoxTriAlpha.AutoSize = true;
            this.chkBoxTriAlpha.ForeColor = System.Drawing.Color.White;
            this.chkBoxTriAlpha.Location = new System.Drawing.Point(4, 31);
            this.chkBoxTriAlpha.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxTriAlpha.Name = "chkBoxTriAlpha";
            this.chkBoxTriAlpha.Size = new System.Drawing.Size(159, 24);
            this.chkBoxTriAlpha.TabIndex = 1;
            this.chkBoxTriAlpha.Text = "Tri Alphabétique";
            this.chkBoxTriAlpha.UseVisualStyleBackColor = true;
            this.chkBoxTriAlpha.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkBoxTriCoul
            // 
            this.chkBoxTriCoul.AutoSize = true;
            this.chkBoxTriCoul.ForeColor = System.Drawing.Color.White;
            this.chkBoxTriCoul.Location = new System.Drawing.Point(4, 59);
            this.chkBoxTriCoul.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxTriCoul.Name = "chkBoxTriCoul";
            this.chkBoxTriCoul.Size = new System.Drawing.Size(115, 24);
            this.chkBoxTriCoul.TabIndex = 2;
            this.chkBoxTriCoul.Text = "Tri Couleur";
            this.chkBoxTriCoul.UseVisualStyleBackColor = true;
            this.chkBoxTriCoul.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // cboNom
            // 
            this.cboNom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNom.FormattingEnabled = true;
            this.cboNom.Location = new System.Drawing.Point(6, 218);
            this.cboNom.Margin = new System.Windows.Forms.Padding(2);
            this.cboNom.Name = "cboNom";
            this.cboNom.Size = new System.Drawing.Size(246, 32);
            this.cboNom.TabIndex = 3;
            this.cboNom.SelectedIndexChanged += new System.EventHandler(this.cboNom_SelectedIndexChanged);
            // 
            // cboColor
            // 
            this.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(5, 138);
            this.cboColor.Margin = new System.Windows.Forms.Padding(2);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(247, 32);
            this.cboColor.TabIndex = 4;
            this.cboColor.SelectedIndexChanged += new System.EventHandler(this.cboColor_SelectedIndexChanged);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(5, 57);
            this.cboType.Margin = new System.Windows.Forms.Padding(2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(247, 32);
            this.cboType.TabIndex = 5;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBoxTriAlpha);
            this.groupBox1.Controls.Add(this.chkBoxTriCoul);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(258, 91);
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 104);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 284);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtre";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(5, 192);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(54, 24);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "Nom";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(2, 112);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(84, 24);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Couleur";
            // 
            // lblHosti
            // 
            this.lblHosti.AutoSize = true;
            this.lblHosti.Location = new System.Drawing.Point(4, 31);
            this.lblHosti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHosti.Name = "lblHosti";
            this.lblHosti.Size = new System.Drawing.Size(84, 24);
            this.lblHosti.TabIndex = 6;
            this.lblHosti.Text = "Hostilité";
            // 
            // btnRes
            // 
            this.btnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRes.Location = new System.Drawing.Point(137, 393);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(129, 122);
            this.btnRes.TabIndex = 8;
            this.btnRes.Text = "Réinitialiser";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Projet_SAE_24_Stargate.Properties.Resources.homeNeon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmRaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1168, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRaces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste Des Races";
            this.Load += new System.EventHandler(this.frmRaces_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}