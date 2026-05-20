namespace Projet_SAE_24_Stargate
{
    partial class frmDetailMission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailMission));
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabDetailMission = new System.Windows.Forms.TabPage();
            this.grpMembre = new System.Windows.Forms.GroupBox();
            this.flpMembre = new System.Windows.Forms.FlowLayoutPanel();
            this.grpRoute = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblSoldeApresDepense = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblbu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDateDeFin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpDateDepart = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDateDépart = new System.Windows.Forms.Label();
            this.lblDD = new System.Windows.Forms.Label();
            this.lblNomMission = new System.Windows.Forms.Label();
            this.picturePlanete = new System.Windows.Forms.PictureBox();
            this.tabJournalMission = new System.Windows.Forms.TabPage();
            this.grpCapture = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabGeneral.SuspendLayout();
            this.tabDetailMission.SuspendLayout();
            this.grpMembre.SuspendLayout();
            this.flpMembre.SuspendLayout();
            this.grpRoute.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpDateDepart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlanete)).BeginInit();
            this.grpCapture.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabDetailMission);
            this.tabGeneral.Controls.Add(this.tabJournalMission);
            this.tabGeneral.Location = new System.Drawing.Point(13, 9);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(1121, 586);
            this.tabGeneral.TabIndex = 0;
            // 
            // tabDetailMission
            // 
            this.tabDetailMission.Controls.Add(this.grpCapture);
            this.tabDetailMission.Controls.Add(this.grpMembre);
            this.tabDetailMission.Controls.Add(this.grpRoute);
            this.tabDetailMission.Controls.Add(this.groupBox3);
            this.tabDetailMission.Controls.Add(this.groupBox2);
            this.tabDetailMission.Controls.Add(this.groupBox1);
            this.tabDetailMission.Controls.Add(this.grpDateDepart);
            this.tabDetailMission.Controls.Add(this.lblNomMission);
            this.tabDetailMission.Controls.Add(this.picturePlanete);
            this.tabDetailMission.Location = new System.Drawing.Point(4, 32);
            this.tabDetailMission.Name = "tabDetailMission";
            this.tabDetailMission.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetailMission.Size = new System.Drawing.Size(1113, 550);
            this.tabDetailMission.TabIndex = 0;
            this.tabDetailMission.Text = "Détails de la mission";
            this.tabDetailMission.UseVisualStyleBackColor = true;
            // 
            // grpMembre
            // 
            this.grpMembre.Controls.Add(this.flpMembre);
            this.grpMembre.Location = new System.Drawing.Point(16, 333);
            this.grpMembre.Name = "grpMembre";
            this.grpMembre.Size = new System.Drawing.Size(651, 202);
            this.grpMembre.TabIndex = 9;
            this.grpMembre.TabStop = false;
            this.grpMembre.Text = "Membre (5 requis)";
            // 
            // flpMembre
            // 
            this.flpMembre.AutoScroll = true;
            this.flpMembre.Controls.Add(this.flowLayoutPanel2);
            this.flpMembre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMembre.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMembre.Location = new System.Drawing.Point(3, 23);
            this.flpMembre.Name = "flpMembre";
            this.flpMembre.Padding = new System.Windows.Forms.Padding(10);
            this.flpMembre.Size = new System.Drawing.Size(645, 176);
            this.flpMembre.TabIndex = 0;
            // 
            // grpRoute
            // 
            this.grpRoute.Controls.Add(this.richTextBox1);
            this.grpRoute.Location = new System.Drawing.Point(691, 203);
            this.grpRoute.Name = "grpRoute";
            this.grpRoute.Size = new System.Drawing.Size(411, 341);
            this.grpRoute.TabIndex = 7;
            this.grpRoute.TabStop = false;
            this.grpRoute.Text = "Feuille de route";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox1.Location = new System.Drawing.Point(13, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(389, 300);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.lblSoldeApresDepense);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(893, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 61);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // lblSoldeApresDepense
            // 
            this.lblSoldeApresDepense.AutoSize = true;
            this.lblSoldeApresDepense.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldeApresDepense.Location = new System.Drawing.Point(80, 35);
            this.lblSoldeApresDepense.Name = "lblSoldeApresDepense";
            this.lblSoldeApresDepense.Size = new System.Drawing.Size(58, 23);
            this.lblSoldeApresDepense.TabIndex = 1;
            this.lblSoldeApresDepense.Text = "1000€";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(46, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Solde après dépenses";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.lblBudget);
            this.groupBox2.Controls.Add(this.lblbu);
            this.groupBox2.Location = new System.Drawing.Point(685, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 61);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(62, 35);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(58, 23);
            this.lblBudget.TabIndex = 1;
            this.lblBudget.Text = "1000€";
            // 
            // lblbu
            // 
            this.lblbu.AutoSize = true;
            this.lblbu.Font = new System.Drawing.Font("Inter", 10F);
            this.lblbu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblbu.Location = new System.Drawing.Point(62, 13);
            this.lblbu.Name = "lblbu";
            this.lblbu.Size = new System.Drawing.Size(58, 21);
            this.lblbu.TabIndex = 0;
            this.lblbu.Text = "Budget";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblDateDeFin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(893, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblDateDeFin
            // 
            this.lblDateDeFin.AutoSize = true;
            this.lblDateDeFin.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDeFin.Location = new System.Drawing.Point(66, 35);
            this.lblDateDeFin.Name = "lblDateDeFin";
            this.lblDateDeFin.Size = new System.Drawing.Size(98, 23);
            this.lblDateDeFin.TabIndex = 1;
            this.lblDateDeFin.Text = "2026-01-01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(62, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date de retour";
            // 
            // grpDateDepart
            // 
            this.grpDateDepart.Controls.Add(this.pictureBox1);
            this.grpDateDepart.Controls.Add(this.lblDateDépart);
            this.grpDateDepart.Controls.Add(this.lblDD);
            this.grpDateDepart.Location = new System.Drawing.Point(685, 19);
            this.grpDateDepart.Name = "grpDateDepart";
            this.grpDateDepart.Size = new System.Drawing.Size(183, 61);
            this.grpDateDepart.TabIndex = 2;
            this.grpDateDepart.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblDateDépart
            // 
            this.lblDateDépart.AutoSize = true;
            this.lblDateDépart.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDépart.Location = new System.Drawing.Point(66, 35);
            this.lblDateDépart.Name = "lblDateDépart";
            this.lblDateDépart.Size = new System.Drawing.Size(98, 23);
            this.lblDateDépart.TabIndex = 1;
            this.lblDateDépart.Text = "2026-01-01";
            // 
            // lblDD
            // 
            this.lblDD.AutoSize = true;
            this.lblDD.Font = new System.Drawing.Font("Inter", 10F);
            this.lblDD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDD.Location = new System.Drawing.Point(62, 13);
            this.lblDD.Name = "lblDD";
            this.lblDD.Size = new System.Drawing.Size(110, 21);
            this.lblDD.TabIndex = 0;
            this.lblDD.Text = "Date de départ";
            // 
            // lblNomMission
            // 
            this.lblNomMission.AutoSize = true;
            this.lblNomMission.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomMission.Location = new System.Drawing.Point(14, 161);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(234, 30);
            this.lblNomMission.TabIndex = 1;
            this.lblNomMission.Text = "Mission Nom mission";
            // 
            // picturePlanete
            // 
            this.picturePlanete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePlanete.Location = new System.Drawing.Point(16, 15);
            this.picturePlanete.Name = "picturePlanete";
            this.picturePlanete.Size = new System.Drawing.Size(130, 130);
            this.picturePlanete.TabIndex = 0;
            this.picturePlanete.TabStop = false;
            // 
            // tabJournalMission
            // 
            this.tabJournalMission.Location = new System.Drawing.Point(4, 32);
            this.tabJournalMission.Name = "tabJournalMission";
            this.tabJournalMission.Padding = new System.Windows.Forms.Padding(3);
            this.tabJournalMission.Size = new System.Drawing.Size(1113, 550);
            this.tabJournalMission.TabIndex = 1;
            this.tabJournalMission.Text = "Journal de bord ";
            this.tabJournalMission.UseVisualStyleBackColor = true;
            // 
            // grpCapture
            // 
            this.grpCapture.Controls.Add(this.flowLayoutPanel1);
            this.grpCapture.Location = new System.Drawing.Point(358, 15);
            this.grpCapture.Name = "grpCapture";
            this.grpCapture.Size = new System.Drawing.Size(309, 312);
            this.grpCapture.TabIndex = 10;
            this.grpCapture.TabStop = false;
            this.grpCapture.Text = "Objectif ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(303, 286);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Enabled = false;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(114, 148);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // frmDetailMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 607);
            this.Controls.Add(this.tabGeneral);
            this.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDetailMission";
            this.Text = "frmDetailMission";
            this.tabGeneral.ResumeLayout(false);
            this.tabDetailMission.ResumeLayout(false);
            this.tabDetailMission.PerformLayout();
            this.grpMembre.ResumeLayout(false);
            this.flpMembre.ResumeLayout(false);
            this.grpRoute.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpDateDepart.ResumeLayout(false);
            this.grpDateDepart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlanete)).EndInit();
            this.grpCapture.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabDetailMission;
        private System.Windows.Forms.TabPage tabJournalMission;
        private System.Windows.Forms.PictureBox picturePlanete;
        private System.Windows.Forms.Label lblNomMission;
        private System.Windows.Forms.GroupBox grpDateDepart;
        private System.Windows.Forms.Label lblDD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDateDépart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDateDeFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblbu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblSoldeApresDepense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpRoute;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox grpMembre;
        private System.Windows.Forms.FlowLayoutPanel flpMembre;
        private System.Windows.Forms.GroupBox grpCapture;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}