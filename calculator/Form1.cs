using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace calculator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }
        string operation;
        double input1, input2, result;

        private void num0_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "0";
            else { textBox.Text += 0; }

        }
        private void num1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "1";
            else
            {
                textBox.Text += "1";
            }
            
        }
        private void num2_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "2";
            else
            {
                textBox.Text += "2";
            }
        }
        private void num3_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "3";
            else
            {
                textBox.Text += "3";
            }
        }
        private void num4_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "4";
            else
            {
                textBox.Text += "4";
            }
        }
        private void num5_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "5";
            else
            {
                textBox.Text += "5";
            }
        }
        private void num6_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "6";
            else
            {
                textBox.Text += "6";
            }
        }
        private void num7_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "7";
            else
            {
                textBox.Text += "7";
            }
        }
        private void num8_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "8";
            else
            {
                textBox.Text += "8";
            }
        }
        private void num9_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "9";
            else
            {
                textBox.Text += "9";
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            textBox.Text = "0";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            operation = "+";
            input1 = double.Parse(textBox.Text);
            textBox.Clear();
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            operation = "-";
            input1 = double.Parse(textBox.Text);
            textBox.Clear();
        }

        private void mul_Btn_Click(object sender, EventArgs e)
        {
            operation = "*";
            input1 = double.Parse(textBox.Text);
            textBox.Clear();
        }

        private void div_Btn_Click(object sender, EventArgs e)
        {
            operation = "/";
            input1 = double.Parse(textBox.Text);
            textBox.Clear();
        }
        private void mod_btn_Click(object sender, EventArgs e)
        {
            operation = "%";
            input1 = double.Parse(textBox.Text);
            textBox.Clear();
        }

        private void equal_btn_Click(object sender, EventArgs e)
        {
            input2 = double.Parse(textBox.Text);
            switch (operation)
            {
                case "+":
                    result = input1 + input2;
                    break;
                case "-":
                    result = input1 - input2;
                    break;
                case "*":
                    result = input1 * input2;
                    break;
                case "/":
                    if (input2 != 0)
                        result = input1 / input2;
                    else
                    {
                        textBox.Text = ("Cannot divide by zero!");
                        return;
                    }
                    break;
                case "%":
                    result = input1 % input2;
                    break;
            }
            textBox.Text = result.ToString();
        }
    }
}
