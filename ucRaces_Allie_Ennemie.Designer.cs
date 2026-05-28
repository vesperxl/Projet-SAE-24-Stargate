namespace Projet_SAE_24_Stargate
{
    partial class ucRaces_Allie_Ennemie
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.grpBoxNom = new System.Windows.Forms.GroupBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.grpBoxOrigine = new System.Windows.Forms.GroupBox();
            this.lblOrigine = new System.Windows.Forms.Label();
            this.grpBoxInstruArme = new System.Windows.Forms.GroupBox();
            this.lblInstruArme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.grpBoxNom.SuspendLayout();
            this.grpBoxOrigine.SuspendLayout();
            this.grpBoxInstruArme.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(3, 3);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(303, 287);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // grpBoxNom
            // 
            this.grpBoxNom.Controls.Add(this.lblNom);
            this.grpBoxNom.Location = new System.Drawing.Point(3, 296);
            this.grpBoxNom.Name = "grpBoxNom";
            this.grpBoxNom.Size = new System.Drawing.Size(303, 59);
            this.grpBoxNom.TabIndex = 2;
            this.grpBoxNom.TabStop = false;
            this.grpBoxNom.Text = "Nom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 22);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(0, 20);
            this.lblNom.TabIndex = 0;
            // 
            // grpBoxOrigine
            // 
            this.grpBoxOrigine.Controls.Add(this.lblOrigine);
            this.grpBoxOrigine.Location = new System.Drawing.Point(3, 358);
            this.grpBoxOrigine.Name = "grpBoxOrigine";
            this.grpBoxOrigine.Size = new System.Drawing.Size(303, 59);
            this.grpBoxOrigine.TabIndex = 3;
            this.grpBoxOrigine.TabStop = false;
            this.grpBoxOrigine.Text = "Origine";
            // 
            // lblOrigine
            // 
            this.lblOrigine.AutoSize = true;
            this.lblOrigine.Location = new System.Drawing.Point(7, 22);
            this.lblOrigine.Name = "lblOrigine";
            this.lblOrigine.Size = new System.Drawing.Size(0, 20);
            this.lblOrigine.TabIndex = 0;
            // 
            // grpBoxInstruArme
            // 
            this.grpBoxInstruArme.Controls.Add(this.lblInstruArme);
            this.grpBoxInstruArme.Location = new System.Drawing.Point(3, 423);
            this.grpBoxInstruArme.Name = "grpBoxInstruArme";
            this.grpBoxInstruArme.Size = new System.Drawing.Size(303, 59);
            this.grpBoxInstruArme.TabIndex = 4;
            this.grpBoxInstruArme.TabStop = false;
            this.grpBoxInstruArme.Text = "Instrument";
            // 
            // lblInstruArme
            // 
            this.lblInstruArme.AutoSize = true;
            this.lblInstruArme.Location = new System.Drawing.Point(6, 22);
            this.lblInstruArme.Name = "lblInstruArme";
            this.lblInstruArme.Size = new System.Drawing.Size(0, 20);
            this.lblInstruArme.TabIndex = 0;
            // 
            // ucRaces_Allie_Ennemie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBoxInstruArme);
            this.Controls.Add(this.grpBoxOrigine);
            this.Controls.Add(this.grpBoxNom);
            this.Controls.Add(this.picBox);
            this.Name = "ucRaces_Allie_Ennemie";
            this.Size = new System.Drawing.Size(310, 494);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.grpBoxNom.ResumeLayout(false);
            this.grpBoxNom.PerformLayout();
            this.grpBoxOrigine.ResumeLayout(false);
            this.grpBoxOrigine.PerformLayout();
            this.grpBoxInstruArme.ResumeLayout(false);
            this.grpBoxInstruArme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.GroupBox grpBoxNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.GroupBox grpBoxOrigine;
        private System.Windows.Forms.Label lblOrigine;
        private System.Windows.Forms.GroupBox grpBoxInstruArme;
        private System.Windows.Forms.Label lblInstruArme;
    }
}
