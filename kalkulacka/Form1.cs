using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulacka
{
    public partial class displayHistory : Form
    {
        string op = "";
        double number1 =0;
        double number2 =0;
        double result = 0;
        public displayHistory()
        {
            InitializeComponent();
        }

        private void button_Number_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + ((Button)sender).Text;
        }

        private void button_Operator_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(display.Text);
            op = ((Button)sender).Text;

            historyDisplay.Text = number1 + op;
            display.Clear();
        }

        private void buttonEqueal_Click(object sender, EventArgs e)
        {
            number2 = int.Parse(display.Text);
            historyDisplay.Text += number2;

            if(op == "+")
            {
                result = number1 + number2;
            } else if(op == "-")
            {
                result = number1 - number2;
            }
            else if (op == "*")
            {
                result = number1 * number2;
            }
            else if (op == "/")
            {
                if (number2 == 0) {
                    result = 0;
                }
                else
                {
                    result = number1 / number2;
                }
            }

            display.Text = result.ToString();
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            result = 0;
            number1 = 0;
            number2 = 0;
            op = "";
            display.Clear();
        }
    }
}
