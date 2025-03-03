using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//kullanicidan dosya yolu dosya adi ve uzantisini alarak ilgili yola dosya oluşturan ve kullanicinin girdiği metni kayit eden uygulama oluşturunuz.

namespace _12_MasaustuUygulama
{
    public partial class DosyaOrnek : Form
    {
        public DosyaOrnek()
        {
            InitializeComponent();
        }

        private void DosyaOrnek_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Uzanti_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = textBox1.Text;
            string yol = textBox2.Text;
            string uzanti = textBox3.Text;

        }
    }
}
