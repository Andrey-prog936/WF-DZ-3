using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double price = 0;
            double price1 = 0;
            foreach (CheckBox cb in groupBox4.Controls.OfType<CheckBox>())
            {
                if (cb.Checked == true)
                {
                    price += Convert.ToDouble(cb.Tag) * Convert.ToDouble(textBox3.Text);
                }
            }
            label10.Text = price.ToString();
            price = 0;
            if (radioButton1.Checked == true)
            {
                price1 = Convert.ToDouble(label6.Text) * Convert.ToDouble(textBox1.Text);
                label7.Text = price1.ToString();
            }
            else if (radioButton2.Checked == true)
            {
                price = Convert.ToDouble(textBox2.Text) / Convert.ToDouble(label6.Text);
                price = Math.Round(price, 2);
                label7.Text = price.ToString();
                label8.Text = "л.";
            }
            if (label8.Text == "л.")
            {
                label17.Text = ((Convert.ToDouble(label7.Text) * Convert.ToDouble(label6.Text)) + Convert.ToDouble(label10.Text)).ToString();
            }
            else if (label8.Text == "грн.")
            {
                label17.Text = (Convert.ToDouble(label7.Text) + Convert.ToDouble(label10.Text)).ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label6.Text = "26";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label6.Text = "24";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label6.Text = "23";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label6.Text = "21";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                label6.Text = "12";
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Enabled == true)
            {
                textBox1.Enabled = true;
                textBox2.Clear();
                textBox2.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Enabled == true)
            {
                textBox2.Enabled = true;
                textBox1.Clear();
                textBox1.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
                textBox3.Clear();
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox4.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
                textBox4.Clear();
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox5.Enabled = true;
            }
            else
            {
                textBox5.Enabled = false;
                textBox5.Clear();
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox6.Enabled = true;
            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Clear();
            }
        }
    }
}
