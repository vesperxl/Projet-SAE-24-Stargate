namespace Projet_SAE_24_Stargate
{
    partial class ucDepenses
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
            this.numSomme = new System.Windows.Forms.NumericUpDown();
            this.cboDepense = new System.Windows.Forms.ComboBox();
            this.lblTypeDepense = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.dateChoice = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSomme)).BeginInit();
            this.SuspendLayout();
            // 
            // numSomme
            // 
            this.numSomme.Location = new System.Drawing.Point(130, 53);
            this.numSomme.Name = "numSomme";
            this.numSomme.Size = new System.Drawing.Size(98, 27);
            this.numSomme.TabIndex = 16;
            // 
            // cboDepense
            // 
            this.cboDepense.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepense.FormattingEnabled = true;
            this.cboDepense.Location = new System.Drawing.Point(130, 310);
            this.cboDepense.Name = "cboDepense";
            this.cboDepense.Size = new System.Drawing.Size(261, 31);
            this.cboDepense.TabIndex = 15;
            // 
            // lblTypeDepense
            // 
            this.lblTypeDepense.Location = new System.Drawing.Point(10, 301);
            this.lblTypeDepense.Name = "lblTypeDepense";
            this.lblTypeDepense.Size = new System.Drawing.Size(97, 60);
            this.lblTypeDepense.TabIndex = 14;
            this.lblTypeDepense.Text = "Type de dépense";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(130, 98);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(261, 185);
            this.txtMotif.TabIndex = 13;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(10, 98);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(49, 23);
            this.lblMotif.TabIndex = 12;
            this.lblMotif.Text = "Motif";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(10, 55);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(81, 23);
            this.lblMontant.TabIndex = 11;
            this.lblMontant.Text = "Montant :";
            // 
            // dateChoice
            // 
            this.dateChoice.Location = new System.Drawing.Point(130, 11);
            this.dateChoice.MinDate = new System.DateTime(2026, 5, 28, 0, 0, 0, 0);
            this.dateChoice.Name = "dateChoice";
            this.dateChoice.Size = new System.Drawing.Size(261, 27);
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
            // ucDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numSomme);
            this.Controls.Add(this.cboDepense);
            this.Controls.Add(this.lblTypeDepense);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.dateChoice);
            this.Controls.Add(this.lblDate);
            this.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ucDepenses";
            this.Size = new System.Drawing.Size(400, 360);
            this.Load += new System.EventHandler(this.ucDepenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSomme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSomme;
        private System.Windows.Forms.ComboBox cboDepense;
        private System.Windows.Forms.Label lblTypeDepense;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.DateTimePicker dateChoice;
        private System.Windows.Forms.Label lblDate;
    }
}
