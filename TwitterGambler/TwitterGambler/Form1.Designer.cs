namespace TwitterGambler
{
    partial class Form1
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
            this.lbTwitterUsers = new System.Windows.Forms.ListBox();
            this.btnAddTwitterUser = new System.Windows.Forms.Button();
            this.btnAddKeyword = new System.Windows.Forms.Button();
            this.lbKeywords = new System.Windows.Forms.ListBox();
            this.txtAddTwitterUser = new System.Windows.Forms.TextBox();
            this.txtAddKeyword = new System.Windows.Forms.TextBox();
            this.btnDeleteKeyword = new System.Windows.Forms.Button();
            this.btnDeleteTwitterUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tmrRefreshTwitter = new System.Windows.Forms.Timer(this.components);
            this.lblCountdown = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi5M = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi10M = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi30M = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi1H = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEx = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTwitterUsers
            // 
            this.lbTwitterUsers.BackColor = System.Drawing.SystemColors.Control;
            this.lbTwitterUsers.FormattingEnabled = true;
            this.lbTwitterUsers.Location = new System.Drawing.Point(12, 112);
            this.lbTwitterUsers.Name = "lbTwitterUsers";
            this.lbTwitterUsers.Size = new System.Drawing.Size(176, 303);
            this.lbTwitterUsers.TabIndex = 0;
            // 
            // btnAddTwitterUser
            // 
            this.btnAddTwitterUser.Location = new System.Drawing.Point(12, 83);
            this.btnAddTwitterUser.Name = "btnAddTwitterUser";
            this.btnAddTwitterUser.Size = new System.Drawing.Size(175, 23);
            this.btnAddTwitterUser.TabIndex = 1;
            this.btnAddTwitterUser.Text = "Add Twitter User";
            this.btnAddTwitterUser.UseVisualStyleBackColor = true;
            this.btnAddTwitterUser.Click += new System.EventHandler(this.btnAddTwitterUser_Click);
            // 
            // btnAddKeyword
            // 
            this.btnAddKeyword.Location = new System.Drawing.Point(194, 83);
            this.btnAddKeyword.Name = "btnAddKeyword";
            this.btnAddKeyword.Size = new System.Drawing.Size(175, 23);
            this.btnAddKeyword.TabIndex = 3;
            this.btnAddKeyword.Text = "Add Keyword";
            this.btnAddKeyword.UseVisualStyleBackColor = true;
            this.btnAddKeyword.Click += new System.EventHandler(this.btnAddKeyword_Click);
            // 
            // lbKeywords
            // 
            this.lbKeywords.BackColor = System.Drawing.SystemColors.Control;
            this.lbKeywords.FormattingEnabled = true;
            this.lbKeywords.Location = new System.Drawing.Point(194, 112);
            this.lbKeywords.Name = "lbKeywords";
            this.lbKeywords.Size = new System.Drawing.Size(176, 303);
            this.lbKeywords.TabIndex = 2;
            // 
            // txtAddTwitterUser
            // 
            this.txtAddTwitterUser.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddTwitterUser.Location = new System.Drawing.Point(12, 57);
            this.txtAddTwitterUser.Name = "txtAddTwitterUser";
            this.txtAddTwitterUser.Size = new System.Drawing.Size(175, 20);
            this.txtAddTwitterUser.TabIndex = 4;
            // 
            // txtAddKeyword
            // 
            this.txtAddKeyword.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddKeyword.Location = new System.Drawing.Point(195, 57);
            this.txtAddKeyword.Name = "txtAddKeyword";
            this.txtAddKeyword.Size = new System.Drawing.Size(175, 20);
            this.txtAddKeyword.TabIndex = 5;
            // 
            // btnDeleteKeyword
            // 
            this.btnDeleteKeyword.Location = new System.Drawing.Point(195, 421);
            this.btnDeleteKeyword.Name = "btnDeleteKeyword";
            this.btnDeleteKeyword.Size = new System.Drawing.Size(175, 23);
            this.btnDeleteKeyword.TabIndex = 7;
            this.btnDeleteKeyword.Text = "Delete Keyword";
            this.btnDeleteKeyword.UseVisualStyleBackColor = true;
            this.btnDeleteKeyword.Click += new System.EventHandler(this.btnDeleteKeyword_Click);
            // 
            // btnDeleteTwitterUser
            // 
            this.btnDeleteTwitterUser.Location = new System.Drawing.Point(13, 421);
            this.btnDeleteTwitterUser.Name = "btnDeleteTwitterUser";
            this.btnDeleteTwitterUser.Size = new System.Drawing.Size(175, 23);
            this.btnDeleteTwitterUser.TabIndex = 6;
            this.btnDeleteTwitterUser.Text = "Delete Twitter User";
            this.btnDeleteTwitterUser.UseVisualStyleBackColor = true;
            this.btnDeleteTwitterUser.Click += new System.EventHandler(this.btnDeleteTwitterUser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(393, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 332);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(393, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search!";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 450);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(356, 13);
            this.progressBar1.TabIndex = 11;
            // 
            // tmrRefreshTwitter
            // 
            this.tmrRefreshTwitter.Interval = 1000;
            this.tmrRefreshTwitter.Tick += new System.EventHandler(this.tmrRefreshTwitter_Tick);
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Location = new System.Drawing.Point(376, 449);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(0, 13);
            this.lblCountdown.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEx,
            this.tsmi5M,
            this.tsmi10M,
            this.tsmi30M,
            this.tsmi1H});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Refresh Rate";
            // 
            // tsmi5M
            // 
            this.tsmi5M.Checked = true;
            this.tsmi5M.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi5M.Name = "tsmi5M";
            this.tsmi5M.Size = new System.Drawing.Size(152, 22);
            this.tsmi5M.Text = "5m";
            this.tsmi5M.Click += new System.EventHandler(this.tsmi5M_Click);
            // 
            // tsmi10M
            // 
            this.tsmi10M.Name = "tsmi10M";
            this.tsmi10M.Size = new System.Drawing.Size(152, 22);
            this.tsmi10M.Text = "10M";
            this.tsmi10M.Click += new System.EventHandler(this.tsmi10M_Click);
            // 
            // tsmi30M
            // 
            this.tsmi30M.Name = "tsmi30M";
            this.tsmi30M.Size = new System.Drawing.Size(152, 22);
            this.tsmi30M.Text = "30M";
            this.tsmi30M.Click += new System.EventHandler(this.tsmi30M_Click);
            // 
            // tsmi1H
            // 
            this.tsmi1H.Name = "tsmi1H";
            this.tsmi1H.Size = new System.Drawing.Size(152, 22);
            this.tsmi1H.Text = "1H";
            this.tsmi1H.Click += new System.EventHandler(this.tsmi1H_Click);
            // 
            // tsmiEx
            // 
            this.tsmiEx.Name = "tsmiEx";
            this.tsmiEx.Size = new System.Drawing.Size(152, 22);
            this.tsmiEx.Text = "Expirimental";
            this.tsmiEx.Click += new System.EventHandler(this.tsmiEx_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(780, 468);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteKeyword);
            this.Controls.Add(this.btnDeleteTwitterUser);
            this.Controls.Add(this.txtAddKeyword);
            this.Controls.Add(this.txtAddTwitterUser);
            this.Controls.Add(this.btnAddKeyword);
            this.Controls.Add(this.lbKeywords);
            this.Controls.Add(this.btnAddTwitterUser);
            this.Controls.Add(this.lbTwitterUsers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TwitterGambler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTwitterUsers;
        private System.Windows.Forms.Button btnAddTwitterUser;
        private System.Windows.Forms.Button btnAddKeyword;
        private System.Windows.Forms.ListBox lbKeywords;
        private System.Windows.Forms.TextBox txtAddTwitterUser;
        private System.Windows.Forms.TextBox txtAddKeyword;
        private System.Windows.Forms.Button btnDeleteKeyword;
        private System.Windows.Forms.Button btnDeleteTwitterUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer tmrRefreshTwitter;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmi5M;
        private System.Windows.Forms.ToolStripMenuItem tsmi10M;
        private System.Windows.Forms.ToolStripMenuItem tsmi30M;
        private System.Windows.Forms.ToolStripMenuItem tsmi1H;
        private System.Windows.Forms.ToolStripMenuItem tsmiEx;

    }
}

