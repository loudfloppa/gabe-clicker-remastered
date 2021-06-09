namespace gabe_clicker_remastered
{
    partial class devmode
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.keyenter = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.hidetext = new System.Windows.Forms.CheckBox();
            this.keyStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 23);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "enable developer mode";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.Image = global::gabe_clicker_remastered.Properties.Resources.ui_close;
            this.pictureBox2.Location = new System.Drawing.Point(389, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "developer mode requires a key to access. \r\nenter it in the textbox below (FORMAT:" +
    " abc1234)";
            // 
            // keyenter
            // 
            this.keyenter.Location = new System.Drawing.Point(12, 82);
            this.keyenter.MaxLength = 7;
            this.keyenter.Name = "keyenter";
            this.keyenter.Size = new System.Drawing.Size(92, 20);
            this.keyenter.TabIndex = 7;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(110, 82);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(62, 20);
            this.submit.TabIndex = 8;
            this.submit.Text = "OK";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // hidetext
            // 
            this.hidetext.AutoSize = true;
            this.hidetext.Location = new System.Drawing.Point(12, 108);
            this.hidetext.Name = "hidetext";
            this.hidetext.Size = new System.Drawing.Size(66, 17);
            this.hidetext.TabIndex = 9;
            this.hidetext.Text = "hide text";
            this.hidetext.UseVisualStyleBackColor = true;
            this.hidetext.CheckedChanged += new System.EventHandler(this.hidetext_CheckedChanged);
            // 
            // keyStatus
            // 
            this.keyStatus.BackColor = System.Drawing.Color.Transparent;
            this.keyStatus.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyStatus.Location = new System.Drawing.Point(178, 83);
            this.keyStatus.Name = "keyStatus";
            this.keyStatus.Size = new System.Drawing.Size(234, 23);
            this.keyStatus.TabIndex = 10;
            this.keyStatus.Text = "keyStatus";
            this.keyStatus.Visible = false;
            this.keyStatus.Click += new System.EventHandler(this.keyStatus_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "global key used.";
            this.label4.Visible = false;
            // 
            // devmode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(415, 132);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.keyStatus);
            this.Controls.Add(this.hidetext);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.keyenter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "devmode";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "devmode";
            this.Load += new System.EventHandler(this.devmode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyenter;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.CheckBox hidetext;
        private System.Windows.Forms.Label keyStatus;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label1;
    }
}