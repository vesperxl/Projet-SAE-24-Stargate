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
            this.lvlDatabaz = new System.Windows.Forms.Label();
            this.grpBoxAtmo = new System.Windows.Forms.GroupBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.grpBoxInfo.SuspendLayout();
            this.grpBoxPesanteur.SuspendLayout();
            this.grpBoxDataBaz.SuspendLayout();
            this.grpBoxAtmo.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpPlanet
            // 
            this.flpPlanet.Location = new System.Drawing.Point(12, 12);
            this.flpPlanet.Name = "flpPlanet";
            this.flpPlanet.Size = new System.Drawing.Size(354, 620);
            this.flpPlanet.TabIndex = 1;
            // 
            // flpMonstres
            // 
            this.flpMonstres.Location = new System.Drawing.Point(372, 12);
            this.flpMonstres.Name = "flpMonstres";
            this.flpMonstres.Size = new System.Drawing.Size(815, 501);
            this.flpMonstres.TabIndex = 2;
            // 
            // grpBoxInfo
            // 
            this.grpBoxInfo.Controls.Add(this.grpBoxPesanteur);
            this.grpBoxInfo.Controls.Add(this.grpBoxDataBaz);
            this.grpBoxInfo.Controls.Add(this.grpBoxAtmo);
            this.grpBoxInfo.Location = new System.Drawing.Point(373, 519);
            this.grpBoxInfo.Name = "grpBoxInfo";
            this.grpBoxInfo.Size = new System.Drawing.Size(814, 112);
            this.grpBoxInfo.TabIndex = 3;
            this.grpBoxInfo.TabStop = false;
            this.grpBoxInfo.Text = "Informations";
            // 
            // grpBoxPesanteur
            // 
            this.grpBoxPesanteur.Controls.Add(this.lblPes);
            this.grpBoxPesanteur.Location = new System.Drawing.Point(269, 26);
            this.grpBoxPesanteur.Name = "grpBoxPesanteur";
            this.grpBoxPesanteur.Size = new System.Drawing.Size(268, 76);
            this.grpBoxPesanteur.TabIndex = 2;
            this.grpBoxPesanteur.TabStop = false;
            this.grpBoxPesanteur.Text = "Pesanteur";
            // 
            // lblPes
            // 
            this.lblPes.AutoSize = true;
            this.lblPes.Location = new System.Drawing.Point(7, 33);
            this.lblPes.Name = "lblPes";
            this.lblPes.Size = new System.Drawing.Size(0, 20);
            this.lblPes.TabIndex = 0;
            // 
            // grpBoxDataBaz
            // 
            this.grpBoxDataBaz.Controls.Add(this.lvlDatabaz);
            this.grpBoxDataBaz.Location = new System.Drawing.Point(543, 25);
            this.grpBoxDataBaz.Name = "grpBoxDataBaz";
            this.grpBoxDataBaz.Size = new System.Drawing.Size(257, 77);
            this.grpBoxDataBaz.TabIndex = 2;
            this.grpBoxDataBaz.TabStop = false;
            this.grpBoxDataBaz.Text = "Présence De Databaz";
            // 
            // lvlDatabaz
            // 
            this.lvlDatabaz.AutoSize = true;
            this.lvlDatabaz.Location = new System.Drawing.Point(7, 34);
            this.lvlDatabaz.Name = "lvlDatabaz";
            this.lvlDatabaz.Size = new System.Drawing.Size(0, 20);
            this.lvlDatabaz.TabIndex = 0;
            // 
            // grpBoxAtmo
            // 
            this.grpBoxAtmo.Controls.Add(this.lblTemp);
            this.grpBoxAtmo.Location = new System.Drawing.Point(6, 26);
            this.grpBoxAtmo.Name = "grpBoxAtmo";
            this.grpBoxAtmo.Size = new System.Drawing.Size(257, 76);
            this.grpBoxAtmo.TabIndex = 1;
            this.grpBoxAtmo.TabStop = false;
            this.grpBoxAtmo.Text = "Température Atmosphère";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(6, 33);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 20);
            this.lblTemp.TabIndex = 0;
            // 
            // formPlanetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 643);
            this.Controls.Add(this.grpBoxInfo);
            this.Controls.Add(this.flpMonstres);
            this.Controls.Add(this.flpPlanet);
            this.Name = "formPlanetes";
            this.Text = "formPlanetes";
            this.grpBoxInfo.ResumeLayout(false);
            this.grpBoxPesanteur.ResumeLayout(false);
            this.grpBoxPesanteur.PerformLayout();
            this.grpBoxDataBaz.ResumeLayout(false);
            this.grpBoxDataBaz.PerformLayout();
            this.grpBoxAtmo.ResumeLayout(false);
            this.grpBoxAtmo.PerformLayout();
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
    }
}