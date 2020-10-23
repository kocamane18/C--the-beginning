using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Dunyasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(textBox3.Text);

            if (checkBox1.Checked == true) {
                label11.Text = checkBox1.Text;
            }
            if (checkBox2.Checked == true) {
                label12.Text = checkBox2.Text;
            }
            if (checkBox3.Checked == true) {
                label13.Text = checkBox3.Text;
            }
            if (checkBox4.Checked == true)
            {
                label14.Text = checkBox4.Text;
            }
            listBox5.Items.Add(" "+label11.Text +" "+ label12.Text+" "+label13.Text+" "+label14.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
      
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
       
        }
    }
}
