namespace Projet_SAE_24_Stargate
{
    partial class frmPrincipal
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNvMissions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNvMissions
            // 
            this.btnNvMissions.Location = new System.Drawing.Point(22, 134);
            this.btnNvMissions.Name = "btnNvMissions";
            this.btnNvMissions.Size = new System.Drawing.Size(122, 56);
            this.btnNvMissions.TabIndex = 0;
            this.btnNvMissions.Text = "Nouvelle mission";
            this.btnNvMissions.UseVisualStyleBackColor = true;
            this.btnNvMissions.Click += new System.EventHandler(this.btnNvMissions_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 589);
            this.Controls.Add(this.btnNvMissions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNvMissions;
    }
}

