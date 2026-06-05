namespace Projet_SAE_24_Stargate
{
    partial class frmDemarrage
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flpMission = new System.Windows.Forms.FlowLayoutPanel();
            this.chkEnCours = new System.Windows.Forms.CheckBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.flpListRace = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureRace = new System.Windows.Forms.PictureBox();
            this.lblPlanete = new System.Windows.Forms.Label();
            this.flpListePlanete = new System.Windows.Forms.FlowLayoutPanel();
            this.picturePlanete = new System.Windows.Forms.PictureBox();
            this.flpNvMission = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureMission = new System.Windows.Forms.PictureBox();
            this.lblMission = new System.Windows.Forms.Label();
            this.flpStat = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureStt = new System.Windows.Forms.PictureBox();
            this.lblStat = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flpMission.SuspendLayout();
            this.flpListRace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRace)).BeginInit();
            this.flpListePlanete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlanete)).BeginInit();
            this.flpNvMission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMission)).BeginInit();
            this.flpStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Projet_SAE_24_Stargate.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(1611, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Rafraichir les missions");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flpMission
            // 
            this.flpMission.AutoScroll = true;
            this.flpMission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flpMission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpMission.Controls.Add(this.chkEnCours);
            this.flpMission.Location = new System.Drawing.Point(1741, 18);
            this.flpMission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpMission.Name = "flpMission";
            this.flpMission.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.flpMission.Size = new System.Drawing.Size(810, 1335);
            this.flpMission.TabIndex = 1;
            // 
            // chkEnCours
            // 
            this.chkEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnCours.Location = new System.Drawing.Point(19, 20);
            this.chkEnCours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEnCours.Name = "chkEnCours";
            this.chkEnCours.Size = new System.Drawing.Size(750, 34);
            this.chkEnCours.TabIndex = 1;
            this.chkEnCours.Text = "Afficher seulement les missions en cours";
            this.chkEnCours.UseVisualStyleBackColor = true;
            this.chkEnCours.CheckedChanged += new System.EventHandler(this.chkEnCours_CheckedChanged);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Red;
            this.lblTitre.Location = new System.Drawing.Point(52, 78);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(796, 63);
            this.lblTitre.TabIndex = 3;
            this.lblTitre.Tag = "title";
            this.lblTitre.Text = "STARGATE COMMAND USAF";
            // 
            // lblRace
            // 
            this.lblRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRace.Location = new System.Drawing.Point(176, 2);
            this.lblRace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(387, 163);
            this.lblRace.TabIndex = 6;
            this.lblRace.Text = "Liste des races";
            this.lblRace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRace.Click += new System.EventHandler(this.lblRace_Click);
            // 
            // flpListRace
            // 
            this.flpListRace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpListRace.Controls.Add(this.pictureRace);
            this.flpListRace.Controls.Add(this.lblRace);
            this.flpListRace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flpListRace.Location = new System.Drawing.Point(40, 578);
            this.flpListRace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpListRace.Name = "flpListRace";
            this.flpListRace.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpListRace.Size = new System.Drawing.Size(580, 175);
            this.flpListRace.TabIndex = 10;
            this.flpListRace.Click += new System.EventHandler(this.flpListRace_Click);
            // 
            // pictureRace
            // 
            this.pictureRace.Image = global::Projet_SAE_24_Stargate.Properties.Resources.alien;
            this.pictureRace.Location = new System.Drawing.Point(6, 7);
            this.pictureRace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureRace.Name = "pictureRace";
            this.pictureRace.Size = new System.Drawing.Size(162, 158);
            this.pictureRace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRace.TabIndex = 5;
            this.pictureRace.TabStop = false;
            this.pictureRace.Click += new System.EventHandler(this.pictureRace_Click);
            // 
            // lblPlanete
            // 
            this.lblPlanete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanete.Location = new System.Drawing.Point(176, 2);
            this.lblPlanete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanete.Name = "lblPlanete";
            this.lblPlanete.Size = new System.Drawing.Size(387, 163);
            this.lblPlanete.TabIndex = 6;
            this.lblPlanete.Text = "Liste des planètes";
            this.lblPlanete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlanete.Click += new System.EventHandler(this.lblPlanete_Click);
            // 
            // flpListePlanete
            // 
            this.flpListePlanete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpListePlanete.Controls.Add(this.picturePlanete);
            this.flpListePlanete.Controls.Add(this.lblPlanete);
            this.flpListePlanete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flpListePlanete.Location = new System.Drawing.Point(40, 844);
            this.flpListePlanete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpListePlanete.Name = "flpListePlanete";
            this.flpListePlanete.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpListePlanete.Size = new System.Drawing.Size(580, 175);
            this.flpListePlanete.TabIndex = 11;
            this.flpListePlanete.Click += new System.EventHandler(this.flpListePlanete_Click);
            // 
            // picturePlanete
            // 
            this.picturePlanete.Image = global::Projet_SAE_24_Stargate.Properties.Resources.neonPlanete;
            this.picturePlanete.Location = new System.Drawing.Point(6, 7);
            this.picturePlanete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picturePlanete.Name = "picturePlanete";
            this.picturePlanete.Size = new System.Drawing.Size(162, 158);
            this.picturePlanete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePlanete.TabIndex = 5;
            this.picturePlanete.TabStop = false;
            this.picturePlanete.Click += new System.EventHandler(this.picturePlanete_Click);
            // 
            // flpNvMission
            // 
            this.flpNvMission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpNvMission.Controls.Add(this.pictureMission);
            this.flpNvMission.Controls.Add(this.lblMission);
            this.flpNvMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flpNvMission.Location = new System.Drawing.Point(40, 325);
            this.flpNvMission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpNvMission.Name = "flpNvMission";
            this.flpNvMission.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpNvMission.Size = new System.Drawing.Size(580, 175);
            this.flpNvMission.TabIndex = 9;
            this.flpNvMission.Click += new System.EventHandler(this.flpNvMission_Click);
            // 
            // pictureMission
            // 
            this.pictureMission.Image = global::Projet_SAE_24_Stargate.Properties.Resources.ajouterMission;
            this.pictureMission.Location = new System.Drawing.Point(6, 7);
            this.pictureMission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureMission.Name = "pictureMission";
            this.pictureMission.Size = new System.Drawing.Size(162, 158);
            this.pictureMission.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMission.TabIndex = 5;
            this.pictureMission.TabStop = false;
            this.pictureMission.Click += new System.EventHandler(this.pictureMission_Click);
            // 
            // lblMission
            // 
            this.lblMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMission.Location = new System.Drawing.Point(176, 2);
            this.lblMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(387, 172);
            this.lblMission.TabIndex = 6;
            this.lblMission.Text = "Nouvelle mission";
            this.lblMission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMission.Click += new System.EventHandler(this.lblMission_Click_1);
            // 
            // flpStat
            // 
            this.flpStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpStat.Controls.Add(this.pictureStt);
            this.flpStat.Controls.Add(this.lblStat);
            this.flpStat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flpStat.Location = new System.Drawing.Point(40, 1118);
            this.flpStat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpStat.Name = "flpStat";
            this.flpStat.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpStat.Size = new System.Drawing.Size(580, 175);
            this.flpStat.TabIndex = 12;
            this.flpStat.Click += new System.EventHandler(this.flpStat_Click);
            // 
            // pictureStt
            // 
            this.pictureStt.Image = global::Projet_SAE_24_Stargate.Properties.Resources.stat;
            this.pictureStt.Location = new System.Drawing.Point(6, 7);
            this.pictureStt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureStt.Name = "pictureStt";
            this.pictureStt.Size = new System.Drawing.Size(162, 158);
            this.pictureStt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureStt.TabIndex = 5;
            this.pictureStt.TabStop = false;
            this.pictureStt.Click += new System.EventHandler(this.pictureStt_Click);
            // 
            // lblStat
            // 
            this.lblStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat.Location = new System.Drawing.Point(176, 2);
            this.lblStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(387, 163);
            this.lblStat.TabIndex = 6;
            this.lblStat.Text = "Statistiques";
            this.lblStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStat.Click += new System.EventHandler(this.lblStat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projet_SAE_24_Stargate.Properties.Resources.fondTitle;
            this.pictureBox2.Location = new System.Drawing.Point(9, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(887, 226);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // frmDemarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_SAE_24_Stargate.Properties.Resources.backgroundDemar;
            this.ClientSize = new System.Drawing.Size(2564, 1367);
            this.Controls.Add(this.flpNvMission);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.flpStat);
            this.Controls.Add(this.flpListePlanete);
            this.Controls.Add(this.flpListRace);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flpMission);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDemarrage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tableau de bord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDemarrage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flpMission.ResumeLayout(false);
            this.flpListRace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRace)).EndInit();
            this.flpListePlanete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePlanete)).EndInit();
            this.flpNvMission.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMission)).EndInit();
            this.flpStat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureStt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flpMission;
        private System.Windows.Forms.CheckBox chkEnCours;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.PictureBox pictureRace;
        private System.Windows.Forms.FlowLayoutPanel flpListRace;
        private System.Windows.Forms.Label lblPlanete;
        private System.Windows.Forms.PictureBox picturePlanete;
        private System.Windows.Forms.FlowLayoutPanel flpListePlanete;
        private System.Windows.Forms.PictureBox pictureMission;
        private System.Windows.Forms.FlowLayoutPanel flpNvMission;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.FlowLayoutPanel flpStat;
        private System.Windows.Forms.PictureBox pictureStt;
        private System.Windows.Forms.Label lblStat;
    }
}