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
    //kullanicidan alinan adet kadar içerisinde kullanıcının belirttiği karakter geçen rastgele isimleri seçip listboxa aktaran uygulama
    public partial class Ornek3 : Form
    {
        public Ornek3()
        {
            InitializeComponent();
        }

        List<string> list;
        private void Ornek3_Load(object sender, EventArgs e)
        {

            list = new List<string> { "Ezgi", "Nisa", "Can", "Büşra", };

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();


            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    var random = rnd.Next(list.Count);
                    bool a = list[random].Contains((string)textBox1.Text);
                    if (a)
                    {
                        listBox1.Items.Add(list[random]);
                        list.RemoveAt(random);
                        break;

                    }

                }

            }


        }
    }
}