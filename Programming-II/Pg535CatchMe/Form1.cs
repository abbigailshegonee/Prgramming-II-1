using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg535CatchMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string[] strCaption = {"Click here", "Try harder!", 
                                       "Try again.", "Not even close", 
                                       "Where are you?", "I'm over here!", 
                                       "Slow, aren't you"};

        private Random rand = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You got me!", "Yippee!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            int intIndex = rand.Next(strCaption.Length);
            button1.Text = strCaption[intIndex];
            button1.Left = rand.Next(this.Width - button1.Width);
            button1.Top = rand.Next(this.Height - button1.Height - 30);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
