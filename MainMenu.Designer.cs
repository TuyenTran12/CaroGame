namespace UICaro
{
    partial class MainMenu
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
            pctbMainMenu = new PictureBox();
            label1 = new Label();
            lblPlay = new Label();
            ((System.ComponentModel.ISupportInitialize)pctbMainMenu).BeginInit();
            SuspendLayout();
            // 
            // pctbMainMenu
            // 
            pctbMainMenu.BackgroundImageLayout = ImageLayout.Stretch;
            pctbMainMenu.Image = Properties.Resources.MainMenu;
            pctbMainMenu.Location = new Point(-2, -2);
            pctbMainMenu.Name = "pctbMainMenu";
            pctbMainMenu.Size = new Size(743, 492);
            pctbMainMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbMainMenu.TabIndex = 0;
            pctbMainMenu.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Font = new Font("Niagara Engraved", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-2, 93);
            label1.Name = "label1";
            label1.Size = new Size(279, 68);
            label1.TabIndex = 1;
            label1.Text = "THE CARO GAME";
            // 
            // lblPlay
            // 
            lblPlay.AutoSize = true;
            lblPlay.BackColor = Color.Transparent;
            lblPlay.FlatStyle = FlatStyle.Popup;
            lblPlay.Font = new Font("Niagara Engraved", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlay.ForeColor = Color.RosyBrown;
            lblPlay.Location = new Point(34, 323);
            lblPlay.Name = "lblPlay";
            lblPlay.Size = new Size(59, 38);
            lblPlay.TabIndex = 2;
            lblPlay.Text = "PLAY";
            lblPlay.Click += lblPlay_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(740, 484);
            Controls.Add(lblPlay);
            Controls.Add(label1);
            Controls.Add(pctbMainMenu);
            Name = "MainMenu";
            Text = "THE CARO GAME";
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pctbMainMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctbMainMenu;
        private Label label1;
        private Label lblPlay;
    }
}