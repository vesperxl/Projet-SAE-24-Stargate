namespace Projet_SAE_24_Stargate
{
    partial class ucPlanetes
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpPlanet = new System.Windows.Forms.FlowLayoutPanel();
            this.flpMonstres = new System.Windows.Forms.FlowLayoutPanel();
            this.grpBoxInfo = new System.Windows.Forms.GroupBox();
            this.grpBoxAtmo = new System.Windows.Forms.GroupBox();
            this.grpBoxPesanteur = new System.Windows.Forms.GroupBox();
            this.grpBoxDataBaz = new System.Windows.Forms.GroupBox();
            this.grpBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpPlanet
            // 
            this.flpPlanet.Location = new System.Drawing.Point(4, 4);
            this.flpPlanet.Name = "flpPlanet";
            this.flpPlanet.Size = new System.Drawing.Size(354, 763);
            this.flpPlanet.TabIndex = 0;
            // 
            // flpMonstres
            // 
            this.flpMonstres.Location = new System.Drawing.Point(364, 4);
            this.flpMonstres.Name = "flpMonstres";
            this.flpMonstres.Size = new System.Drawing.Size(815, 501);
            this.flpMonstres.TabIndex = 1;
            // 
            // grpBoxInfo
            // 
            this.grpBoxInfo.Controls.Add(this.grpBoxPesanteur);
            this.grpBoxInfo.Controls.Add(this.grpBoxDataBaz);
            this.grpBoxInfo.Controls.Add(this.grpBoxAtmo);
            this.grpBoxInfo.Location = new System.Drawing.Point(365, 512);
            this.grpBoxInfo.Name = "grpBoxInfo";
            this.grpBoxInfo.Size = new System.Drawing.Size(814, 255);
            this.grpBoxInfo.TabIndex = 2;
            this.grpBoxInfo.TabStop = false;
            this.grpBoxInfo.Text = "Informations";
            // 
            // grpBoxAtmo
            // 
            this.grpBoxAtmo.Location = new System.Drawing.Point(6, 26);
            this.grpBoxAtmo.Name = "grpBoxAtmo";
            this.grpBoxAtmo.Size = new System.Drawing.Size(257, 223);
            this.grpBoxAtmo.TabIndex = 1;
            this.grpBoxAtmo.TabStop = false;
            this.grpBoxAtmo.Text = "Température Atmosphère";
            // 
            // grpBoxPesanteur
            // 
            this.grpBoxPesanteur.Location = new System.Drawing.Point(269, 26);
            this.grpBoxPesanteur.Name = "grpBoxPesanteur";
            this.grpBoxPesanteur.Size = new System.Drawing.Size(268, 223);
            this.grpBoxPesanteur.TabIndex = 2;
            this.grpBoxPesanteur.TabStop = false;
            this.grpBoxPesanteur.Text = "Pesanteur";
            // 
            // grpBoxDataBaz
            // 
            this.grpBoxDataBaz.Location = new System.Drawing.Point(543, 25);
            this.grpBoxDataBaz.Name = "grpBoxDataBaz";
            this.grpBoxDataBaz.Size = new System.Drawing.Size(257, 223);
            this.grpBoxDataBaz.TabIndex = 2;
            this.grpBoxDataBaz.TabStop = false;
            this.grpBoxDataBaz.Text = "Présence De Databaz";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBoxInfo);
            this.Controls.Add(this.flpMonstres);
            this.Controls.Add(this.flpPlanet);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1182, 770);
            this.grpBoxInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPlanet;
        private System.Windows.Forms.FlowLayoutPanel flpMonstres;
        private System.Windows.Forms.GroupBox grpBoxInfo;
        private System.Windows.Forms.GroupBox grpBoxAtmo;
        private System.Windows.Forms.GroupBox grpBoxPesanteur;
        private System.Windows.Forms.GroupBox grpBoxDataBaz;
    }
}
