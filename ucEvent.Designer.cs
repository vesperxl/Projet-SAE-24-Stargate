namespace Projet_SAE_24_Stargate
{
    partial class ucEvent
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
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.dateChoice = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(14, 96);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(371, 253);
            this.txtCommentaire.TabIndex = 13;
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(126, 66);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(111, 23);
            this.lblCommentaire.TabIndex = 12;
            this.lblCommentaire.Text = "Commentaire";
            // 
            // dateChoice
            // 
            this.dateChoice.Location = new System.Drawing.Point(61, 11);
            this.dateChoice.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateChoice.Name = "dateChoice";
            this.dateChoice.Size = new System.Drawing.Size(330, 27);
            this.dateChoice.TabIndex = 10;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 23);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date";
            // 
            // ucEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.dateChoice);
            this.Controls.Add(this.lblDate);
            this.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ucEvent";
            this.Size = new System.Drawing.Size(400, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.DateTimePicker dateChoice;
        private System.Windows.Forms.Label lblDate;
    }
}
