using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kare_Dikdörtgen_Alan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            label2.Text = "Bir kenar uzunlugu:";
            label3.Visible = false;
            textBox2.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;
            label2.Text = "Uzun kenar uzunlugu:";
            label3.Text = "Kısa kenar uzunlugu:";
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                int a, cevre, alan;
                a = Convert.ToInt32(textBox1.Text);
                cevre = 4 * a;
                label6.Text = cevre.ToString();
                alan = a * a;
                label7.Text = alan.ToString();
            }
            else
            {
                int a, b, cevre, alan;
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                cevre = a + a + b + b;
                label6.Text = cevre.ToString();
                alan = a * b;
                label7.Text = alan.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
    }
}
