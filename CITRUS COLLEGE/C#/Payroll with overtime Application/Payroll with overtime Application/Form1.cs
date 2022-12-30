using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_overtime_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcGrossPay_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaration

                // Constants
                const decimal BASE_HOURS = 40m, OVERTIME_RATE = 1.5m;

                //local Variables
                decimal hoursWorked, hourlyRate, basePay, overtimePay, overtimeHours, grossPay;


                //User Input
                hoursWorked = decimal.Parse(txtHoursWorked.Text);
                hourlyRate = decimal.Parse(txtHourlyRate.Text);

                //Calculations
                
                if (hoursWorked > BASE_HOURS)
                {
                    basePay = BASE_HOURS * hourlyRate;
                    overtimeHours = hoursWorked - BASE_HOURS;
                    overtimePay = overtimeHours * (hourlyRate * OVERTIME_RATE);
                    grossPay = overtimePay + basePay;
                }
                else
                {
                    grossPay = hoursWorked * hourlyRate;
                }

                //Output
                lblResult.Text = grossPay.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHoursWorked.Text = "";
            txtHourlyRate.Text = "";
            lblResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
