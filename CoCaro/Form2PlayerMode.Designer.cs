namespace CoCaro
{
    partial class Form2PlayerMode
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
            this.btn_Local = new System.Windows.Forms.Button();
            this.btn_LANMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Local
            // 
            this.btn_Local.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Local.Location = new System.Drawing.Point(11, 11);
            this.btn_Local.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Local.Name = "btn_Local";
            this.btn_Local.Size = new System.Drawing.Size(252, 310);
            this.btn_Local.TabIndex = 9;
            this.btn_Local.Text = "LOCAL";
            this.btn_Local.UseVisualStyleBackColor = true;
            this.btn_Local.Click += new System.EventHandler(this.btn_Local_Click);
            // 
            // btn_LANMode
            // 
            this.btn_LANMode.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LANMode.Location = new System.Drawing.Point(267, 11);
            this.btn_LANMode.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LANMode.Name = "btn_LANMode";
            this.btn_LANMode.Size = new System.Drawing.Size(254, 310);
            this.btn_LANMode.TabIndex = 10;
            this.btn_LANMode.Text = "LAN";
            this.btn_LANMode.UseVisualStyleBackColor = true;
            this.btn_LANMode.Click += new System.EventHandler(this.btn_LANMode_Click);
            // 
            // Form2PlayerMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 332);
            this.Controls.Add(this.btn_LANMode);
            this.Controls.Add(this.btn_Local);
            this.Name = "Form2PlayerMode";
            this.Text = "Form2PlayerMode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Local;
        private System.Windows.Forms.Button btn_LANMode;
    }
}