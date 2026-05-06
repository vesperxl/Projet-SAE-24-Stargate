namespace Projet_SAE_24_Stargate
{
    partial class FrmLoginAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpboxAuth = new System.Windows.Forms.GroupBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lbltxttitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grpboxAuth
            // 
            this.grpboxAuth.Location = new System.Drawing.Point(36, 104);
            this.grpboxAuth.Name = "grpboxAuth";
            this.grpboxAuth.Size = new System.Drawing.Size(455, 195);
            this.grpboxAuth.TabIndex = 0;
            this.grpboxAuth.TabStop = false;
            this.grpboxAuth.Text = "Authentification";
            this.grpboxAuth.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Red;
            this.lblTitre.Location = new System.Drawing.Point(149, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(242, 25);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "STARGATE COMMAND";
            // 
            // lbltxttitre
            // 
            this.lbltxttitre.AutoSize = true;
            this.lbltxttitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxttitre.ForeColor = System.Drawing.Color.Red;
            this.lbltxttitre.Location = new System.Drawing.Point(122, 34);
            this.lbltxttitre.Name = "lbltxttitre";
            this.lbltxttitre.Size = new System.Drawing.Size(290, 25);
            this.lbltxttitre.TabIndex = 2;
            this.lbltxttitre.Text = "Accès Restreint Missions SG";
            this.lbltxttitre.Click += new System.EventHandler(this.lbltxttitre_Click);
            // 
            // FrmLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(525, 329);
            this.Controls.Add(this.lbltxttitre);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.grpboxAuth);
            this.Name = "FrmLoginAdmin";
            this.Text = "Authentification Administrateur SGC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxAuth;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lbltxttitre;
    }
}