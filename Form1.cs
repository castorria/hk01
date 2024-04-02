using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        static int a = 0;

        static int b = 0;

        int c = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox2.Text)
            {
                case "+":
                    textBox4.Text = (double.Parse(textBox1.Text) + double.Parse(textBox3.Text)).ToString();
                    break;
                case "-":
                    textBox4.Text = (double.Parse(textBox1.Text) - double.Parse(textBox3.Text)).ToString();
                    break;
                case "*":
                    textBox4.Text = (double.Parse(textBox1.Text) * double.Parse(textBox3.Text)).ToString();
                    break;
                case "/":
                    if (textBox3.Text == "0")
                    {
                        MessageBox.Show("0으로 나눌수 없습니다.");
                        break;
                    }
                    else
                    {
                        textBox4.Text = (double.Parse(textBox1.Text) / double.Parse(textBox3.Text)).ToString();
                    }
                    break;
            }
            b = 1;

            }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (b == 0) 
            {
                textBox2.Text = "*";
                a = 1;
            }
            else
            {
                textBox2.Text = "*";
                a = 1;
                textBox3.Text = "";
                textBox1.Text = textBox4.Text;
            }
         
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (b == 0)
            {
                textBox2.Text = "-";
                a = 1;
            }
            else
            {
                textBox2.Text = "-";
                a = 1;
                textBox3.Text = "";
                textBox1.Text = textBox4.Text;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (b == 0)
            {
                textBox2.Text = "+";
                a = 1;
            }
            else
            {
                textBox2.Text = "+";
                a = 1;
                textBox3.Text = "";
                textBox1.Text = textBox4.Text;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (b == 0)
            {
                textBox2.Text = "/";
                a = 1;
            }
            else
            {
                textBox2.Text = "/";
                a = 1;
                textBox3.Text = "";
                textBox1.Text = textBox4.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "1";
            }
            else
            {
                textBox3.Text += "1";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "2";
            }
            else
            {
                textBox3.Text += "2";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "0";
            }
            else
            {
                textBox3.Text += "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "3";
            }
            else
            {
                textBox3.Text += "3";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "4";
            }
            else
            {
                textBox3.Text += "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "5";
            }
            else
            {
                textBox3.Text += "5";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "6";
            }
            else
            {
                textBox3.Text += "6";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "7";
            }
            else
            {
                textBox3.Text += "7";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "8";
            }
            else
            {
                textBox3.Text += "8";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "9";
            }
            else
            {
                textBox3.Text += "9";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch (textBox2.Text)
            {
                case "+":
                    textBox4.Text = (double.Parse(textBox1.Text) + double.Parse(textBox3.Text)).ToString();
                    break;
                case "-":
                    textBox4.Text = (double.Parse(textBox1.Text) - double.Parse(textBox3.Text)).ToString();
                    break;
                case "*":
                    textBox4.Text = (double.Parse(textBox1.Text) * double.Parse(textBox3.Text)).ToString();
                    break;
                case "/":
                    if (textBox3.Text == "0")
                    {
                        MessageBox.Show("0으로 나눌수 없습니다.");
                        break;
                    }
                    else
                    {
                        textBox4.Text = (double.Parse(textBox1.Text) / double.Parse(textBox3.Text)).ToString();
                    }
                    break;
            }
            b = 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            a = 0;
            b = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += ".";
            }
            else
            {
                textBox3.Text += ".";
            }
        }
    }
}
