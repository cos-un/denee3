using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] kelimeler = { "ARABA", "CAM", "KELEBEK", "TELEFON", "MÜZİK", "FONT", "CIRAK", "CEZA", "FARE", "HALAT", };
        String secim;
        String kelime;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        } 

        private void buttonBasla_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            secim = kelimeler[rnd.Next(1, 7)];
            label8.Text = secim;
            label1.Text = "";
            for (int i = 0; i < secim.Length; i++)
            {
                kelime += " _ ";
            }
            label1.Text = kelime;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonBul_Click(object sender, EventArgs e)
        {

        }
    }
}
