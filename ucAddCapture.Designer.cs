namespace Projet_SAE_24_Stargate
{
    partial class ucAddCapture
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
            this.components = new System.ComponentModel.Container();
            this.cboEspece = new System.Windows.Forms.ComboBox();
            this.numNbEspece = new System.Windows.Forms.NumericUpDown();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numNbEspece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEspece
            // 
            this.cboEspece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspece.FormattingEnabled = true;
            this.cboEspece.Location = new System.Drawing.Point(10, 64);
            this.cboEspece.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cboEspece.Name = "cboEspece";
            this.cboEspece.Size = new System.Drawing.Size(284, 31);
            this.cboEspece.TabIndex = 0;
            // 
            // numNbEspece
            // 
            this.numNbEspece.Location = new System.Drawing.Point(9, 225);
            this.numNbEspece.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.numNbEspece.Name = "numNbEspece";
            this.numNbEspece.Size = new System.Drawing.Size(285, 27);
            this.numNbEspece.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Inter Medium", 13F, System.Drawing.FontStyle.Bold);
            this.lbl1.Location = new System.Drawing.Point(5, 24);
            this.lbl1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(233, 26);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Sélectionnez une espèce";
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Inter Medium", 13F, System.Drawing.FontStyle.Bold);
            this.lbl2.Location = new System.Drawing.Point(5, 168);
            this.lbl2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(233, 62);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Choisir le nombre de capture de l\'espèce";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projet_SAE_24_Stargate.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(295, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Il n\'y a pas d\'objectif de capture pour cette mission");
            this.pictureBox1.Visible = false;
            // 
            // ucAddCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.numNbEspece);
            this.Controls.Add(this.cboEspece);
            this.Controls.Add(this.lbl2);
            this.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ucAddCapture";
            this.Size = new System.Drawing.Size(400, 360);
            this.Load += new System.EventHandler(this.ucAddCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNbEspece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEspece;
        private System.Windows.Forms.NumericUpDown numNbEspece;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
