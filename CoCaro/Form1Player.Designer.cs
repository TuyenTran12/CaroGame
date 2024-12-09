
namespace CoCaro
{
    partial class Form1Player
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.cbbLevel = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.cb10 = new System.Windows.Forms.CheckBox();
            this.cb7 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbComputerFirst = new System.Windows.Forms.RadioButton();
            this.rbPlayerFirst = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người chơi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mời nhập thông tin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn cấp độ";
            // 
            // txtPlayer
            // 
            this.txtPlayer.Enabled = false;
            this.txtPlayer.Location = new System.Drawing.Point(147, 64);
            this.txtPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.ReadOnly = true;
            this.txtPlayer.Size = new System.Drawing.Size(280, 22);
            this.txtPlayer.TabIndex = 3;
            // 
            // cbbLevel
            // 
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5"});
            this.cbbLevel.Location = new System.Drawing.Point(147, 102);
            this.cbbLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(144, 24);
            this.cbbLevel.TabIndex = 4;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(168, 267);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(67, 26);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Chơi";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // cb10
            // 
            this.cb10.AutoSize = true;
            this.cb10.Location = new System.Drawing.Point(342, 215);
            this.cb10.Name = "cb10";
            this.cb10.Size = new System.Drawing.Size(68, 20);
            this.cb10.TabIndex = 33;
            this.cb10.Text = "10 trận";
            this.cb10.UseVisualStyleBackColor = true;
            // 
            // cb7
            // 
            this.cb7.AutoSize = true;
            this.cb7.Location = new System.Drawing.Point(259, 216);
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size(61, 20);
            this.cb7.TabIndex = 32;
            this.cb7.Text = "7 trận";
            this.cb7.UseVisualStyleBackColor = true;
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Location = new System.Drawing.Point(174, 216);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(61, 20);
            this.cb5.TabIndex = 31;
            this.cb5.Text = "5 trận";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(91, 216);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(61, 20);
            this.cb3.TabIndex = 30;
            this.cb3.Text = "3 trận";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Số trận";
            // 
            // rbComputerFirst
            // 
            this.rbComputerFirst.AutoSize = true;
            this.rbComputerFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbComputerFirst.Location = new System.Drawing.Point(312, 164);
            this.rbComputerFirst.Name = "rbComputerFirst";
            this.rbComputerFirst.Size = new System.Drawing.Size(112, 20);
            this.rbComputerFirst.TabIndex = 28;
            this.rbComputerFirst.TabStop = true;
            this.rbComputerFirst.Text = "Máy đi trước";
            this.rbComputerFirst.UseVisualStyleBackColor = true;
            // 
            // rbPlayerFirst
            // 
            this.rbPlayerFirst.AutoSize = true;
            this.rbPlayerFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlayerFirst.Location = new System.Drawing.Point(168, 166);
            this.rbPlayerFirst.Name = "rbPlayerFirst";
            this.rbPlayerFirst.Size = new System.Drawing.Size(124, 20);
            this.rbPlayerFirst.TabIndex = 27;
            this.rbPlayerFirst.TabStop = true;
            this.rbPlayerFirst.Text = "Người đi trước";
            this.rbPlayerFirst.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Chọn người đi trước";
            // 
            // Form1Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 304);
            this.Controls.Add(this.cb10);
            this.Controls.Add(this.cb7);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbComputerFirst);
            this.Controls.Add(this.rbPlayerFirst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.cbbLevel);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1Player";
            this.Text = "Form1Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.ComboBox cbbLevel;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.CheckBox cb10;
        private System.Windows.Forms.CheckBox cb7;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbComputerFirst;
        private System.Windows.Forms.RadioButton rbPlayerFirst;
        private System.Windows.Forms.Label label4;
    }
}