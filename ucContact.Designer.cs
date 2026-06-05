namespace Projet_SAE_24_Stargate
{
    partial class ucContact
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
            this.lblDate = new System.Windows.Forms.Label();
            this.dateChoice = new System.Windows.Forms.DateTimePicker();
            this.lblSomme = new System.Windows.Forms.Label();
            this.lblAppreciation = new System.Windows.Forms.Label();
            this.txtAppreciation = new System.Windows.Forms.TextBox();
            this.lblInformateur = new System.Windows.Forms.Label();
            this.cboInformateur = new System.Windows.Forms.ComboBox();
            this.numSomme = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSomme)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 23);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // dateChoice
            // 
            this.dateChoice.Location = new System.Drawing.Point(130, 11);
            this.dateChoice.MaxDate = new System.DateTime(2026, 6, 3, 0, 0, 0, 0);
            this.dateChoice.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateChoice.Name = "dateChoice";
            this.dateChoice.Size = new System.Drawing.Size(261, 27);
            this.dateChoice.TabIndex = 1;
            this.dateChoice.Value = new System.DateTime(2026, 6, 3, 0, 0, 0, 0);
            // 
            // lblSomme
            // 
            this.lblSomme.AutoSize = true;
            this.lblSomme.Location = new System.Drawing.Point(10, 55);
            this.lblSomme.Name = "lblSomme";
            this.lblSomme.Size = new System.Drawing.Size(67, 23);
            this.lblSomme.TabIndex = 2;
            this.lblSomme.Text = "Somme";
            // 
            // lblAppreciation
            // 
            this.lblAppreciation.AutoSize = true;
            this.lblAppreciation.Location = new System.Drawing.Point(10, 98);
            this.lblAppreciation.Name = "lblAppreciation";
            this.lblAppreciation.Size = new System.Drawing.Size(106, 23);
            this.lblAppreciation.TabIndex = 4;
            this.lblAppreciation.Text = "Appréciation";
            // 
            // txtAppreciation
            // 
            this.txtAppreciation.Location = new System.Drawing.Point(130, 98);
            this.txtAppreciation.Multiline = true;
            this.txtAppreciation.Name = "txtAppreciation";
            this.txtAppreciation.Size = new System.Drawing.Size(261, 185);
            this.txtAppreciation.TabIndex = 5;
            // 
            // lblInformateur
            // 
            this.lblInformateur.AutoSize = true;
            this.lblInformateur.Location = new System.Drawing.Point(10, 313);
            this.lblInformateur.Name = "lblInformateur";
            this.lblInformateur.Size = new System.Drawing.Size(97, 23);
            this.lblInformateur.TabIndex = 6;
            this.lblInformateur.Text = "Informateur";
            // 
            // cboInformateur
            // 
            this.cboInformateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInformateur.FormattingEnabled = true;
            this.cboInformateur.Location = new System.Drawing.Point(130, 310);
            this.cboInformateur.Name = "cboInformateur";
            this.cboInformateur.Size = new System.Drawing.Size(261, 31);
            this.cboInformateur.TabIndex = 7;
            // 
            // numSomme
            // 
            this.numSomme.Location = new System.Drawing.Point(130, 53);
            this.numSomme.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numSomme.Name = "numSomme";
            this.numSomme.Size = new System.Drawing.Size(98, 27);
            this.numSomme.TabIndex = 8;
            // 
            // ucContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numSomme);
            this.Controls.Add(this.cboInformateur);
            this.Controls.Add(this.lblInformateur);
            this.Controls.Add(this.txtAppreciation);
            this.Controls.Add(this.lblAppreciation);
            this.Controls.Add(this.lblSomme);
            this.Controls.Add(this.dateChoice);
            this.Controls.Add(this.lblDate);
            this.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ucContact";
            this.Size = new System.Drawing.Size(400, 360);
            this.Load += new System.EventHandler(this.ucContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSomme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateChoice;
        private System.Windows.Forms.Label lblSomme;
        private System.Windows.Forms.Label lblAppreciation;
        private System.Windows.Forms.TextBox txtAppreciation;
        private System.Windows.Forms.Label lblInformateur;
        private System.Windows.Forms.ComboBox cboInformateur;
        private System.Windows.Forms.NumericUpDown numSomme;
    }
}
