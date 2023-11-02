using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreOlusturucu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sifreboyutu = random.Next(10, 16);
            string sifre2 = "";
            for (int i = 0; i < sifreboyutu; i++)
            {
                int karakter = random.Next(33, 126);
                sifre2 += Convert.ToChar(karakter).ToString();
            }
            textBox1.Text = sifre2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
