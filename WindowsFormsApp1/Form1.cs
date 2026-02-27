using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (int.TryParse(textBox1.Text, out int number1) && int.TryParse(textBox2.Text, out int number2))
            {
                int result;
                string operation = comboBox1.SelectedItem?.ToString();

                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 != 0)
                        {
                            result = number1 / number2;
                        }
                        else
                        {
                            errorProvider1.SetError(textBox2, "Divisor cannot be zero.");
                            return;
                        }
                        break;
                    default:
                        errorProvider1.SetError(comboBox1, "Please select an operation.");
                        return;
                }

                textBox3.Text = result.ToString();
            }
            else
            {
                errorProvider1.SetError(textBox1, "Please enter valid integers.");
                errorProvider1.SetError(textBox2, "Please enter valid integers.");
            }
        }
    }
}
