using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg266LargeSmall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numA = int.Parse(textBox1.Text);
            int numB = int.Parse(textBox2.Text);
            char smallest = ' ';
            char largest = ' ';

            if (numA > numB) {
                smallest = 'B';
                largest = 'A';
            } 
            else if (numA < numB) {
                smallest = 'A';
                largest = 'B';
            }

            label3.Text = "Value " + largest + " is greater than value " + smallest + ".";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
