namespace _12_MasaustuUygulama
{
    partial class Ornek2
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
            ad = new TextBox();
            soyad = new TextBox();
            yas = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // ad
            // 
            ad.Location = new Point(32, 12);
            ad.Name = "ad";
            ad.Size = new Size(100, 23);
            ad.TabIndex = 0;
            // 
            // soyad
            // 
            soyad.Location = new Point(32, 62);
            soyad.Name = "soyad";
            soyad.Size = new Size(100, 23);
            soyad.TabIndex = 1;
            // 
            // yas
            // 
            yas.Location = new Point(32, 112);
            yas.Name = "yas";
            yas.Size = new Size(100, 23);
            yas.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(276, 86);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(499, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(142, 109);
            listBox1.TabIndex = 4;
            // 
            // Ornek2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(yas);
            Controls.Add(soyad);
            Controls.Add(ad);
            Name = "Ornek2";
            Text = "Ornek2";
            Load += Ornek2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ad;
        private TextBox soyad;
        private TextBox yas;
        private Button button1;
        private ListBox listBox1;
    }
}