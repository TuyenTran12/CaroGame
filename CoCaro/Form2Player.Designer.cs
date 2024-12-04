
namespace CoCaro
{
    partial class Form2Player
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
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdb_1 = new System.Windows.Forms.RadioButton();
            this.rbd_2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_3tran = new System.Windows.Forms.CheckBox();
            this.chk_5tran = new System.Windows.Forms.CheckBox();
            this.chk_7tran = new System.Windows.Forms.CheckBox();
            this.chk_10tran = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên người chơi 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên người chơi 2";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(151, 49);
            this.txtPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(275, 22);
            this.txtPlayer1.TabIndex = 6;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(151, 94);
            this.txtPlayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(275, 22);
            this.txtPlayer2.TabIndex = 7;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(167, 239);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(67, 26);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Chơi";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mời nhập thông tin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Chọn người đi trước";
            // 
            // rdb_1
            // 
            this.rdb_1.AutoSize = true;
            this.rdb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_1.Location = new System.Drawing.Point(167, 147);
            this.rdb_1.Name = "rdb_1";
            this.rdb_1.Size = new System.Drawing.Size(91, 20);
            this.rdb_1.TabIndex = 15;
            this.rdb_1.TabStop = true;
            this.rdb_1.Text = "1 đi trước";
            this.rdb_1.UseVisualStyleBackColor = true;
            // 
            // rbd_2
            // 
            this.rbd_2.AutoSize = true;
            this.rbd_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbd_2.Location = new System.Drawing.Point(311, 145);
            this.rbd_2.Name = "rbd_2";
            this.rbd_2.Size = new System.Drawing.Size(91, 20);
            this.rbd_2.TabIndex = 16;
            this.rbd_2.TabStop = true;
            this.rbd_2.Text = "2 đi trước";
            this.rbd_2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Số trận";
            // 
            // chk_3tran
            // 
            this.chk_3tran.AutoSize = true;
            this.chk_3tran.Location = new System.Drawing.Point(90, 197);
            this.chk_3tran.Name = "chk_3tran";
            this.chk_3tran.Size = new System.Drawing.Size(61, 20);
            this.chk_3tran.TabIndex = 22;
            this.chk_3tran.Text = "3 trận";
            this.chk_3tran.UseVisualStyleBackColor = true;
            // 
            // chk_5tran
            // 
            this.chk_5tran.AutoSize = true;
            this.chk_5tran.Location = new System.Drawing.Point(173, 197);
            this.chk_5tran.Name = "chk_5tran";
            this.chk_5tran.Size = new System.Drawing.Size(61, 20);
            this.chk_5tran.TabIndex = 23;
            this.chk_5tran.Text = "5 trận";
            this.chk_5tran.UseVisualStyleBackColor = true;
            // 
            // chk_7tran
            // 
            this.chk_7tran.AutoSize = true;
            this.chk_7tran.Location = new System.Drawing.Point(258, 197);
            this.chk_7tran.Name = "chk_7tran";
            this.chk_7tran.Size = new System.Drawing.Size(61, 20);
            this.chk_7tran.TabIndex = 24;
            this.chk_7tran.Text = "7 trận";
            this.chk_7tran.UseVisualStyleBackColor = true;
            // 
            // chk_10tran
            // 
            this.chk_10tran.AutoSize = true;
            this.chk_10tran.Location = new System.Drawing.Point(341, 196);
            this.chk_10tran.Name = "chk_10tran";
            this.chk_10tran.Size = new System.Drawing.Size(68, 20);
            this.chk_10tran.TabIndex = 25;
            this.chk_10tran.Text = "10 trận";
            this.chk_10tran.UseVisualStyleBackColor = true;
            // 
            // Form2Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 276);
            this.Controls.Add(this.chk_10tran);
            this.Controls.Add(this.chk_7tran);
            this.Controls.Add(this.chk_5tran);
            this.Controls.Add(this.chk_3tran);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbd_2);
            this.Controls.Add(this.rdb_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2Player";
            this.Text = "Form2Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdb_1;
        private System.Windows.Forms.RadioButton rbd_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_3tran;
        private System.Windows.Forms.CheckBox chk_5tran;
        private System.Windows.Forms.CheckBox chk_7tran;
        private System.Windows.Forms.CheckBox chk_10tran;
    }
}