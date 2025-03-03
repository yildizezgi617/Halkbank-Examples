namespace _12_MasaustuUygulama
{
    partial class Test
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
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Viner Hand ITC", 30F);
            textBox2.ForeColor = Color.YellowGreen;
            textBox2.Location = new Point(61, 12);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(462, 97);
            textBox2.TabIndex = 1;
            textBox2.Text = "Mahmut";
            // 
            // button1
            // 
            button1.Font = new Font("Pristina", 16F);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(80, 115);
            button1.Name = "button1";
            button1.Size = new Size(202, 91);
            button1.TabIndex = 2;
            button1.Text = "Tikla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(312, 126);
            button2.Name = "button2";
            button2.Size = new Size(211, 80);
            button2.TabIndex = 3;
            button2.Text = "aktar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.MenuHighlight;
            textBox1.Location = new Point(80, 225);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(461, 101);
            textBox1.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(559, 67);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(219, 259);
            listBox1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(559, 28);
            button3.Name = "button3";
            button3.Size = new Size(205, 33);
            button3.TabIndex = 6;
            button3.Text = "Listeye Aktar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 465);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Font = new Font("Segoe UI", 10F);
            Name = "Test";
            Text = "Test";
            Load += Test_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button3;
    }
}