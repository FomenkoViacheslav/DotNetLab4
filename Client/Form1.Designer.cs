namespace Client
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 31);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 93);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 77);
            this.button1.TabIndex = 1;
            this.button1.Text = "Підключитись до серверу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(256, 50);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(904, 604);
            this.listBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 180);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 31);
            this.textBox2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 221);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 84);
            this.button2.TabIndex = 4;
            this.button2.Text = "Відправити повідомлення";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Items.AddRange(new object[] {
            " Slava",
            "Ivan",
            "Masha"});
            this.listBox2.Location = new System.Drawing.Point(16, 449);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(232, 204);
            this.listBox2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 327);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 84);
            this.button3.TabIndex = 6;
            this.button3.Text = "Глобальний чат";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Приватний чат";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

