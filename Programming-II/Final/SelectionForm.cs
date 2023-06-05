using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
            //Caeser Cipher
            //Morse Code
            //Binary Code
            //A1Z26
            //leet / l337
            //Standard Galactic
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string codetype = "";

            if (comboBox1.Text == "Caeser Cipher" || comboBox1.Text == "Morse Code" || comboBox1.Text == "leet / l337") {
                codetype = comboBox1.Text;
                MainForm frm = new MainForm(this, codetype);
                frm.Show();
                this.Hide();
            } 
            else MessageBox.Show("Please select a listed option", "Error");
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {

        }

    }
}
