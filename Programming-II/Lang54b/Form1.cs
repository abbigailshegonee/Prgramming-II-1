using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lang54b
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
            int numC = int.Parse(textBox3.Text);
            int numD = int.Parse(textBox4.Text);
            int sum = numA + numB + numC + numD;
            double average = Math.Round(sum / 4.0, 2);
            label5.Text = "The sum of the four numbers is " + sum.ToString();
            label6.Text = "The average of the four numbers is " + average.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label5.Text = "The sum of the four numbers is ____";
            label6.Text = "The average of the four numbers is ____";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
