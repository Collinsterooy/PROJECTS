using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wage_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrossPay_Click(object sender, EventArgs e)
        {
            try
            {
                // Declarations
                double hoursWorked, payRate, Result;

                //Get User Input
                hoursWorked = double.Parse(txtHoursWorked.Text);

                payRate = double.Parse(txtHourlyPayRate.Text);

                //Calculations
                Result = hoursWorked * payRate;

                //Output
                MessageBox.Show(Result.ToString("c"));
            }
            catch (Exception)
            {
                MessageBox.Show( "Please enter an integer", "Integer required", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                txtHourlyPayRate.Text = " " ;
                txtHoursWorked.Text = " " ;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
