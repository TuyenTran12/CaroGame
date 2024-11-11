namespace UICaro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlChessBoard = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            pctbAvatar = new PictureBox();
            panel1 = new Panel();
            btnLAN = new Button();
            txbIP = new TextBox();
            pctbMark = new PictureBox();
            prcbCoolDown = new ProgressBar();
            txbPlayerName = new TextBox();
            label1 = new Label();
            tmCoolDown = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbAvatar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.BackColor = SystemColors.Control;
            pnlChessBoard.Location = new Point(12, 76);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(463, 462);
            pnlChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pctbAvatar);
            panel2.Location = new Point(485, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 203);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Niagara Engraved", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 6;
            label2.Text = "Made By";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pctbAvatar
            // 
            pctbAvatar.BackgroundImage = Properties.Resources.HUIT;
            pctbAvatar.BackgroundImageLayout = ImageLayout.Stretch;
            pctbAvatar.Location = new Point(18, 29);
            pctbAvatar.Name = "pctbAvatar";
            pctbAvatar.Size = new Size(197, 170);
            pctbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbAvatar.TabIndex = 0;
            pctbAvatar.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnLAN);
            panel1.Controls.Add(txbIP);
            panel1.Controls.Add(pctbMark);
            panel1.Controls.Add(prcbCoolDown);
            panel1.Controls.Add(txbPlayerName);
            panel1.Location = new Point(485, 256);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 282);
            panel1.TabIndex = 2;
            // 
            // btnLAN
            // 
            btnLAN.Font = new Font("Niagara Engraved", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLAN.Location = new Point(140, 127);
            btnLAN.Name = "btnLAN";
            btnLAN.Size = new Size(75, 33);
            btnLAN.TabIndex = 4;
            btnLAN.Text = "JOIN";
            btnLAN.UseVisualStyleBackColor = true;
            // 
            // txbIP
            // 
            txbIP.Location = new Point(18, 134);
            txbIP.Name = "txbIP";
            txbIP.Size = new Size(115, 23);
            txbIP.TabIndex = 3;
            txbIP.Text = "127.0.0.1";
            // 
            // pctbMark
            // 
            pctbMark.BackColor = SystemColors.Control;
            pctbMark.Location = new Point(18, 12);
            pctbMark.Name = "pctbMark";
            pctbMark.Size = new Size(72, 66);
            pctbMark.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbMark.TabIndex = 2;
            pctbMark.TabStop = false;
            // 
            // prcbCoolDown
            // 
            prcbCoolDown.BackColor = SystemColors.Control;
            prcbCoolDown.ForeColor = Color.Transparent;
            prcbCoolDown.Location = new Point(18, 98);
            prcbCoolDown.Name = "prcbCoolDown";
            prcbCoolDown.RightToLeftLayout = true;
            prcbCoolDown.Size = new Size(197, 23);
            prcbCoolDown.TabIndex = 1;
            // 
            // txbPlayerName
            // 
            txbPlayerName.AcceptsReturn = true;
            txbPlayerName.Location = new Point(100, 12);
            txbPlayerName.Name = "txbPlayerName";
            txbPlayerName.ReadOnly = true;
            txbPlayerName.Size = new Size(115, 23);
            txbPlayerName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Niagara Engraved", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 5;
            label1.Text = ">>> 5 in a line to win !!!";
            // 
            // tmCoolDown
            // 
            tmCoolDown.Tick += tmCoolDown_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(723, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, undoToolStripMenuItem, quitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newGameToolStripMenuItem.Size = new Size(180, 22);
            newGameToolStripMenuItem.Text = "New game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(180, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quitToolStripMenuItem.Size = new Size(180, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(723, 550);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pnlChessBoard);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "THE CARO GAME";
            FormClosing += Form1_FormClosing;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbAvatar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlChessBoard;
        private Panel panel2;
        private Panel panel1;
        private Button btnLAN;
        private TextBox txbIP;
        private PictureBox pctbMark;
        private ProgressBar prcbCoolDown;
        private TextBox txbPlayerName;
        private Label label1;
        private Label label2;
        private PictureBox pctbAvatar;
        private System.Windows.Forms.Timer tmCoolDown;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}
