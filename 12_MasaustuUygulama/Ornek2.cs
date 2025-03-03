using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// ad soyad özelliklerini alan ve bunları listboxa ekleyen üyelik sistemimesaj ver butonuna tıklandığında ekranda yasi kadar pes pese mesaj yazdırılsın
namespace _12_MasaustuUygulama
{
    public partial class Ornek2 : Form
    {
        public Ornek2()
        {
            InitializeComponent();
        }

        private void Ornek2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = ad.Text;
            string soyadi = soyad.Text;
            string yasi = yas.Text;
           int yasii= int.Parse(yasi);
            listBox1.Items.Add(adi + soyadi+yasi);

            for (int i = 0; i < yasii; i++)
            {
              MessageBox.Show(adi+soyadi+yasi);
            }


        }
    }
}
