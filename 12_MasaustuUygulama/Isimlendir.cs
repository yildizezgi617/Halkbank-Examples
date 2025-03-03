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
    public partial class Isimlendir : Form
    {
        public Isimlendir()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            string secim = cmbCities.SelectedItem as string;
            MessageBox.Show(secim);

        }

        private void Isimlendir_Load(object sender, EventArgs e)
        {
            List<string> cities = new List<string> { "Ankara", "İstanbul", "İzmir", "Bursa", "Antalya" };
            foreach (var item in cities)
            {
                cmbCities.Items.Add(item);
            }
        }
    }
}
