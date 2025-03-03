namespace _12_MasaustuUygulama
{
    partial class Isimlendir
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
            btnSec = new Button();
            label1 = new Label();
            cmbCities = new ComboBox();
            SuspendLayout();
            // 
            // btnSec
            // 
            btnSec.BackColor = SystemColors.ControlLightLight;
            btnSec.Font = new Font("Segoe UI", 30F);
            btnSec.Location = new Point(204, 151);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(404, 93);
            btnSec.TabIndex = 0;
            btnSec.Text = "Hangi  Şehir Seçildi";
            btnSec.UseVisualStyleBackColor = false;
            btnSec.Click += btnSec_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(195, 72);
            label1.Name = "label1";
            label1.Size = new Size(108, 54);
            label1.TabIndex = 1;
            label1.Text = "şehir";
            // 
            // cmbCities
            // 
            cmbCities.FormattingEnabled = true;
            cmbCities.Location = new Point(309, 91);
            cmbCities.Name = "cmbCities";
            cmbCities.Size = new Size(288, 23);
            cmbCities.TabIndex = 2;
            cmbCities.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Isimlendir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbCities);
            Controls.Add(label1);
            Controls.Add(btnSec);
            Name = "Isimlendir";
            Text = "Isimlendir";
            Load += Isimlendir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSec;
        private Label label1;
        private ComboBox cmbCities;
    }
}