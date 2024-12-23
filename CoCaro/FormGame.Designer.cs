
namespace CoCaro
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.picChess = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.btnPlayMusic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picbMark = new System.Windows.Forms.PictureBox();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lb_SoTran = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_name1 = new System.Windows.Forms.Label();
            this.lb_diem1 = new System.Windows.Forms.Label();
            this.lb_name2 = new System.Windows.Forms.Label();
            this.lb_diem2 = new System.Windows.Forms.Label();
            this.picChess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbMark)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChessBoard.Location = new System.Drawing.Point(20, 36);
            this.pnlChessBoard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(809, 1180);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // picChess
            // 
            this.picChess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picChess.Controls.Add(this.picAvatar);
            this.picChess.Location = new System.Drawing.Point(877, 36);
            this.picChess.Margin = new System.Windows.Forms.Padding(4);
            this.picChess.Name = "picChess";
            this.picChess.Size = new System.Drawing.Size(388, 332);
            this.picChess.TabIndex = 1;
            // 
            // picAvatar
            // 
            this.picAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picAvatar.BackColor = System.Drawing.SystemColors.Control;
            this.picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvatar.Image = global::CoCaro.Properties.Resources.HUIT;
            this.picAvatar.Location = new System.Drawing.Point(0, 0);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(392, 335);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.prcbCoolDown);
            this.panel3.Controls.Add(this.btnPlayMusic);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.picbMark);
            this.panel3.Controls.Add(this.txbPlayerName);
            this.panel3.Location = new System.Drawing.Point(892, 463);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 418);
            this.panel3.TabIndex = 2;
            // 
            // prcbCoolDown
            // 
            this.prcbCoolDown.Location = new System.Drawing.Point(32, 249);
            this.prcbCoolDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prcbCoolDown.Name = "prcbCoolDown";
            this.prcbCoolDown.Size = new System.Drawing.Size(331, 39);
            this.prcbCoolDown.TabIndex = 7;
            // 
            // btnPlayMusic
            // 
            this.btnPlayMusic.Location = new System.Drawing.Point(217, 309);
            this.btnPlayMusic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayMusic.Name = "btnPlayMusic";
            this.btnPlayMusic.Size = new System.Drawing.Size(145, 30);
            this.btnPlayMusic.TabIndex = 6;
            this.btnPlayMusic.Text = "Play music";
            this.btnPlayMusic.UseVisualStyleBackColor = true;
            this.btnPlayMusic.Click += new System.EventHandler(this.btnPlayMusic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 364);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Five in a line to win";
            // 
            // picbMark
            // 
            this.picbMark.BackColor = System.Drawing.SystemColors.Control;
            this.picbMark.Location = new System.Drawing.Point(4, 0);
            this.picbMark.Margin = new System.Windows.Forms.Padding(4);
            this.picbMark.Name = "picbMark";
            this.picbMark.Size = new System.Drawing.Size(385, 220);
            this.picbMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbMark.TabIndex = 2;
            this.picbMark.TabStop = false;
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Location = new System.Drawing.Point(32, 318);
            this.txbPlayerName.Margin = new System.Windows.Forms.Padding(4);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.ReadOnly = true;
            this.txbPlayerName.Size = new System.Drawing.Size(147, 22);
            this.txbPlayerName.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1284, 26);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(872, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng số trận:";
            // 
            // lb_SoTran
            // 
            this.lb_SoTran.AutoSize = true;
            this.lb_SoTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoTran.ForeColor = System.Drawing.Color.Red;
            this.lb_SoTran.Location = new System.Drawing.Point(1006, 385);
            this.lb_SoTran.Name = "lb_SoTran";
            this.lb_SoTran.Size = new System.Drawing.Size(19, 20);
            this.lb_SoTran.TabIndex = 5;
            this.lb_SoTran.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(872, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tỉ số:";
            // 
            // lb_name1
            // 
            this.lb_name1.AutoSize = true;
            this.lb_name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name1.Location = new System.Drawing.Point(939, 425);
            this.lb_name1.Name = "lb_name1";
            this.lb_name1.Size = new System.Drawing.Size(59, 20);
            this.lb_name1.TabIndex = 7;
            this.lb_name1.Text = "name1";
            // 
            // lb_diem1
            // 
            this.lb_diem1.AutoSize = true;
            this.lb_diem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diem1.ForeColor = System.Drawing.Color.Red;
            this.lb_diem1.Location = new System.Drawing.Point(1018, 425);
            this.lb_diem1.Name = "lb_diem1";
            this.lb_diem1.Size = new System.Drawing.Size(19, 20);
            this.lb_diem1.TabIndex = 8;
            this.lb_diem1.Text = "0";
            // 
            // lb_name2
            // 
            this.lb_name2.AutoSize = true;
            this.lb_name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name2.Location = new System.Drawing.Point(1105, 425);
            this.lb_name2.Name = "lb_name2";
            this.lb_name2.Size = new System.Drawing.Size(59, 20);
            this.lb_name2.TabIndex = 9;
            this.lb_name2.Text = "name2";
            // 
            // lb_diem2
            // 
            this.lb_diem2.AutoSize = true;
            this.lb_diem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diem2.ForeColor = System.Drawing.Color.Red;
            this.lb_diem2.Location = new System.Drawing.Point(1191, 425);
            this.lb_diem2.Name = "lb_diem2";
            this.lb_diem2.Size = new System.Drawing.Size(19, 20);
            this.lb_diem2.TabIndex = 10;
            this.lb_diem2.Text = "0";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 890);
            this.Controls.Add(this.lb_diem2);
            this.Controls.Add(this.lb_name2);
            this.Controls.Add(this.lb_diem1);
            this.Controls.Add(this.lb_name1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_SoTran);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.picChess);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.picChess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbMark)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel picChess;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbMark;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button btnPlayMusic;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_SoTran;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_name1;
        private System.Windows.Forms.Label lb_diem1;
        private System.Windows.Forms.Label lb_name2;
        private System.Windows.Forms.Label lb_diem2;
    }
}

