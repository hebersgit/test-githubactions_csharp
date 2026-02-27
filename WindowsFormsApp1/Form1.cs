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
                int result = number1 * number2;
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
