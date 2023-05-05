using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg435TicketSalesCS
{
    public partial class GeneralForm : Form
    {
        private Form myParent;
        public GeneralForm(Form prt)
        {
            InitializeComponent();
            myParent = prt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.myParent.Show();
            this.Close();
        }

        decimal decTAXRATE = 0.06m;  //Sales Tax Rate
        private decimal calcTax(decimal cost)
        {
            //Returns the sales tax on ticket sales
            return cost * decTAXRATE;
        }

        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.myParent.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int intNumTickets = 0;
            decimal decTicketCost = 0.0m;
            decimal decSalesTax = 0.0m;
            decimal decTotal = 0.0m;

            intNumTickets = int.Parse(txtNumTickets.Text);
            if (radSectionA.Checked == true) decTicketCost = intNumTickets * 20;
            else if (radSectionB.Checked == true) decTicketCost = intNumTickets * 15;
            else if (radSectionC.Checked == true) decTicketCost = intNumTickets * 10;
            decSalesTax = calcTax(decTicketCost);
            decTotal = decTicketCost + decSalesTax;

            lblTickets.Text = decTicketCost.ToString("$.00");
            lblTax.Text = decSalesTax.ToString("$.00");
            lblTotal.Text = decTotal.ToString("$.00");
        }
    }
}
