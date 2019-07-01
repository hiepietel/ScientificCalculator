using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        string operation = "";
        decimal num1;
        decimal num2;
        decimal ans;
        public Form1()
        {
            ans = 0;
            
            num1 = 0;
            num2 = 0;
            InitializeComponent();
            textBox1.Text = "0";
        }
        private void Input(string a)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = a;
            }
            else
                textBox1.Text += a;
        }

        private void Btn_1_Click_1(object sender, EventArgs e)
        {
            Input("1");
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Input("2");
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            Input("3");
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            Input("4");
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            Input("5");
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            Input("6");
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            Input("7");
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            Input("8");
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            Input("9");
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            Input("0");
        }

        private void Btn_plus_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(textBox1.Text);
            operation = "+";
            textBox1.Text = "0";
        }

        private void Btn_minus_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(textBox1.Text);
            operation = "-";
            textBox1.Text = "0";
        }

        private void Btn_multiply_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(textBox1.Text);
            operation = "*";
            textBox1.Text = "0";
        }

        private void Btn_divide_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(textBox1.Text);
            operation = "/";
            textBox1.Text = "0";
        }

        private void Btn_equal_Click(object sender, EventArgs e)
        {
            num2 = Decimal.Parse(textBox1.Text);

            switch (operation) {
                case "+":
                    textBox1.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    textBox1.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    textBox1.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    textBox1.Text = (num1 / num2).ToString();
                    break;
                case "%":
                    textBox1.Text = (num1 % num2).ToString();
                    break;
            
            }
            ans = Decimal.Parse(textBox1.Text);
            history_textBox.Text += num1.ToString() + operation + num2.ToString() + "=" + textBox1.Text +"\r\n";
            num2 = 0;
            num1 = 0;
           // textBox1.Text = "0";
            
        }

        private void Btn_sin_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textBox1.Text);
            textBox1.Text = (Math.Sin(temp)).ToString();
            history_textBox.Text += "Sin(" + temp.ToString() + ") = " + textBox1.Text +"\r\n";
        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            else
                textBox1.Text = "0";
            //string temp = textBox1.Text;
            //int length = temp.Length - 1;
            //textBox1.Text = temp.Remove(0,length);
        }

        private void Ac_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
        }

        private void Ans_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = ans.ToString();
        }

        private void Dot_btn_Click(object sender, EventArgs e)
        {
            Input(",");
        }
    }
}
