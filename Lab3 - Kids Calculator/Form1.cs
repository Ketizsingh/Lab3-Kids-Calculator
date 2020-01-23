using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3___Kids_Calculator
{
    public partial class Form1 : Form
    {
        Random rand = new Random(); //to create random numbers

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = rand.Next(1, 10);
            int num2 = rand.Next(1, 10);

            ValueBox1.Text = num1.ToString();
            ValueBox2.Text = num2.ToString();

        }

        private void AdditionButton_CheckedChanged(object sender, EventArgs e)
        {
            operatorLabel.Text = "+";
        }

        private void SubtractionButton_CheckedChanged(object sender, EventArgs e)
        {
            operatorLabel.Text = "-";
        }

        private void MultiplicationButton_CheckedChanged(object sender, EventArgs e)
        {
            operatorLabel.Text = "*";
        }

        private void DivisionButton_CheckedChanged(object sender, EventArgs e)
        {
            operatorLabel.Text = "/";
        }

        private void ValueBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValueBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValueBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {

            if (AdditionButton.Checked == true)
            {

                int value1 = int.TryParse(ValueBox1.Text, out value1) ? value1 : 1;
                int value2 = int.TryParse(ValueBox2.Text, out value2) ? value2 : 1;
                int value3 = int.TryParse(ValueBox3.Text, out value3) ? value3 : 1;

                int result = value1 + value2;

                if (value3 == result)
                {
                    ResultLabel.Text = "Correct :)";
                }
                else
                {
                    ResultLabel.Text = "Incorrect :( - Right answer was " + result;
                }

            }


            if (SubtractionButton.Checked == true)
            {

                int value1 = int.TryParse(ValueBox1.Text, out value1) ? value1 : 1;
                int value2 = int.TryParse(ValueBox2.Text, out value2) ? value2 : 1;
                int value3 = int.TryParse(ValueBox3.Text, out value3) ? value3 : 1;

                int result = value1 - value2;

                if (value3 == result)
                {
                    ResultLabel.Text = "Correct :)";
                }
                else
                {
                    ResultLabel.Text = "Incorrect :( - Right answer was " + result;
                }

            }


            if (MultiplicationButton.Checked == true)
            {

                int value1 = int.TryParse(ValueBox1.Text, out value1) ? value1 : 1;
                int value2 = int.TryParse(ValueBox2.Text, out value2) ? value2 : 1;
                int value3 = int.TryParse(ValueBox3.Text, out value3) ? value3 : 1;

                int result = value1 * value2;

                if (value3 == result)
                {
                    ResultLabel.Text = "Correct :)";
                }
                else
                {
                    ResultLabel.Text = "Incorrect :( - Right answer was " + result;
                }

            }


            if (DivisionButton.Checked == true)
            {

                int value1 = int.TryParse(ValueBox1.Text, out value1) ? value1 : 1;
                int value2 = int.TryParse(ValueBox2.Text, out value2) ? value2 : 1;
                int value3 = int.TryParse(ValueBox3.Text, out value3) ? value3 : 1;

                int result = value1 / value2;

                if (value3 == result)
                {
                    ResultLabel.Text = "Correct :)";
                }
                else
                {
                    ResultLabel.Text = "Incorrect :( - Right answer was " + result;
                }

            }




        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void operatorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
