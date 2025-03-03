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
    public partial class Ornek : Form
    {
        public Ornek()
        {
            InitializeComponent();
        }

        private void Ornek_Load(object sender, EventArgs e)
        {
            listBox1.Enabled = false;
            listBox2.Enabled = false;

            List<string> kisiler = new List<string> { "Ezgi", "Nisa", "Can", "Büşra", };
            foreach (var item in kisiler)
            {
                listBox1.Items.Add(item);
            }
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
           
            Random random = new Random();
           string ad=  (string)listBox1.Items[random.Next(0, listBox1.Items.Count)];
            sonSecim.Text = ad;
            listBox2.Items.Add(ad);
           
            listBox1.Items.Remove(ad);


        }
    }
}
