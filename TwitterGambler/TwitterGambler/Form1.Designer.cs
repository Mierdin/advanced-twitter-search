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
            this.lbTwitterUsers = new System.Windows.Forms.ListBox();
            this.btnAddTwitterUser = new System.Windows.Forms.Button();
            this.btnAddKeyword = new System.Windows.Forms.Button();
            this.lbKeywords = new System.Windows.Forms.ListBox();
            this.txtAddTwitterUser = new System.Windows.Forms.TextBox();
            this.txtAddKeyword = new System.Windows.Forms.TextBox();
            this.btnDeleteKeyword = new System.Windows.Forms.Button();
            this.btnDeleteTwitterUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnViewUsersTweets = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGetTweets = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTwitterUsers
            // 
            this.lbTwitterUsers.FormattingEnabled = true;
            this.lbTwitterUsers.Location = new System.Drawing.Point(12, 68);
            this.lbTwitterUsers.Name = "lbTwitterUsers";
            this.lbTwitterUsers.Size = new System.Drawing.Size(176, 303);
            this.lbTwitterUsers.TabIndex = 0;
            // 
            // btnAddTwitterUser
            // 
            this.btnAddTwitterUser.Location = new System.Drawing.Point(12, 39);
            this.btnAddTwitterUser.Name = "btnAddTwitterUser";
            this.btnAddTwitterUser.Size = new System.Drawing.Size(175, 23);
            this.btnAddTwitterUser.TabIndex = 1;
            this.btnAddTwitterUser.Text = "Add Twitter User";
            this.btnAddTwitterUser.UseVisualStyleBackColor = true;
            this.btnAddTwitterUser.Click += new System.EventHandler(this.btnAddTwitterUser_Click);
            // 
            // btnAddKeyword
            // 
            this.btnAddKeyword.Location = new System.Drawing.Point(194, 39);
            this.btnAddKeyword.Name = "btnAddKeyword";
            this.btnAddKeyword.Size = new System.Drawing.Size(175, 23);
            this.btnAddKeyword.TabIndex = 3;
            this.btnAddKeyword.Text = "Add Keyword";
            this.btnAddKeyword.UseVisualStyleBackColor = true;
            this.btnAddKeyword.Click += new System.EventHandler(this.btnAddKeyword_Click);
            // 
            // lbKeywords
            // 
            this.lbKeywords.FormattingEnabled = true;
            this.lbKeywords.Location = new System.Drawing.Point(194, 68);
            this.lbKeywords.Name = "lbKeywords";
            this.lbKeywords.Size = new System.Drawing.Size(176, 303);
            this.lbKeywords.TabIndex = 2;
            // 
            // txtAddTwitterUser
            // 
            this.txtAddTwitterUser.Location = new System.Drawing.Point(12, 13);
            this.txtAddTwitterUser.Name = "txtAddTwitterUser";
            this.txtAddTwitterUser.Size = new System.Drawing.Size(175, 20);
            this.txtAddTwitterUser.TabIndex = 4;
            // 
            // txtAddKeyword
            // 
            this.txtAddKeyword.Location = new System.Drawing.Point(195, 13);
            this.txtAddKeyword.Name = "txtAddKeyword";
            this.txtAddKeyword.Size = new System.Drawing.Size(175, 20);
            this.txtAddKeyword.TabIndex = 5;
            // 
            // btnDeleteKeyword
            // 
            this.btnDeleteKeyword.Location = new System.Drawing.Point(195, 377);
            this.btnDeleteKeyword.Name = "btnDeleteKeyword";
            this.btnDeleteKeyword.Size = new System.Drawing.Size(175, 23);
            this.btnDeleteKeyword.TabIndex = 7;
            this.btnDeleteKeyword.Text = "Delete Keyword";
            this.btnDeleteKeyword.UseVisualStyleBackColor = true;
            this.btnDeleteKeyword.Click += new System.EventHandler(this.btnDeleteKeyword_Click);
            // 
            // btnDeleteTwitterUser
            // 
            this.btnDeleteTwitterUser.Location = new System.Drawing.Point(13, 377);
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
            this.dataGridView1.Location = new System.Drawing.Point(393, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 332);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnViewUsersTweets
            // 
            this.btnViewUsersTweets.Location = new System.Drawing.Point(580, 42);
            this.btnViewUsersTweets.Name = "btnViewUsersTweets";
            this.btnViewUsersTweets.Size = new System.Drawing.Size(130, 23);
            this.btnViewUsersTweets.TabIndex = 9;
            this.btnViewUsersTweets.Text = "View users tweets";
            this.btnViewUsersTweets.UseVisualStyleBackColor = true;
            this.btnViewUsersTweets.Click += new System.EventHandler(this.btnViewUsersTweets_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(393, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // btnGetTweets
            // 
            this.btnGetTweets.Location = new System.Drawing.Point(499, 42);
            this.btnGetTweets.Name = "btnGetTweets";
            this.btnGetTweets.Size = new System.Drawing.Size(75, 23);
            this.btnGetTweets.TabIndex = 11;
            this.btnGetTweets.Text = "getTweets";
            this.btnGetTweets.UseVisualStyleBackColor = true;
            this.btnGetTweets.Click += new System.EventHandler(this.btnGetTweets_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 412);
            this.Controls.Add(this.btnGetTweets);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnViewUsersTweets);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteKeyword);
            this.Controls.Add(this.btnDeleteTwitterUser);
            this.Controls.Add(this.txtAddKeyword);
            this.Controls.Add(this.txtAddTwitterUser);
            this.Controls.Add(this.btnAddKeyword);
            this.Controls.Add(this.lbKeywords);
            this.Controls.Add(this.btnAddTwitterUser);
            this.Controls.Add(this.lbTwitterUsers);
            this.Name = "Form1";
            this.Text = "TwitterGambler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnViewUsersTweets;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGetTweets;

    }
}

