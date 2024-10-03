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
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbAvatar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark).BeginInit();
            SuspendLayout();
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.BackColor = SystemColors.Control;
            pnlChessBoard.Location = new Point(14, 55);
            pnlChessBoard.Margin = new Padding(3, 4, 3, 4);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(529, 616);
            pnlChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pctbAvatar);
            panel2.Location = new Point(550, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 271);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Niagara Engraved", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(74, 29);
            label2.TabIndex = 6;
            label2.Text = "Made By";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pctbAvatar
            // 
            pctbAvatar.BackgroundImage = Properties.Resources.HUIT;
            pctbAvatar.BackgroundImageLayout = ImageLayout.Stretch;
            pctbAvatar.Location = new Point(38, 43);
            pctbAvatar.Margin = new Padding(3, 4, 3, 4);
            pctbAvatar.Name = "pctbAvatar";
            pctbAvatar.Size = new Size(195, 228);
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
            panel1.Location = new Point(550, 295);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 376);
            panel1.TabIndex = 2;
            // 
            // btnLAN
            // 
            btnLAN.Font = new Font("Niagara Engraved", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLAN.Location = new Point(160, 169);
            btnLAN.Margin = new Padding(3, 4, 3, 4);
            btnLAN.Name = "btnLAN";
            btnLAN.Size = new Size(86, 44);
            btnLAN.TabIndex = 4;
            btnLAN.Text = "JOIN";
            btnLAN.UseVisualStyleBackColor = true;
            // 
            // txbIP
            // 
            txbIP.Location = new Point(21, 179);
            txbIP.Margin = new Padding(3, 4, 3, 4);
            txbIP.Name = "txbIP";
            txbIP.Size = new Size(131, 27);
            txbIP.TabIndex = 3;
            txbIP.Text = "127.0.0.1";
            // 
            // pctbMark
            // 
            pctbMark.BackColor = SystemColors.Control;
            pctbMark.Location = new Point(21, 16);
            pctbMark.Margin = new Padding(3, 4, 3, 4);
            pctbMark.Name = "pctbMark";
            pctbMark.Size = new Size(82, 88);
            pctbMark.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbMark.TabIndex = 2;
            pctbMark.TabStop = false;
            // 
            // prcbCoolDown
            // 
            prcbCoolDown.Location = new Point(21, 131);
            prcbCoolDown.Margin = new Padding(3, 4, 3, 4);
            prcbCoolDown.Name = "prcbCoolDown";
            prcbCoolDown.Size = new Size(225, 31);
            prcbCoolDown.TabIndex = 1;
            // 
            // txbPlayerName
            // 
            txbPlayerName.AcceptsReturn = true;
            txbPlayerName.Location = new Point(114, 16);
            txbPlayerName.Margin = new Padding(3, 4, 3, 4);
            txbPlayerName.Name = "txbPlayerName";
            txbPlayerName.ReadOnly = true;
            txbPlayerName.Size = new Size(131, 27);
            txbPlayerName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Niagara Engraved", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 12);
            label1.Name = "label1";
            label1.Size = new Size(188, 29);
            label1.TabIndex = 5;
            label1.Text = ">>> 5 in a line to win !!!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(821, 687);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pnlChessBoard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "THE CARO GAME";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbAvatar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark).EndInit();
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
    }
}
