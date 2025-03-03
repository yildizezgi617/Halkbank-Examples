using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _12_MasaustuUygulama
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Mesaj");
            string txt = textBox2.Text;
            MessageBox.Show(txt);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txt = textBox2.Text;
            textBox1.Text = txt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }
    }
}
