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
            this.lblNom = new System.Windows.Forms.Label();
            this.pctBoxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNom.ForeColor = System.Drawing.Color.Cyan;
            this.lblNom.Location = new System.Drawing.Point(164, 60);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(0, 32);
            this.lblNom.TabIndex = 1;
            // 
            // pctBoxImage
            // 
            this.pctBoxImage.Location = new System.Drawing.Point(4, 4);
            this.pctBoxImage.Name = "pctBoxImage";
            this.pctBoxImage.Size = new System.Drawing.Size(154, 143);
            this.pctBoxImage.TabIndex = 0;
            this.pctBoxImage.TabStop = false;
            // 
            // ucPlanetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pctBoxImage);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ucPlanetes";
            this.Size = new System.Drawing.Size(462, 148);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBoxImage;
        private System.Windows.Forms.Label lblNom;
    }
}
