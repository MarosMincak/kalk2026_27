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
        double number1 = 0;
        double number2 = 0;
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
            /* TODO
            op = ((Button)sender).Text;
            if (display.Text.Contains("."))
                {
                display.Text = display.Text.Replace(op, "");
                number1 = double.Parse(display.Text.Replace(op, ""));
                
                }
            */
            try
            {

                number1 = double.Parse(display.Text);

                op = ((Button)sender).Text;
         
                historyDisplay.Text = number1 + op;
                display.Clear();
            }
            catch(Exception err) { 
                Console.WriteLine(err.Message);
            }
        }

        private void buttonEqueal_Click(object sender, EventArgs e)
        {
            number2 = double.Parse(display.Text);
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

            display.Clear();
        }

        private void displayHistory_Load(object sender, EventArgs e)
        {

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            
            string text = display.Text;
            if (display.Text.Length > 0)
            {
                text = text.Remove(text.Length - 1);
            }
            display.Text = text;
        }
        // 3,45+3,85 = 6,0 / 1,3 = 7,3
        private void buttonDot_Click(object sender, EventArgs e)
        {
            display.Text += ".";
        }
    }
}
