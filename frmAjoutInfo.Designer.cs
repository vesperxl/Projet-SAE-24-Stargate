namespace Projet_SAE_24_Stargate
{
    partial class frmAjoutInfo
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
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblContact = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblevent = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureDepense = new System.Windows.Forms.PictureBox();
            this.pictureEvent = new System.Windows.Forms.PictureBox();
            this.pictureContact = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDepense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContact)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(253, 519);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(168, 64);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(12, 519);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(168, 64);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblContact
            // 
            this.lblContact.Font = new System.Drawing.Font("Inter", 10F);
            this.lblContact.Location = new System.Drawing.Point(12, 75);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(82, 47);
            this.lblContact.TabIndex = 5;
            this.lblContact.Text = "Nouveau contact";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Inter", 10F);
            this.label1.Location = new System.Drawing.Point(109, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nouvelle dépense";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblevent
            // 
            this.lblevent.Font = new System.Drawing.Font("Inter", 10F);
            this.lblevent.Location = new System.Drawing.Point(211, 74);
            this.lblevent.Name = "lblevent";
            this.lblevent.Size = new System.Drawing.Size(99, 51);
            this.lblevent.TabIndex = 7;
            this.lblevent.Text = "Nouvel évenement";
            this.lblevent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInfo
            // 
            this.grpInfo.Location = new System.Drawing.Point(12, 120);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(409, 393);
            this.grpInfo.TabIndex = 8;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "groupBox1";
            this.grpInfo.Enter += new System.EventHandler(this.grpInfo_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Projet_SAE_24_Stargate.Properties.Resources.alien;
            this.pictureBox1.Location = new System.Drawing.Point(339, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureDepense
            // 
            this.pictureDepense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureDepense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureDepense.Image = global::Projet_SAE_24_Stargate.Properties.Resources.depense;
            this.pictureDepense.Location = new System.Drawing.Point(120, 4);
            this.pictureDepense.Name = "pictureDepense";
            this.pictureDepense.Size = new System.Drawing.Size(70, 70);
            this.pictureDepense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDepense.TabIndex = 4;
            this.pictureDepense.TabStop = false;
            this.pictureDepense.Click += new System.EventHandler(this.pictureDepense_Click);
            // 
            // pictureEvent
            // 
            this.pictureEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureEvent.Image = global::Projet_SAE_24_Stargate.Properties.Resources.evenement;
            this.pictureEvent.Location = new System.Drawing.Point(227, 4);
            this.pictureEvent.Name = "pictureEvent";
            this.pictureEvent.Size = new System.Drawing.Size(70, 70);
            this.pictureEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureEvent.TabIndex = 3;
            this.pictureEvent.TabStop = false;
            this.pictureEvent.Click += new System.EventHandler(this.pictureEvent_Click);
            // 
            // pictureContact
            // 
            this.pictureContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureContact.Image = global::Projet_SAE_24_Stargate.Properties.Resources.contact;
            this.pictureContact.Location = new System.Drawing.Point(16, 4);
            this.pictureContact.Name = "pictureContact";
            this.pictureContact.Size = new System.Drawing.Size(70, 70);
            this.pictureContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureContact.TabIndex = 2;
            this.pictureContact.TabStop = false;
            this.pictureContact.Click += new System.EventHandler(this.pictureContact_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Inter", 10F);
            this.label2.Location = new System.Drawing.Point(322, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 51);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nouvelle capture";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAjoutInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 595);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.lblevent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.pictureDepense);
            this.Controls.Add(this.pictureEvent);
            this.Controls.Add(this.pictureContact);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAjoutInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter une information";
            this.Load += new System.EventHandler(this.frmAjoutInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDepense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.PictureBox pictureContact;
        private System.Windows.Forms.PictureBox pictureEvent;
        private System.Windows.Forms.PictureBox pictureDepense;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblevent;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}