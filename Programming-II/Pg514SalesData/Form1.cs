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

namespace Pg514SalesData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool GetSalesData(ref decimal[] decSales) {
            decimal[] decSalesData;
            int intNumDays = 0;
            int intCount;
            bool blnSuccess = false;

            string strNumDays = Interaction.InputBox("For how many days " + "do you have sales?");
            
            if (!int.TryParse(strNumDays, out intNumDays)) {
                MessageBox.Show("You enter a non-numeric value", "Error");
                return false;
            }

            if (intNumDays > 0)
            {
                decSalesData = new decimal[intNumDays];

                for (intCount = 0; intCount < intNumDays; intCount++)
                {
                    bool blnValid = false;
                    while (blnValid != true) {
                        blnValid = decimal.TryParse(
                                        Interaction.InputBox("Enter the sales " +
                                        "for day " + (intCount + 1).ToString()),
                                        out decSalesData[intCount]);
                        if (blnValid != true) {
                            MessageBox.Show("Please enter a valid number");
                        }
                    }
                }
                decSales = decSalesData;
                blnSuccess = true;
            } else {
                MessageBox.Show("You must enter at least " + "one day of sales");
            }
            return blnSuccess;
        }

        private decimal GetTotal(decimal[] decValues) {
            decimal decTotal = 0;
            int intCount;

            for (intCount = 0; intCount < decValues.Length; intCount++) {
                decTotal += decValues[intCount];
            }
            return decTotal;
        }

        private decimal GetAverage(decimal[] decValues) {
            return GetTotal(decValues) / decValues.Length;
        }

        private decimal GetHighest(decimal[] decValues) {
            int intCount;
            decimal decHighest = decValues[0];

            for (intCount = 1; intCount < decValues.Length; intCount++) {
                if (decValues[intCount] > decHighest) {
                    decHighest = decValues[intCount];
                }
            }
            return decHighest;
        }

        private decimal GetLowest(decimal[] decValues) {
            int intCount;
            decimal decLowest = decValues[0];
            for (intCount = 1; intCount < decValues.Length; intCount++) {
                if (decValues[intCount] < decLowest) {
                    decLowest = decValues[intCount];
                }
            }
            return decLowest;

        }

        private void btnCalcPay_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "$0.00";
            lblAverage.Text = "$0.00";
            lblHighest.Text = "$0.00";
            lblLowest.Text = "$0.00";

            decimal[] decSales = null;
            decimal decTotal;
            decimal decAverage;
            decimal decHighest;
            decimal decLowest;

            if (GetSalesData(ref decSales)) {
                decTotal = GetTotal(decSales);
                decAverage = GetAverage(decSales);
                decHighest = GetHighest(decSales);
                decLowest = GetLowest(decSales);

                lblTotal.Text = decTotal.ToString("$.00");
                lblAverage.Text = decAverage.ToString("$.00");
                lblHighest.Text = decHighest.ToString("$.00");
                lblLowest.Text = decLowest.ToString("$.00");
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
