namespace Projet_SAE_24_Stargate
{
    partial class ucCarteIdentité
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
            this.panelBack = new System.Windows.Forms.Panel();
            this.lblStatu = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.pictureCi = new System.Windows.Forms.PictureBox();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.SystemColors.Control;
            this.panelBack.Controls.Add(this.lblStatu);
            this.panelBack.Controls.Add(this.lblNom);
            this.panelBack.Controls.Add(this.lblPrenom);
            this.panelBack.Controls.Add(this.pictureCi);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Enabled = false;
            this.panelBack.Location = new System.Drawing.Point(4, 4);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(106, 140);
            this.panelBack.TabIndex = 4;
            // 
            // lblStatu
            // 
            this.lblStatu.BackColor = System.Drawing.Color.Transparent;
            this.lblStatu.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatu.Location = new System.Drawing.Point(3, 4);
            this.lblStatu.Name = "lblStatu";
            this.lblStatu.Size = new System.Drawing.Size(100, 23);
            this.lblStatu.TabIndex = 4;
            this.lblStatu.Text = "Membre";
            this.lblStatu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Inter Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(3, 115);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(100, 22);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrenom
            // 
            this.lblPrenom.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenom.Font = new System.Drawing.Font("Inter Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(3, 98);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(100, 22);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom";
            this.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureCi
            // 
            this.pictureCi.Location = new System.Drawing.Point(17, 27);
            this.pictureCi.Margin = new System.Windows.Forms.Padding(4);
            this.pictureCi.Name = "pictureCi";
            this.pictureCi.Size = new System.Drawing.Size(70, 70);
            this.pictureCi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCi.TabIndex = 0;
            this.pictureCi.TabStop = false;
            // 
            // ucCarteIdentité
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelBack);
            this.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucCarteIdentité";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(114, 148);
            this.panelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCi;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Label lblStatu;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
    }
}
