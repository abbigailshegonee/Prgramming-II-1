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

namespace Pg334LoanCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radNew.Checked = true;
        }

        const int intMIN_MONTHS = 6;
        const int intMAX_MONTHS = 18;
        const float sngMONTHS_YEAR = 12.0f;

        const double dblNEW_RATE = 0.089;
        const double dblUSED_RATE = 0.095;

        double dblAnnualRate = dblNEW_RATE;

        private void button1_Click(object sender, EventArgs e)
        {
            int intCount = 0;
            int intMonths = 0;
            double dblLoan = 0.0;
            double dblPayment = 0.0;
            double dblInterest = 0.0;
            double dblPrincipal = 0.0;

            try
            {
                intMonths = int.Parse(txtMonths.Text);
                dblLoan = double.Parse(txtCost.Text) -
                    double.Parse(txtDownPayment.Text);
            }
            catch (Exception ex) {
                MessageBox.Show("Please enter numeric values");
                return;
            }

            dblPayment = Financial.Pmt(dblAnnualRate / sngMONTHS_YEAR, intMonths, -dblLoan);
            lstOutput.Items.Clear();

            for (intCount = 1; intCount <= intMonths; intCount++)
            {
                string strOut = string.Empty;
                dblInterest = Financial.IPmt(dblAnnualRate / sngMONTHS_YEAR,
                    intCount, intMonths, -dblLoan);
                dblPrincipal = Financial.PPmt(dblAnnualRate / sngMONTHS_YEAR,
                    intCount, intMonths, -dblLoan);
                strOut += "Month: " + intCount;
                strOut += " Payment: " + dblPayment.ToString("$.00");
                strOut += " Interest: " + dblInterest.ToString("$.00");
                strOut += " Principal: " + dblPrincipal.ToString("$.00");

                lstOutput.Items.Add(strOut);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCost.CausesValidation = false;
            txtDownPayment.CausesValidation = false;
            txtMonths.CausesValidation = false;
            radNew.Checked = true;
            dblAnnualRate = dblNEW_RATE;
            lblAnnInt.Text = dblNEW_RATE.ToString(".00%");
            txtCost.Clear();
            txtDownPayment.Clear();
            txtMonths.Clear();
            lstOutput.Items.Clear();
            txtCost.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCost.CausesValidation = false;
            txtDownPayment.CausesValidation = false;
            txtMonths.CausesValidation = false;
            Application.Exit();

        }

        private void radNew_CheckedChanged(object sender, EventArgs e)
        {
            if (radNew.Checked == true)
            {
                dblAnnualRate = dblNEW_RATE;
                lblAnnInt.Text = dblNEW_RATE.ToString(".00%");
            }
        }

        private void radUsed_CheckedChanged(object sender, EventArgs e)
        {
            if (radUsed.Checked == true)
            {
                dblAnnualRate = dblUSED_RATE;
                lblAnnInt.Text = dblUSED_RATE.ToString(".00%");
            }
        }

        private void txtCost_Validating(object sender, CancelEventArgs e)
        {
            double _x = 0;
            if (!double.TryParse(txtCost.Text, out _x))
            {
                MessageBox.Show("Cost must be a number.", "Invalid Vehcicle Cost");
                txtCost.SelectAll();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void txtDownPayment_Validating(object sender, CancelEventArgs e)
        {
            double _x = 0;
            if (!double.TryParse(txtDownPayment.Text, out _x))
            {
                MessageBox.Show("Down payment must be a number.", "Invalid Down Payment");
                txtDownPayment.SelectAll();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void txtMonths_Validating(object sender, CancelEventArgs e)
        {
            double _x = 0;
            if (!double.TryParse(txtMonths.Text, out _x))
            {
                MessageBox.Show("Months must be a number.", "Error");
                txtMonths.SelectAll();
                e.Cancel = true;
            }
            else
            {
                int intMonths = int.Parse(txtMonths.Text);
                if (intMonths < intMIN_MONTHS || intMonths > intMAX_MONTHS)
                {
                    MessageBox.Show("Months must be in the range" +
                        intMIN_MONTHS + " - " + intMAX_MONTHS, "Error");
                    txtMonths.SelectAll();
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }
    }
}