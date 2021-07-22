using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdenNKadarCiftSayilarinnToplam
{
    public partial class Form1 : Form
    {
        int Toplam = 0;
        int i = 1;
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(num.Value);
            while (i <= n)
            {
                if (i % 2 == 0)
                {
                    Toplam += i;
                    i++;
                }
                else
                    i++;
            }

            label2.Text = Toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(num.Value);

            label2.Text = ((n / 2) * ((n / 2) + 1)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(num.Value);

            label2.Text = (n * (n+1)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = string.Empty;
        }
    }
}
