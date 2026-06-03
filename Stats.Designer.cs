namespace Projet_SAE_24_Stargate
{
    partial class Stats
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
            this.dgvReq2 = new System.Windows.Forms.DataGridView();
            this.dgvReq4 = new System.Windows.Forms.DataGridView();
            this.dgvReq3 = new System.Windows.Forms.DataGridView();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.cboReq1 = new System.Windows.Forms.ComboBox();
            this.dgvReq1 = new System.Windows.Forms.DataGridView();
            this.cboReq5 = new System.Windows.Forms.ComboBox();
            this.dgvReq5 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq5)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReq2
            // 
            this.dgvReq2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReq2.Location = new System.Drawing.Point(521, 33);
            this.dgvReq2.Name = "dgvReq2";
            this.dgvReq2.RowHeadersWidth = 62;
            this.dgvReq2.RowTemplate.Height = 28;
            this.dgvReq2.Size = new System.Drawing.Size(407, 253);
            this.dgvReq2.TabIndex = 1;
            // 
            // dgvReq4
            // 
            this.dgvReq4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReq4.Location = new System.Drawing.Point(169, 453);
            this.dgvReq4.Name = "dgvReq4";
            this.dgvReq4.RowHeadersWidth = 62;
            this.dgvReq4.RowTemplate.Height = 28;
            this.dgvReq4.Size = new System.Drawing.Size(438, 257);
            this.dgvReq4.TabIndex = 2;
            // 
            // dgvReq3
            // 
            this.dgvReq3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReq3.Location = new System.Drawing.Point(1026, 13);
            this.dgvReq3.Name = "dgvReq3";
            this.dgvReq3.RowHeadersWidth = 62;
            this.dgvReq3.RowTemplate.Height = 28;
            this.dgvReq3.Size = new System.Drawing.Size(335, 265);
            this.dgvReq3.TabIndex = 4;
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // cboReq1
            // 
            this.cboReq1.FormattingEnabled = true;
            this.cboReq1.Location = new System.Drawing.Point(13, 44);
            this.cboReq1.Name = "cboReq1";
            this.cboReq1.Size = new System.Drawing.Size(121, 28);
            this.cboReq1.TabIndex = 5;
            this.cboReq1.SelectedIndexChanged += new System.EventHandler(this.cboReq1_SelectedIndexChanged);
            // 
            // dgvReq1
            // 
            this.dgvReq1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReq1.Location = new System.Drawing.Point(13, 96);
            this.dgvReq1.Name = "dgvReq1";
            this.dgvReq1.RowHeadersWidth = 62;
            this.dgvReq1.RowTemplate.Height = 28;
            this.dgvReq1.Size = new System.Drawing.Size(240, 150);
            this.dgvReq1.TabIndex = 6;
            // 
            // cboReq5
            // 
            this.cboReq5.FormattingEnabled = true;
            this.cboReq5.Location = new System.Drawing.Point(806, 413);
            this.cboReq5.Name = "cboReq5";
            this.cboReq5.Size = new System.Drawing.Size(121, 28);
            this.cboReq5.TabIndex = 7;
            this.cboReq5.SelectedIndexChanged += new System.EventHandler(this.cboReq5_SelectedIndexChanged);
            // 
            // dgvReq5
            // 
            this.dgvReq5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReq5.Location = new System.Drawing.Point(832, 500);
            this.dgvReq5.Name = "dgvReq5";
            this.dgvReq5.RowHeadersWidth = 62;
            this.dgvReq5.RowTemplate.Height = 28;
            this.dgvReq5.Size = new System.Drawing.Size(240, 150);
            this.dgvReq5.TabIndex = 8;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 749);
            this.Controls.Add(this.dgvReq5);
            this.Controls.Add(this.cboReq5);
            this.Controls.Add(this.dgvReq1);
            this.Controls.Add(this.cboReq1);
            this.Controls.Add(this.dgvReq3);
            this.Controls.Add(this.dgvReq4);
            this.Controls.Add(this.dgvReq2);
            this.Name = "Stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stats";
            this.Load += new System.EventHandler(this.Stats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvReq2;
        private System.Windows.Forms.DataGridView dgvReq4;
        private System.Windows.Forms.DataGridView dgvReq3;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.ComboBox cboReq1;
        private System.Windows.Forms.DataGridView dgvReq1;
        private System.Windows.Forms.ComboBox cboReq5;
        private System.Windows.Forms.DataGridView dgvReq5;
    }
}