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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginAdmin));
            this.grpboxAuth = new System.Windows.Forms.GroupBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtBoxlogin = new System.Windows.Forms.TextBox();
            this.btnVerifier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lbltxttitre = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvidermdp = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpboxAuth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidermdp)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboxAuth
            // 
            this.grpboxAuth.BackColor = System.Drawing.Color.Transparent;
            this.grpboxAuth.Controls.Add(this.btn_annuler);
            this.grpboxAuth.Controls.Add(this.txtMdp);
            this.grpboxAuth.Controls.Add(this.txtBoxlogin);
            this.grpboxAuth.Controls.Add(this.btnVerifier);
            this.grpboxAuth.Controls.Add(this.label2);
            this.grpboxAuth.Controls.Add(this.label1);
            this.grpboxAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxAuth.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpboxAuth.Location = new System.Drawing.Point(12, 155);
            this.grpboxAuth.Name = "grpboxAuth";
            this.grpboxAuth.Size = new System.Drawing.Size(765, 395);
            this.grpboxAuth.TabIndex = 0;
            this.grpboxAuth.TabStop = false;
            this.grpboxAuth.Text = "AUTHENTIFICATION";
            // 
            // btn_annuler
            // 
            this.btn_annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.ForeColor = System.Drawing.Color.Black;
            this.btn_annuler.Location = new System.Drawing.Point(387, 301);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(175, 58);
            this.btn_annuler.TabIndex = 5;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // txtMdp
            // 
            this.txtMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdp.Location = new System.Drawing.Point(265, 209);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(478, 35);
            this.txtMdp.TabIndex = 4;
            this.txtMdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMdp_KeyPress);
            // 
            // txtBoxlogin
            // 
            this.txtBoxlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxlogin.Location = new System.Drawing.Point(265, 94);
            this.txtBoxlogin.Name = "txtBoxlogin";
            this.txtBoxlogin.Size = new System.Drawing.Size(478, 35);
            this.txtBoxlogin.TabIndex = 3;
            this.txtBoxlogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxlogin_KeyPress);
            // 
            // btnVerifier
            // 
            this.btnVerifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifier.ForeColor = System.Drawing.Color.Black;
            this.btnVerifier.Location = new System.Drawing.Point(568, 301);
            this.btnVerifier.Name = "btnVerifier";
            this.btnVerifier.Size = new System.Drawing.Size(175, 58);
            this.btnVerifier.TabIndex = 2;
            this.btnVerifier.Text = "Vérifier";
            this.btnVerifier.UseVisualStyleBackColor = true;
            this.btnVerifier.Click += new System.EventHandler(this.btnVerifier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(17, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(17, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login :";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Red;
            this.lblTitre.Location = new System.Drawing.Point(85, 32);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(534, 38);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "STARGATE COMMAND USAF";
            // 
            // lbltxttitre
            // 
            this.lbltxttitre.AutoSize = true;
            this.lbltxttitre.BackColor = System.Drawing.Color.Transparent;
            this.lbltxttitre.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxttitre.ForeColor = System.Drawing.Color.Red;
            this.lbltxttitre.Location = new System.Drawing.Point(82, 89);
            this.lbltxttitre.Name = "lbltxttitre";
            this.lbltxttitre.Size = new System.Drawing.Size(529, 38);
            this.lbltxttitre.TabIndex = 2;
            this.lbltxttitre.Text = "Accès restreint aux missions SG";
            this.lbltxttitre.Click += new System.EventHandler(this.lbltxttitre_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvidermdp
            // 
            this.errorProvidermdp.ContainerControl = this;
            // 
            // FrmLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Projet_SAE_24_Stargate.Properties.Resources.loginAdmin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 568);
            this.Controls.Add(this.lbltxttitre);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.grpboxAuth);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification Administrateur SGC";
            this.Load += new System.EventHandler(this.FrmLoginAdmin_Load);
            this.grpboxAuth.ResumeLayout(false);
            this.grpboxAuth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidermdp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxAuth;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lbltxttitre;
        private System.Windows.Forms.Button btnVerifier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.TextBox txtBoxlogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvidermdp;
        private System.Windows.Forms.Button btn_annuler;
    }
}