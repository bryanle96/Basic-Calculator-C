/* Created by Bryan Le 5.11.17
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLeHW5._1
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1 ( )
        {
            InitializeComponent();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            textBox1.AppendText("0");
            input += "0";
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            textBox1.AppendText("1");
            input += "1";
        }

        private void button3_Click ( object sender, EventArgs e )
        {
            textBox1.AppendText("2");
            input += "2";
        }

        private void button4_Click ( object sender, EventArgs e )
        {
            textBox1.AppendText("3");
            input += "3";
        }

        private void button5_Click ( object sender, EventArgs e )
        {
            textBox1.AppendText("4");
            input += "4";
        }

        private void button6_Click ( object sender, EventArgs e )
        {
            textBox1.AppendText(".");
            input += ".";
        }

        private void button12_Click ( object sender, EventArgs e )
        {
            //Clear Button
            textBox1.Clear();
            textBox1.Focus();

            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;

        }
       

        private void button7_Click ( object sender, EventArgs e )
        {
            //Addition Button
            operand1 = input;
            operation = '+';
            input = string.Empty;
            textBox1.Clear();
            
        }

        private void button8_Click ( object sender, EventArgs e )
        {
            //Subtraction Button
            operand1 = input;
            operation = '-';
            input = string.Empty;
            textBox1.Clear();
        }

        private void button9_Click ( object sender, EventArgs e )
        {

            //Multiply Button
            operand1 = input;
            operation = '*';
            input = string.Empty;
            textBox1.Clear();

        }

        private void button10_Click ( object sender, EventArgs e )
        {
            //Divide Button
            operand1 = input;
            operation = '/';
            input = string.Empty;
            textBox1.Clear();
           
        }

        private void button11_Click ( object sender, EventArgs e )
        {

            //Equals Button
            operand2 = input;
            double number1, number2;
            double.TryParse(operand1, out number1);
            double.TryParse(operand2, out number2);

            if (operation == '+')
            {
                result = number1 + number2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = number1 - number2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = number1 * number2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (number2 != 0)
                {
                    result = number1 / number2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "Error!";
                }
            }
         
        }

    }
}
