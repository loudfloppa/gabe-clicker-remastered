namespace gabe_clicker_remastered
{
    partial class itemgivedialog
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
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "you received an item!";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(234, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "thx bro *kisses*";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 40);
            this.label1.TabIndex = 10;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(12, 51);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(301, 23);
            this.name.TabIndex = 11;
            this.name.Text = "name";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(25, 74);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(301, 23);
            this.type.TabIndex = 12;
            this.type.Text = "type";
            this.type.Click += new System.EventHandler(this.type_Click);
            // 
            // duration
            // 
            this.duration.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration.Location = new System.Drawing.Point(25, 97);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(301, 23);
            this.duration.TabIndex = 13;
            this.duration.Text = "duration";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(112, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 24);
            this.button2.TabIndex = 14;
            this.button2.Text = "fuck you i decline";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // itemgivedialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(350, 160);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.type);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "itemgivedialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "itemgivedialog";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.itemgivedialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Button button2;
    }
}