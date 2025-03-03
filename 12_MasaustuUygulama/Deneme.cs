using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_MasaustuUygulama
{


    //text boxa girilen değeri comboboxtan seçilen değerle gönder dendiğinde listboxda gösteren uygulama

    public partial class Deneme : Form
    {
        public Deneme()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Deneme_Load_1(object sender, EventArgs e)
        {
            List<string> isimler = new List<string> { "Ezgi", "Büşra", "Can" };
            foreach (var item in isimler)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = textBox1.Text;
            string secim = comboBox1.SelectedItem as string;
            listBox1.Items.Add(secim + " " + mesaj);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
