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
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpCapture = new System.Windows.Forms.GroupBox();
            this.flpObjectif = new System.Windows.Forms.FlowLayoutPanel();
            this.grpMembre = new System.Windows.Forms.GroupBox();
            this.flpMembre = new System.Windows.Forms.FlowLayoutPanel();
            this.grpRoute = new System.Windows.Forms.GroupBox();
            this.richTextFeuilleRoute = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSoldeApresDepense = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblbu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDateDeFin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpDateDepart = new System.Windows.Forms.GroupBox();
            this.lblDateDépart = new System.Windows.Forms.Label();
            this.lblDD = new System.Windows.Forms.Label();
            this.lblNomMission = new System.Windows.Forms.Label();
            this.tabJournalMission = new System.Windows.Forms.TabPage();
            this.lblTotDepense = new System.Windows.Forms.Label();
            this.lblSommeVersee = new System.Windows.Forms.Label();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.dgvContact = new System.Windows.Forms.DataGridView();
            this.grpDepense = new System.Windows.Forms.GroupBox();
            this.dgvDepense = new System.Windows.Forms.DataGridView();
            this.grpEventJournal = new System.Windows.Forms.GroupBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpBilanCapture = new System.Windows.Forms.GroupBox();
            this.dgvCapture = new System.Windows.Forms.DataGridView();
            this.pictureInfo = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picturePlanete = new System.Windows.Forms.PictureBox();
            this.pictureFullDroite = new System.Windows.Forms.PictureBox();
            this.pictureDroite = new System.Windows.Forms.PictureBox();
            this.pictureGauche = new System.Windows.Forms.PictureBox();
            this.pictureFullGauche = new System.Windows.Forms.PictureBox();
            this.btnPdf = new System.Windows.Forms.Button();
            this.tabGeneral.SuspendLayout();
            this.tabDetailMission.SuspendLayout();
            this.grpCapture.SuspendLayout();
            this.grpMembre.SuspendLayout();
            this.grpRoute.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpDateDepart.SuspendLayout();
            this.tabJournalMission.SuspendLayout();
            this.grpContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.grpDepense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepense)).BeginInit();
            this.grpEventJournal.SuspendLayout();
            this.grpBilanCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlanete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFullDroite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDroite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGauche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFullGauche)).BeginInit();
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
            this.tabGeneral.SelectedIndexChanged += new System.EventHandler(this.tabGeneral_SelectedIndexChanged);
            // 
            // tabDetailMission
            // 
            this.tabDetailMission.Controls.Add(this.pictureInfo);
            this.tabDetailMission.Controls.Add(this.btnAdd);
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(209, 54);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Ajouter des informations";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpCapture
            // 
            this.grpCapture.Controls.Add(this.flpObjectif);
            this.grpCapture.Location = new System.Drawing.Point(358, 15);
            this.grpCapture.Name = "grpCapture";
            this.grpCapture.Size = new System.Drawing.Size(309, 278);
            this.grpCapture.TabIndex = 10;
            this.grpCapture.TabStop = false;
            this.grpCapture.Text = "Objectif ";
            // 
            // flpObjectif
            // 
            this.flpObjectif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpObjectif.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpObjectif.Location = new System.Drawing.Point(3, 23);
            this.flpObjectif.Name = "flpObjectif";
            this.flpObjectif.Size = new System.Drawing.Size(303, 252);
            this.flpObjectif.TabIndex = 0;
            // 
            // grpMembre
            // 
            this.grpMembre.Controls.Add(this.flpMembre);
            this.grpMembre.Location = new System.Drawing.Point(16, 299);
            this.grpMembre.Name = "grpMembre";
            this.grpMembre.Size = new System.Drawing.Size(651, 221);
            this.grpMembre.TabIndex = 9;
            this.grpMembre.TabStop = false;
            this.grpMembre.Text = "Membre (5 requis)";
            // 
            // flpMembre
            // 
            this.flpMembre.AutoScroll = true;
            this.flpMembre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMembre.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMembre.Location = new System.Drawing.Point(3, 23);
            this.flpMembre.Name = "flpMembre";
            this.flpMembre.Padding = new System.Windows.Forms.Padding(10);
            this.flpMembre.Size = new System.Drawing.Size(645, 195);
            this.flpMembre.TabIndex = 0;
            // 
            // grpRoute
            // 
            this.grpRoute.Controls.Add(this.richTextFeuilleRoute);
            this.grpRoute.Location = new System.Drawing.Point(691, 179);
            this.grpRoute.Name = "grpRoute";
            this.grpRoute.Size = new System.Drawing.Size(411, 341);
            this.grpRoute.TabIndex = 7;
            this.grpRoute.TabStop = false;
            this.grpRoute.Text = "Feuille de route";
            // 
            // richTextFeuilleRoute
            // 
            this.richTextFeuilleRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextFeuilleRoute.Location = new System.Drawing.Point(13, 29);
            this.richTextFeuilleRoute.Name = "richTextFeuilleRoute";
            this.richTextFeuilleRoute.ReadOnly = true;
            this.richTextFeuilleRoute.Size = new System.Drawing.Size(389, 300);
            this.richTextFeuilleRoute.TabIndex = 0;
            this.richTextFeuilleRoute.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.lblSoldeApresDepense);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(898, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 61);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
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
            this.groupBox2.Location = new System.Drawing.Point(690, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 61);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
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
            this.groupBox1.Location = new System.Drawing.Point(898, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
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
            this.grpDateDepart.Location = new System.Drawing.Point(690, 19);
            this.grpDateDepart.Name = "grpDateDepart";
            this.grpDateDepart.Size = new System.Drawing.Size(183, 61);
            this.grpDateDepart.TabIndex = 2;
            this.grpDateDepart.TabStop = false;
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
            this.lblNomMission.Location = new System.Drawing.Point(14, 168);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(234, 30);
            this.lblNomMission.TabIndex = 1;
            this.lblNomMission.Text = "Mission Nom mission";
            // 
            // tabJournalMission
            // 
            this.tabJournalMission.Controls.Add(this.btnPdf);
            this.tabJournalMission.Controls.Add(this.lblTotDepense);
            this.tabJournalMission.Controls.Add(this.lblSommeVersee);
            this.tabJournalMission.Controls.Add(this.grpContact);
            this.tabJournalMission.Controls.Add(this.grpDepense);
            this.tabJournalMission.Controls.Add(this.grpEventJournal);
            this.tabJournalMission.Controls.Add(this.grpBilanCapture);
            this.tabJournalMission.Location = new System.Drawing.Point(4, 32);
            this.tabJournalMission.Name = "tabJournalMission";
            this.tabJournalMission.Padding = new System.Windows.Forms.Padding(3);
            this.tabJournalMission.Size = new System.Drawing.Size(1113, 550);
            this.tabJournalMission.TabIndex = 1;
            this.tabJournalMission.Text = "Journal de bord ";
            this.tabJournalMission.UseVisualStyleBackColor = true;
            // 
            // lblTotDepense
            // 
            this.lblTotDepense.AutoSize = true;
            this.lblTotDepense.Location = new System.Drawing.Point(583, 434);
            this.lblTotDepense.Name = "lblTotDepense";
            this.lblTotDepense.Size = new System.Drawing.Size(53, 23);
            this.lblTotDepense.TabIndex = 3;
            this.lblTotDepense.Text = "label1";
            // 
            // lblSommeVersee
            // 
            this.lblSommeVersee.AutoSize = true;
            this.lblSommeVersee.Location = new System.Drawing.Point(17, 434);
            this.lblSommeVersee.Name = "lblSommeVersee";
            this.lblSommeVersee.Size = new System.Drawing.Size(53, 23);
            this.lblSommeVersee.TabIndex = 2;
            this.lblSommeVersee.Text = "label1";
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.dgvContact);
            this.grpContact.Location = new System.Drawing.Point(18, 205);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(535, 229);
            this.grpContact.TabIndex = 1;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact avec les informateurs";
            // 
            // dgvContact
            // 
            this.dgvContact.AllowUserToAddRows = false;
            this.dgvContact.AllowUserToDeleteRows = false;
            this.dgvContact.BackgroundColor = System.Drawing.Color.White;
            this.dgvContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContact.Location = new System.Drawing.Point(3, 23);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.ReadOnly = true;
            this.dgvContact.Size = new System.Drawing.Size(529, 203);
            this.dgvContact.TabIndex = 0;
            // 
            // grpDepense
            // 
            this.grpDepense.Controls.Add(this.dgvDepense);
            this.grpDepense.Location = new System.Drawing.Point(581, 205);
            this.grpDepense.Name = "grpDepense";
            this.grpDepense.Size = new System.Drawing.Size(526, 226);
            this.grpDepense.TabIndex = 1;
            this.grpDepense.TabStop = false;
            this.grpDepense.Text = "Dépenses effectuées";
            // 
            // dgvDepense
            // 
            this.dgvDepense.AllowUserToAddRows = false;
            this.dgvDepense.AllowUserToDeleteRows = false;
            this.dgvDepense.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDepense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepense.Location = new System.Drawing.Point(3, 23);
            this.dgvDepense.Name = "dgvDepense";
            this.dgvDepense.ReadOnly = true;
            this.dgvDepense.Size = new System.Drawing.Size(520, 200);
            this.dgvDepense.TabIndex = 0;
            // 
            // grpEventJournal
            // 
            this.grpEventJournal.Controls.Add(this.lblEvent);
            this.grpEventJournal.Controls.Add(this.lblDate);
            this.grpEventJournal.Controls.Add(this.pictureFullDroite);
            this.grpEventJournal.Controls.Add(this.pictureDroite);
            this.grpEventJournal.Controls.Add(this.pictureGauche);
            this.grpEventJournal.Controls.Add(this.pictureFullGauche);
            this.grpEventJournal.Location = new System.Drawing.Point(18, 6);
            this.grpEventJournal.Name = "grpEventJournal";
            this.grpEventJournal.Size = new System.Drawing.Size(535, 190);
            this.grpEventJournal.TabIndex = 0;
            this.grpEventJournal.TabStop = false;
            this.grpEventJournal.Text = "Evénements du journal";
            // 
            // lblEvent
            // 
            this.lblEvent.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.Location = new System.Drawing.Point(100, 62);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(333, 55);
            this.lblEvent.TabIndex = 4;
            this.lblEvent.Text = "Décollage réussi, tout va bien, le moral de l\'équipage est au beau fixe";
            this.lblEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(212, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(98, 23);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "2026-01-01";
            // 
            // grpBilanCapture
            // 
            this.grpBilanCapture.Controls.Add(this.dgvCapture);
            this.grpBilanCapture.Location = new System.Drawing.Point(584, 6);
            this.grpBilanCapture.Name = "grpBilanCapture";
            this.grpBilanCapture.Size = new System.Drawing.Size(520, 193);
            this.grpBilanCapture.TabIndex = 4;
            this.grpBilanCapture.TabStop = false;
            this.grpBilanCapture.Text = "Bilan des captures";
            // 
            // dgvCapture
            // 
            this.dgvCapture.AllowUserToAddRows = false;
            this.dgvCapture.AllowUserToDeleteRows = false;
            this.dgvCapture.BackgroundColor = System.Drawing.Color.White;
            this.dgvCapture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCapture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCapture.Location = new System.Drawing.Point(3, 23);
            this.dgvCapture.Name = "dgvCapture";
            this.dgvCapture.ReadOnly = true;
            this.dgvCapture.Size = new System.Drawing.Size(514, 167);
            this.dgvCapture.TabIndex = 0;
            // 
            // pictureInfo
            // 
            this.pictureInfo.Image = global::Projet_SAE_24_Stargate.Properties.Resources.info;
            this.pictureInfo.Location = new System.Drawing.Point(232, 228);
            this.pictureInfo.Name = "pictureInfo";
            this.pictureInfo.Size = new System.Drawing.Size(35, 39);
            this.pictureInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureInfo.TabIndex = 12;
            this.pictureInfo.TabStop = false;
            this.pictureInfo.Visible = false;
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
            // picturePlanete
            // 
            this.picturePlanete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePlanete.Location = new System.Drawing.Point(16, 32);
            this.picturePlanete.Name = "picturePlanete";
            this.picturePlanete.Size = new System.Drawing.Size(130, 130);
            this.picturePlanete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePlanete.TabIndex = 0;
            this.picturePlanete.TabStop = false;
            // 
            // pictureFullDroite
            // 
            this.pictureFullDroite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureFullDroite.Image = global::Projet_SAE_24_Stargate.Properties.Resources.flecheFullDroite;
            this.pictureFullDroite.Location = new System.Drawing.Point(333, 135);
            this.pictureFullDroite.Name = "pictureFullDroite";
            this.pictureFullDroite.Size = new System.Drawing.Size(30, 30);
            this.pictureFullDroite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFullDroite.TabIndex = 3;
            this.pictureFullDroite.TabStop = false;
            this.pictureFullDroite.Click += new System.EventHandler(this.pictureFullDroite_Click);
            // 
            // pictureDroite
            // 
            this.pictureDroite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureDroite.Image = global::Projet_SAE_24_Stargate.Properties.Resources.flecheDroite;
            this.pictureDroite.Location = new System.Drawing.Point(280, 135);
            this.pictureDroite.Name = "pictureDroite";
            this.pictureDroite.Size = new System.Drawing.Size(30, 30);
            this.pictureDroite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDroite.TabIndex = 2;
            this.pictureDroite.TabStop = false;
            this.pictureDroite.Click += new System.EventHandler(this.pictureDroite_Click);
            // 
            // pictureGauche
            // 
            this.pictureGauche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureGauche.Image = global::Projet_SAE_24_Stargate.Properties.Resources.flecheGauche;
            this.pictureGauche.Location = new System.Drawing.Point(225, 135);
            this.pictureGauche.Name = "pictureGauche";
            this.pictureGauche.Size = new System.Drawing.Size(30, 30);
            this.pictureGauche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGauche.TabIndex = 1;
            this.pictureGauche.TabStop = false;
            this.pictureGauche.Click += new System.EventHandler(this.pictureGauche_Click);
            // 
            // pictureFullGauche
            // 
            this.pictureFullGauche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureFullGauche.Image = global::Projet_SAE_24_Stargate.Properties.Resources.flecheFullGauche;
            this.pictureFullGauche.Location = new System.Drawing.Point(172, 135);
            this.pictureFullGauche.Name = "pictureFullGauche";
            this.pictureFullGauche.Size = new System.Drawing.Size(30, 30);
            this.pictureFullGauche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFullGauche.TabIndex = 0;
            this.pictureFullGauche.TabStop = false;
            this.pictureFullGauche.Click += new System.EventHandler(this.pictureFullGauche_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(485, 486);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(151, 45);
            this.btnPdf.TabIndex = 5;
            this.btnPdf.Text = "Editer un pdf";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
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
            this.Load += new System.EventHandler(this.frmDetailMission_Load);
            this.tabGeneral.ResumeLayout(false);
            this.tabDetailMission.ResumeLayout(false);
            this.tabDetailMission.PerformLayout();
            this.grpCapture.ResumeLayout(false);
            this.grpMembre.ResumeLayout(false);
            this.grpRoute.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDateDepart.ResumeLayout(false);
            this.grpDateDepart.PerformLayout();
            this.tabJournalMission.ResumeLayout(false);
            this.tabJournalMission.PerformLayout();
            this.grpContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            this.grpDepense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepense)).EndInit();
            this.grpEventJournal.ResumeLayout(false);
            this.grpEventJournal.PerformLayout();
            this.grpBilanCapture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlanete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFullDroite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDroite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGauche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFullGauche)).EndInit();
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
        private System.Windows.Forms.RichTextBox richTextFeuilleRoute;
        private System.Windows.Forms.GroupBox grpMembre;
        private System.Windows.Forms.FlowLayoutPanel flpMembre;
        private System.Windows.Forms.GroupBox grpCapture;
        private System.Windows.Forms.FlowLayoutPanel flpObjectif;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.GroupBox grpDepense;
        private System.Windows.Forms.GroupBox grpEventJournal;
        private System.Windows.Forms.PictureBox pictureGauche;
        private System.Windows.Forms.PictureBox pictureFullGauche;
        private System.Windows.Forms.PictureBox pictureFullDroite;
        private System.Windows.Forms.PictureBox pictureDroite;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.DataGridView dgvContact;
        private System.Windows.Forms.DataGridView dgvDepense;
        private System.Windows.Forms.Label lblSommeVersee;
        private System.Windows.Forms.Label lblTotDepense;
        private System.Windows.Forms.GroupBox grpBilanCapture;
        private System.Windows.Forms.DataGridView dgvCapture;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureInfo;
        private System.Windows.Forms.Button btnPdf;
    }
}