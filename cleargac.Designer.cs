namespace gabe_clicker_remastered
{
    partial class cleargac
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
            this.gabepic = new System.Windows.Forms.PictureBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.proceed = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gabepic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "GAC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gabepic
            // 
            this.gabepic.Image = global::gabe_clicker_remastered.Properties.Resources.happygabe;
            this.gabepic.Location = new System.Drawing.Point(270, 23);
            this.gabepic.Name = "gabepic";
            this.gabepic.Size = new System.Drawing.Size(264, 169);
            this.gabepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gabepic.TabIndex = 2;
            this.gabepic.TabStop = false;
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.Red;
            this.label37.Location = new System.Drawing.Point(12, 35);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(152, 26);
            this.label37.TabIndex = 3;
            this.label37.Text = "clear GAC bans";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 61);
            this.label2.TabIndex = 4;
            this.label2.Text = "this will clear all gabe anti-cheat \r\nbans from your computer.";
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(437, 217);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(84, 26);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // proceed
            // 
            this.proceed.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceed.Location = new System.Drawing.Point(326, 217);
            this.proceed.Name = "proceed";
            this.proceed.Size = new System.Drawing.Size(105, 26);
            this.proceed.TabIndex = 6;
            this.proceed.Text = "proceed";
            this.proceed.UseVisualStyleBackColor = true;
            this.proceed.Click += new System.EventHandler(this.proceed_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(0, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 231);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(0, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(537, 2);
            this.label5.TabIndex = 9;
            // 
            // cleargac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(533, 255);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.proceed);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.gabepic);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cleargac";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clear gabe anti-cheat bans";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.gabepic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox gabepic;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button proceed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
    }
}