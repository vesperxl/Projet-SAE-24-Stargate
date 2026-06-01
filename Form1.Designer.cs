namespace Projet_SAE_24_Stargate
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnRaces = new System.Windows.Forms.Button();
            this.btnNvMissions = new System.Windows.Forms.Button();
            this.btnDemarrage = new System.Windows.Forms.Button();
            this.btnbPlanete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // btnRaces
            // 
            this.btnRaces.BackColor = System.Drawing.Color.Red;
            this.btnRaces.Location = new System.Drawing.Point(775, 504);
            this.btnRaces.Name = "btnRaces";
            this.btnRaces.Size = new System.Drawing.Size(193, 73);
            this.btnRaces.TabIndex = 1;
            this.btnRaces.Text = "Races";
            this.btnRaces.UseVisualStyleBackColor = false;
            this.btnRaces.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDemarrage
            // 
            this.btnDemarrage.Location = new System.Drawing.Point(30, 15);
            this.btnDemarrage.Name = "btnDemarrage";
            this.btnDemarrage.Size = new System.Drawing.Size(235, 60);
            this.btnDemarrage.TabIndex = 2;
            this.btnDemarrage.Text = "Demarrage";
            this.btnDemarrage.UseVisualStyleBackColor = true;
            this.btnDemarrage.Click += new System.EventHandler(this.btnDemarrage_Click);
            // 
            // btnbPlanete
            // 
            this.btnbPlanete.Location = new System.Drawing.Point(490, 540);
            this.btnbPlanete.Name = "btnbPlanete";
            this.btnbPlanete.Size = new System.Drawing.Size(75, 23);
            this.btnbPlanete.TabIndex = 3;
            this.btnbPlanete.UseVisualStyleBackColor = true;
            this.btnbPlanete.Click += new System.EventHandler(this.btnbPlanete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(816, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 73);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 589);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnbPlanete);
            this.Controls.Add(this.btnDemarrage);
            this.Controls.Add(this.btnRaces);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNvMissions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRaces;
        private System.Windows.Forms.Button btnNvMissions;
        private System.Windows.Forms.Button btnDemarrage;
        private System.Windows.Forms.Button btnbPlanete;
        private System.Windows.Forms.Button button2;
    }
}

