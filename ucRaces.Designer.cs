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
            this.grpBoxInsArm = new System.Windows.Forms.GroupBox();
            this.lblInsArm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.grpBoxNom.SuspendLayout();
            this.grpBoxOrigine.SuspendLayout();
            this.grpBoxInsArm.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(16, 11);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(383, 347);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // grpBoxNom
            // 
            this.grpBoxNom.Controls.Add(this.lblNom);
            this.grpBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxNom.Location = new System.Drawing.Point(16, 364);
            this.grpBoxNom.Name = "grpBoxNom";
            this.grpBoxNom.Size = new System.Drawing.Size(384, 94);
            this.grpBoxNom.TabIndex = 1;
            this.grpBoxNom.TabStop = false;
            this.grpBoxNom.Text = "Nom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(7, 39);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(0, 32);
            this.lblNom.TabIndex = 0;
            // 
            // grpBoxOrigine
            // 
            this.grpBoxOrigine.Controls.Add(this.lblOrigine);
            this.grpBoxOrigine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxOrigine.Location = new System.Drawing.Point(16, 464);
            this.grpBoxOrigine.Name = "grpBoxOrigine";
            this.grpBoxOrigine.Size = new System.Drawing.Size(383, 94);
            this.grpBoxOrigine.TabIndex = 2;
            this.grpBoxOrigine.TabStop = false;
            this.grpBoxOrigine.Text = "Origine";
            // 
            // lblOrigine
            // 
            this.lblOrigine.AutoSize = true;
            this.lblOrigine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigine.Location = new System.Drawing.Point(6, 40);
            this.lblOrigine.Name = "lblOrigine";
            this.lblOrigine.Size = new System.Drawing.Size(0, 32);
            this.lblOrigine.TabIndex = 1;
            // 
            // grpBoxInsArm
            // 
            this.grpBoxInsArm.Controls.Add(this.lblInsArm);
            this.grpBoxInsArm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxInsArm.Location = new System.Drawing.Point(16, 564);
            this.grpBoxInsArm.Name = "grpBoxInsArm";
            this.grpBoxInsArm.Size = new System.Drawing.Size(383, 94);
            this.grpBoxInsArm.TabIndex = 3;
            this.grpBoxInsArm.TabStop = false;
            this.grpBoxInsArm.Text = "Text";
            // 
            // lblInsArm
            // 
            this.lblInsArm.AutoSize = true;
            this.lblInsArm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsArm.Location = new System.Drawing.Point(6, 40);
            this.lblInsArm.Name = "lblInsArm";
            this.lblInsArm.Size = new System.Drawing.Size(0, 32);
            this.lblInsArm.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 665);
            this.panel1.TabIndex = 0;
            // 
            // ucRaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.grpBoxInsArm);
            this.Controls.Add(this.grpBoxOrigine);
            this.Controls.Add(this.grpBoxNom);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.panel1);
            this.Name = "ucRaces";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(415, 673);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.grpBoxNom.ResumeLayout(false);
            this.grpBoxNom.PerformLayout();
            this.grpBoxOrigine.ResumeLayout(false);
            this.grpBoxOrigine.PerformLayout();
            this.grpBoxInsArm.ResumeLayout(false);
            this.grpBoxInsArm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.GroupBox grpBoxNom;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpBoxOrigine;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.GroupBox grpBoxInsArm;
        private System.Windows.Forms.Label lblOrigine;
        private System.Windows.Forms.Label lblInsArm;
        private System.Windows.Forms.Panel panel1;
    }
}
