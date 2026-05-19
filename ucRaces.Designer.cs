namespace Projet_SAE_24_Stargate
{
    partial class ucRaces
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpBoxOrigine = new System.Windows.Forms.GroupBox();
            this.lblOrigine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.grpBoxNom.SuspendLayout();
            this.grpBoxOrigine.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(4, 4);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(303, 287);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // grpBoxNom
            // 
            this.grpBoxNom.Controls.Add(this.lblNom);
            this.grpBoxNom.Location = new System.Drawing.Point(4, 298);
            this.grpBoxNom.Name = "grpBoxNom";
            this.grpBoxNom.Size = new System.Drawing.Size(303, 94);
            this.grpBoxNom.TabIndex = 1;
            this.grpBoxNom.TabStop = false;
            this.grpBoxNom.Text = "Nom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(7, 39);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(0, 20);
            this.lblNom.TabIndex = 0;
            // 
            // grpBoxOrigine
            // 
            this.grpBoxOrigine.Controls.Add(this.lblOrigine);
            this.grpBoxOrigine.Location = new System.Drawing.Point(4, 398);
            this.grpBoxOrigine.Name = "grpBoxOrigine";
            this.grpBoxOrigine.Size = new System.Drawing.Size(303, 94);
            this.grpBoxOrigine.TabIndex = 2;
            this.grpBoxOrigine.TabStop = false;
            this.grpBoxOrigine.Text = "Origine";
            // 
            // lblOrigine
            // 
            this.lblOrigine.AutoSize = true;
            this.lblOrigine.Location = new System.Drawing.Point(7, 45);
            this.lblOrigine.Name = "lblOrigine";
            this.lblOrigine.Size = new System.Drawing.Size(0, 20);
            this.lblOrigine.TabIndex = 1;
            // 
            // ucRaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.grpBoxOrigine);
            this.Controls.Add(this.grpBoxNom);
            this.Controls.Add(this.picBox);
            this.Name = "ucRaces";
            this.Size = new System.Drawing.Size(308, 500);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.grpBoxNom.ResumeLayout(false);
            this.grpBoxNom.PerformLayout();
            this.grpBoxOrigine.ResumeLayout(false);
            this.grpBoxOrigine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.GroupBox grpBoxNom;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpBoxOrigine;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblOrigine;
    }
}
