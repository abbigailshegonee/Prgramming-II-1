using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pg347Sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userNum = 0;
            int total = 0;
            int count = 0;
            try {
                userNum = int.Parse(Interaction.InputBox("Enter positive integer value.", "Input needed"));
                count = userNum;
            }
            catch{
                userNum = 0;
            }

            if (userNum < 0) {
                MessageBox.Show("Invalid : must enter a positive integer", "Error");
            }
            else
            {
                while (count != 0)
                {
                    total += count;
                    count -= 1;
                }
                MessageBox.Show("The sum of the numbers 1 though " + userNum + " is " + total, "Sum of Numbers");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
