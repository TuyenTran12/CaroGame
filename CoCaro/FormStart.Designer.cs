
namespace CoCaro
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOnePlayer = new System.Windows.Forms.Button();
            this.btnTwoPlayer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtUsername = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Score = new System.Windows.Forms.Label();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAME CARO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "GAME MODE";
            // 
            // btnOnePlayer
            // 
            this.btnOnePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOnePlayer.Location = new System.Drawing.Point(15, 310);
            this.btnOnePlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOnePlayer.Name = "btnOnePlayer";
            this.btnOnePlayer.Size = new System.Drawing.Size(235, 46);
            this.btnOnePlayer.TabIndex = 2;
            this.btnOnePlayer.Text = "Chơi với máy";
            this.btnOnePlayer.UseVisualStyleBackColor = true;
            this.btnOnePlayer.Click += new System.EventHandler(this.btnOnePlayer_Click);
            // 
            // btnTwoPlayer
            // 
            this.btnTwoPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTwoPlayer.Location = new System.Drawing.Point(15, 375);
            this.btnTwoPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTwoPlayer.Name = "btnTwoPlayer";
            this.btnTwoPlayer.Size = new System.Drawing.Size(235, 46);
            this.btnTwoPlayer.TabIndex = 3;
            this.btnTwoPlayer.Text = "Chơi 2 người";
            this.btnTwoPlayer.UseVisualStyleBackColor = true;
            this.btnTwoPlayer.Click += new System.EventHandler(this.btnTwoPlayer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(753, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Huit product";
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeaderboard.Location = new System.Drawing.Point(604, 310);
            this.btnLeaderboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(235, 46);
            this.btnLeaderboard.TabIndex = 5;
            this.btnLeaderboard.Text = "Bảng vàng";
            this.btnLeaderboard.UseVisualStyleBackColor = true;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(667, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "LEADERBOARD";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtUsername});
            this.menuStrip1.Location = new System.Drawing.Point(604, 42);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(63, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtUsername
            // 
            this.txtUsername.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangePassword,
            this.txtLogOut});
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtUsername.ForeColor = System.Drawing.Color.Red;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(55, 24);
            this.txtUsername.Text = "User";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(186, 26);
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtLogOut
            // 
            this.txtLogOut.Name = "txtLogOut";
            this.txtLogOut.Size = new System.Drawing.Size(186, 26);
            this.txtLogOut.Text = "Đăng xuất";
            this.txtLogOut.Click += new System.EventHandler(this.txtLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoCaro.Properties.Resources.MatTrang;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(883, 516);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Score
            // 
            this.lb_Score.AutoSize = true;
            this.lb_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Score.ForeColor = System.Drawing.Color.Purple;
            this.lb_Score.Location = new System.Drawing.Point(416, 41);
            this.lb_Score.Name = "lb_Score";
            this.lb_Score.Size = new System.Drawing.Size(37, 29);
            this.lb_Score.TabIndex = 10;
            this.lb_Score.Text = "...";
            this.lb_Score.Click += new System.EventHandler(this.lb_Score_Click);
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 517);
            this.Controls.Add(this.lb_Score);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLeaderboard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTwoPlayer);
            this.Controls.Add(this.btnOnePlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStart";
            this.Text = "THE CARO GAME";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOnePlayer;
        private System.Windows.Forms.Button btnTwoPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem txtUsername;
        private System.Windows.Forms.ToolStripMenuItem btnChangePassword;
        private System.Windows.Forms.ToolStripMenuItem txtLogOut;
        private System.Windows.Forms.Label lb_Score;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
    }
}