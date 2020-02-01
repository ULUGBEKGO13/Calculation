using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public double x;
        public double y;
        public double z;
        public int action;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            comboBox1.Text += Convert.ToString(x);
            comboBox1.Text += "*";
            textBox1.Text = "";
            action = 1;
        }

        private void Division_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            comboBox1.Text += Convert.ToString(x);
            comboBox1.Text += "/";
            textBox1.Text = "";
            action = 2;
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            comboBox1.Text += Convert.ToString(x);
            comboBox1.Text += "+";
            textBox1.Text = "";
            action = 3;
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            comboBox1.Text += Convert.ToString(x);
            comboBox1.Text += "-";
            textBox1.Text = "";
            action = 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            comboBox1.Text += Convert.ToString(y);
            comboBox1.Text += "=";
            if (action == 1)
            {
                z = x * y;
                textBox1.Text = Convert.ToString(z);
                comboBox1.Text += textBox1.Text;
                comboBox1.Text += "  ";
            }
            if(action == 2)
            {
                z = x / y;
                textBox1.Text = Convert.ToString(z);
                comboBox1.Text += textBox1.Text;
                comboBox1.Text += "  ";
            }
            if(action == 3)
            {
                z = x + y;
                textBox1.Text = Convert.ToString(z);
                comboBox1.Text += textBox1.Text;
                comboBox1.Text += "  ";
            }
            if(action == 4)
            {
                z = x - y;
                textBox1.Text = Convert.ToString(z);
                comboBox1.Text += textBox1.Text;
                comboBox1.Text += "  ";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }
    }
}
