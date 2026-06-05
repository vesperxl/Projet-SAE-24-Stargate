namespace Projet_SAE_24_Stargate
{
    partial class formPlanetes
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
            this.flpPlanet = new System.Windows.Forms.FlowLayoutPanel();
            this.flpMonstres = new System.Windows.Forms.FlowLayoutPanel();
            this.grpBoxInfo = new System.Windows.Forms.GroupBox();
            this.grpBoxPesanteur = new System.Windows.Forms.GroupBox();
            this.lblPes = new System.Windows.Forms.Label();
            this.grpBoxDataBaz = new System.Windows.Forms.GroupBox();
            this.lblDatabaz = new System.Windows.Forms.Label();
            this.lvlDatabaz = new System.Windows.Forms.Label();
            this.grpBoxAtmo = new System.Windows.Forms.GroupBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpBoxTri = new System.Windows.Forms.GroupBox();
            this.chkTriPes = new System.Windows.Forms.CheckBox();
            this.ChkTriTemp = new System.Windows.Forms.CheckBox();
            this.chkTriAlpha = new System.Windows.Forms.CheckBox();
            this.grpBoxFiltres = new System.Windows.Forms.GroupBox();
            this.lblALiens = new System.Windows.Forms.Label();
            this.cboAliens = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboData = new System.Windows.Forms.ComboBox();
            this.grpBoxInfo.SuspendLayout();
            this.grpBoxPesanteur.SuspendLayout();
            this.grpBoxDataBaz.SuspendLayout();
            this.grpBoxAtmo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoxTri.SuspendLayout();
            this.grpBoxFiltres.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpPlanet
            // 
            this.flpPlanet.AutoScroll = true;
            this.flpPlanet.Location = new System.Drawing.Point(12, 12);
            this.flpPlanet.Name = "flpPlanet";
            this.flpPlanet.Size = new System.Drawing.Size(510, 469);
            this.flpPlanet.TabIndex = 1;
            // 
            // flpMonstres
            // 
            this.flpMonstres.AutoScroll = true;
            this.flpMonstres.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMonstres.Location = new System.Drawing.Point(528, 12);
            this.flpMonstres.Name = "flpMonstres";
            this.flpMonstres.Size = new System.Drawing.Size(858, 794);
            this.flpMonstres.TabIndex = 2;
            // 
            // grpBoxInfo
            // 
            this.grpBoxInfo.Controls.Add(this.grpBoxPesanteur);
            this.grpBoxInfo.Controls.Add(this.grpBoxDataBaz);
            this.grpBoxInfo.Controls.Add(this.grpBoxAtmo);
            this.grpBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grpBoxInfo.Location = new System.Drawing.Point(528, 812);
            this.grpBoxInfo.Name = "grpBoxInfo";
            this.grpBoxInfo.Size = new System.Drawing.Size(858, 148);
            this.grpBoxInfo.TabIndex = 3;
            this.grpBoxInfo.TabStop = false;
            this.grpBoxInfo.Text = "Informations";
            // 
            // grpBoxPesanteur
            // 
            this.grpBoxPesanteur.Controls.Add(this.lblPes);
            this.grpBoxPesanteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxPesanteur.Location = new System.Drawing.Point(308, 25);
            this.grpBoxPesanteur.Name = "grpBoxPesanteur";
            this.grpBoxPesanteur.Size = new System.Drawing.Size(272, 116);
            this.grpBoxPesanteur.TabIndex = 2;
            this.grpBoxPesanteur.TabStop = false;
            this.grpBoxPesanteur.Text = "Pesanteur";
            // 
            // lblPes
            // 
            this.lblPes.AutoSize = true;
            this.lblPes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblPes.Location = new System.Drawing.Point(6, 44);
            this.lblPes.Name = "lblPes";
            this.lblPes.Size = new System.Drawing.Size(0, 26);
            this.lblPes.TabIndex = 0;
            // 
            // grpBoxDataBaz
            // 
            this.grpBoxDataBaz.Controls.Add(this.lblDatabaz);
            this.grpBoxDataBaz.Controls.Add(this.lvlDatabaz);
            this.grpBoxDataBaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDataBaz.Location = new System.Drawing.Point(586, 25);
            this.grpBoxDataBaz.Name = "grpBoxDataBaz";
            this.grpBoxDataBaz.Size = new System.Drawing.Size(266, 117);
            this.grpBoxDataBaz.TabIndex = 2;
            this.grpBoxDataBaz.TabStop = false;
            this.grpBoxDataBaz.Text = "Présence De Databaz";
            // 
            // lblDatabaz
            // 
            this.lblDatabaz.AutoSize = true;
            this.lblDatabaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblDatabaz.Location = new System.Drawing.Point(14, 44);
            this.lblDatabaz.Name = "lblDatabaz";
            this.lblDatabaz.Size = new System.Drawing.Size(0, 26);
            this.lblDatabaz.TabIndex = 1;
            // 
            // lvlDatabaz
            // 
            this.lvlDatabaz.AutoSize = true;
            this.lvlDatabaz.Location = new System.Drawing.Point(8, 34);
            this.lvlDatabaz.Name = "lvlDatabaz";
            this.lvlDatabaz.Size = new System.Drawing.Size(0, 26);
            this.lvlDatabaz.TabIndex = 0;
            // 
            // grpBoxAtmo
            // 
            this.grpBoxAtmo.Controls.Add(this.lblTemp);
            this.grpBoxAtmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAtmo.Location = new System.Drawing.Point(6, 26);
            this.grpBoxAtmo.Name = "grpBoxAtmo";
            this.grpBoxAtmo.Size = new System.Drawing.Size(296, 116);
            this.grpBoxAtmo.TabIndex = 1;
            this.grpBoxAtmo.TabStop = false;
            this.grpBoxAtmo.Text = "Température ";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTemp.Location = new System.Drawing.Point(6, 43);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 26);
            this.lblTemp.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Projet_SAE_24_Stargate.Properties.Resources.homeNeon;
            this.pictureBox1.Location = new System.Drawing.Point(13, 812);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(146, 812);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 149);
            this.button1.TabIndex = 5;
            this.button1.Text = "Réinitialiser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpBoxTri
            // 
            this.grpBoxTri.Controls.Add(this.chkTriPes);
            this.grpBoxTri.Controls.Add(this.ChkTriTemp);
            this.grpBoxTri.Controls.Add(this.chkTriAlpha);
            this.grpBoxTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTri.Location = new System.Drawing.Point(13, 666);
            this.grpBoxTri.Name = "grpBoxTri";
            this.grpBoxTri.Size = new System.Drawing.Size(509, 140);
            this.grpBoxTri.TabIndex = 6;
            this.grpBoxTri.TabStop = false;
            this.grpBoxTri.Text = "Tri";
            // 
            // chkTriPes
            // 
            this.chkTriPes.AutoSize = true;
            this.chkTriPes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTriPes.Location = new System.Drawing.Point(7, 105);
            this.chkTriPes.Name = "chkTriPes";
            this.chkTriPes.Size = new System.Drawing.Size(180, 30);
            this.chkTriPes.TabIndex = 2;
            this.chkTriPes.Text = "Tri Pesanteur";
            this.chkTriPes.UseVisualStyleBackColor = true;
            // 
            // ChkTriTemp
            // 
            this.ChkTriTemp.AutoSize = true;
            this.ChkTriTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkTriTemp.Location = new System.Drawing.Point(7, 66);
            this.ChkTriTemp.Name = "ChkTriTemp";
            this.ChkTriTemp.Size = new System.Drawing.Size(206, 30);
            this.ChkTriTemp.TabIndex = 1;
            this.ChkTriTemp.Text = "Tri Température";
            this.ChkTriTemp.UseVisualStyleBackColor = true;
            // 
            // chkTriAlpha
            // 
            this.chkTriAlpha.AutoSize = true;
            this.chkTriAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTriAlpha.Location = new System.Drawing.Point(7, 26);
            this.chkTriAlpha.Name = "chkTriAlpha";
            this.chkTriAlpha.Size = new System.Drawing.Size(211, 30);
            this.chkTriAlpha.TabIndex = 0;
            this.chkTriAlpha.Text = "Tri Alphabétique";
            this.chkTriAlpha.UseVisualStyleBackColor = true;
            // 
            // grpBoxFiltres
            // 
            this.grpBoxFiltres.Controls.Add(this.lblALiens);
            this.grpBoxFiltres.Controls.Add(this.cboAliens);
            this.grpBoxFiltres.Controls.Add(this.label1);
            this.grpBoxFiltres.Controls.Add(this.cboData);
            this.grpBoxFiltres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxFiltres.Location = new System.Drawing.Point(12, 487);
            this.grpBoxFiltres.Name = "grpBoxFiltres";
            this.grpBoxFiltres.Size = new System.Drawing.Size(509, 179);
            this.grpBoxFiltres.TabIndex = 7;
            this.grpBoxFiltres.TabStop = false;
            this.grpBoxFiltres.Text = "Filtres";
            // 
            // lblALiens
            // 
            this.lblALiens.AutoSize = true;
            this.lblALiens.Location = new System.Drawing.Point(6, 101);
            this.lblALiens.Name = "lblALiens";
            this.lblALiens.Size = new System.Drawing.Size(139, 26);
            this.lblALiens.TabIndex = 3;
            this.lblALiens.Text = "Filtre Aliens";
            // 
            // cboAliens
            // 
            this.cboAliens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAliens.FormattingEnabled = true;
            this.cboAliens.Location = new System.Drawing.Point(6, 130);
            this.cboAliens.Name = "cboAliens";
            this.cboAliens.Size = new System.Drawing.Size(496, 34);
            this.cboAliens.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtre DataBaz";
            // 
            // cboData
            // 
            this.cboData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboData.FormattingEnabled = true;
            this.cboData.Location = new System.Drawing.Point(6, 64);
            this.cboData.Name = "cboData";
            this.cboData.Size = new System.Drawing.Size(496, 34);
            this.cboData.TabIndex = 0;
            // 
            // formPlanetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 973);
            this.Controls.Add(this.grpBoxFiltres);
            this.Controls.Add(this.grpBoxTri);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpBoxInfo);
            this.Controls.Add(this.flpMonstres);
            this.Controls.Add(this.flpPlanet);
            this.Name = "formPlanetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste Des Planètes";
            this.Load += new System.EventHandler(this.formPlanetes_Load);
            this.grpBoxInfo.ResumeLayout(false);
            this.grpBoxPesanteur.ResumeLayout(false);
            this.grpBoxPesanteur.PerformLayout();
            this.grpBoxDataBaz.ResumeLayout(false);
            this.grpBoxDataBaz.PerformLayout();
            this.grpBoxAtmo.ResumeLayout(false);
            this.grpBoxAtmo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoxTri.ResumeLayout(false);
            this.grpBoxTri.PerformLayout();
            this.grpBoxFiltres.ResumeLayout(false);
            this.grpBoxFiltres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPlanet;
        private System.Windows.Forms.FlowLayoutPanel flpMonstres;
        private System.Windows.Forms.GroupBox grpBoxInfo;
        private System.Windows.Forms.GroupBox grpBoxPesanteur;
        private System.Windows.Forms.Label lblPes;
        private System.Windows.Forms.GroupBox grpBoxDataBaz;
        private System.Windows.Forms.Label lvlDatabaz;
        private System.Windows.Forms.GroupBox grpBoxAtmo;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblDatabaz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpBoxTri;
        private System.Windows.Forms.CheckBox chkTriPes;
        private System.Windows.Forms.CheckBox ChkTriTemp;
        private System.Windows.Forms.CheckBox chkTriAlpha;
        private System.Windows.Forms.GroupBox grpBoxFiltres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboData;
        private System.Windows.Forms.Label lblALiens;
        private System.Windows.Forms.ComboBox cboAliens;
    }
}