namespace Projet_SAE_24_Stargate
{
    partial class FormAffectationCapture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAffectationCapture));
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblAffectation = new System.Windows.Forms.Label();
            this.lblResteAffect = new System.Windows.Forms.Label();
            this.cboMembre = new System.Windows.Forms.ComboBox();
            this.btnAjouterMembre = new System.Windows.Forms.Button();
            this.lstBoxMembre = new System.Windows.Forms.ListBox();
            this.btnValiderMembre = new System.Windows.Forms.Button();
            this.btnValiderCapture = new System.Windows.Forms.Button();
            this.lstBoxObjectifs = new System.Windows.Forms.ListBox();
            this.btnAjouterObjectif = new System.Windows.Forms.Button();
            this.cboEspeceCapture = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudObjectifCapture = new System.Windows.Forms.NumericUpDown();
            this.lblrestreq = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudObjectifCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Red;
            this.lblTitre.Location = new System.Drawing.Point(169, 31);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(534, 38);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "STARGATE COMMAND USAF";
            // 
            // lblAffectation
            // 
            this.lblAffectation.AutoSize = true;
            this.lblAffectation.BackColor = System.Drawing.Color.Transparent;
            this.lblAffectation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffectation.ForeColor = System.Drawing.Color.White;
            this.lblAffectation.Location = new System.Drawing.Point(22, 106);
            this.lblAffectation.Name = "lblAffectation";
            this.lblAffectation.Size = new System.Drawing.Size(488, 24);
            this.lblAffectation.TabIndex = 2;
            this.lblAffectation.Text = "4 - Choix des affectations des membres de l\'équipe";
            // 
            // lblResteAffect
            // 
            this.lblResteAffect.AutoSize = true;
            this.lblResteAffect.BackColor = System.Drawing.Color.Transparent;
            this.lblResteAffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResteAffect.ForeColor = System.Drawing.Color.White;
            this.lblResteAffect.Location = new System.Drawing.Point(51, 154);
            this.lblResteAffect.Name = "lblResteAffect";
            this.lblResteAffect.Size = new System.Drawing.Size(295, 24);
            this.lblResteAffect.TabIndex = 3;
            this.lblResteAffect.Text = "Restant disponibles à affecter :";
            // 
            // cboMembre
            // 
            this.cboMembre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMembre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMembre.FormattingEnabled = true;
            this.cboMembre.Location = new System.Drawing.Point(55, 200);
            this.cboMembre.Name = "cboMembre";
            this.cboMembre.Size = new System.Drawing.Size(582, 32);
            this.cboMembre.TabIndex = 4;
            // 
            // btnAjouterMembre
            // 
            this.btnAjouterMembre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterMembre.Location = new System.Drawing.Point(687, 200);
            this.btnAjouterMembre.Name = "btnAjouterMembre";
            this.btnAjouterMembre.Size = new System.Drawing.Size(142, 32);
            this.btnAjouterMembre.TabIndex = 5;
            this.btnAjouterMembre.Text = "Ajouter";
            this.btnAjouterMembre.UseVisualStyleBackColor = true;
            this.btnAjouterMembre.Click += new System.EventHandler(this.btnAjouterMembre_Click);
            // 
            // lstBoxMembre
            // 
            this.lstBoxMembre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxMembre.FormattingEnabled = true;
            this.lstBoxMembre.ItemHeight = 24;
            this.lstBoxMembre.Location = new System.Drawing.Point(55, 266);
            this.lstBoxMembre.Name = "lstBoxMembre";
            this.lstBoxMembre.Size = new System.Drawing.Size(774, 244);
            this.lstBoxMembre.TabIndex = 6;
            // 
            // btnValiderMembre
            // 
            this.btnValiderMembre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderMembre.Location = new System.Drawing.Point(638, 549);
            this.btnValiderMembre.Name = "btnValiderMembre";
            this.btnValiderMembre.Size = new System.Drawing.Size(191, 32);
            this.btnValiderMembre.TabIndex = 7;
            this.btnValiderMembre.Text = "Valider membres";
            this.btnValiderMembre.UseVisualStyleBackColor = true;
            this.btnValiderMembre.Click += new System.EventHandler(this.btnValiderMembre_Click);
            // 
            // btnValiderCapture
            // 
            this.btnValiderCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderCapture.Location = new System.Drawing.Point(638, 993);
            this.btnValiderCapture.Name = "btnValiderCapture";
            this.btnValiderCapture.Size = new System.Drawing.Size(191, 32);
            this.btnValiderCapture.TabIndex = 13;
            this.btnValiderCapture.Text = "Valider objectifs";
            this.btnValiderCapture.UseVisualStyleBackColor = true;
            this.btnValiderCapture.Click += new System.EventHandler(this.btnValiderCapture_Click);
            // 
            // lstBoxObjectifs
            // 
            this.lstBoxObjectifs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxObjectifs.FormattingEnabled = true;
            this.lstBoxObjectifs.ItemHeight = 24;
            this.lstBoxObjectifs.Location = new System.Drawing.Point(55, 714);
            this.lstBoxObjectifs.Name = "lstBoxObjectifs";
            this.lstBoxObjectifs.Size = new System.Drawing.Size(774, 244);
            this.lstBoxObjectifs.TabIndex = 12;
            // 
            // btnAjouterObjectif
            // 
            this.btnAjouterObjectif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterObjectif.Location = new System.Drawing.Point(687, 648);
            this.btnAjouterObjectif.Name = "btnAjouterObjectif";
            this.btnAjouterObjectif.Size = new System.Drawing.Size(142, 32);
            this.btnAjouterObjectif.TabIndex = 11;
            this.btnAjouterObjectif.Text = "Ajouter";
            this.btnAjouterObjectif.UseVisualStyleBackColor = true;
            this.btnAjouterObjectif.Click += new System.EventHandler(this.btnAjouterObjectif_Click);
            // 
            // cboEspeceCapture
            // 
            this.cboEspeceCapture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspeceCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEspeceCapture.FormattingEnabled = true;
            this.cboEspeceCapture.Location = new System.Drawing.Point(55, 648);
            this.cboEspeceCapture.Name = "cboEspeceCapture";
            this.cboEspeceCapture.Size = new System.Drawing.Size(396, 32);
            this.cboEspeceCapture.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "5 - Objectifs de captures ";
            // 
            // nudObjectifCapture
            // 
            this.nudObjectifCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudObjectifCapture.Location = new System.Drawing.Point(517, 648);
            this.nudObjectifCapture.Name = "nudObjectifCapture";
            this.nudObjectifCapture.Size = new System.Drawing.Size(120, 31);
            this.nudObjectifCapture.TabIndex = 14;
            // 
            // lblrestreq
            // 
            this.lblrestreq.AutoSize = true;
            this.lblrestreq.BackColor = System.Drawing.Color.Transparent;
            this.lblrestreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrestreq.ForeColor = System.Drawing.Color.White;
            this.lblrestreq.Location = new System.Drawing.Point(362, 154);
            this.lblrestreq.Name = "lblrestreq";
            this.lblrestreq.Size = new System.Drawing.Size(0, 24);
            this.lblrestreq.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // FormAffectationCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Projet_SAE_24_Stargate.Properties.Resources.fondMission;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(891, 1045);
            this.Controls.Add(this.lblrestreq);
            this.Controls.Add(this.nudObjectifCapture);
            this.Controls.Add(this.btnValiderCapture);
            this.Controls.Add(this.lstBoxObjectifs);
            this.Controls.Add(this.btnAjouterObjectif);
            this.Controls.Add(this.cboEspeceCapture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnValiderMembre);
            this.Controls.Add(this.lstBoxMembre);
            this.Controls.Add(this.btnAjouterMembre);
            this.Controls.Add(this.cboMembre);
            this.Controls.Add(this.lblResteAffect);
            this.Controls.Add(this.lblAffectation);
            this.Controls.Add(this.lblTitre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAffectationCapture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire des nouvelles missions SGC";
            this.Load += new System.EventHandler(this.FormAffectationCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudObjectifCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblAffectation;
        private System.Windows.Forms.Label lblResteAffect;
        private System.Windows.Forms.ComboBox cboMembre;
        private System.Windows.Forms.Button btnAjouterMembre;
        private System.Windows.Forms.ListBox lstBoxMembre;
        private System.Windows.Forms.Button btnValiderMembre;
        private System.Windows.Forms.Button btnValiderCapture;
        private System.Windows.Forms.ListBox lstBoxObjectifs;
        private System.Windows.Forms.Button btnAjouterObjectif;
        private System.Windows.Forms.ComboBox cboEspeceCapture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudObjectifCapture;
        private System.Windows.Forms.Label lblrestreq;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}