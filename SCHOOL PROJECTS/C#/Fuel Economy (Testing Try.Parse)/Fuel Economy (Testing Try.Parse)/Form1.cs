using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy__Testing_Try.Parse_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcMPG_Click(object sender, EventArgs e)
        {
            //Declarations
            double miles, gallon, mpg;

            //User input & Validation
            if (double.TryParse(txtMilesDriven.Text, out miles))
            {
                if (double.TryParse(txtGasUsed.Text, out gallon))
                {
                    mpg = miles / gallon;
                    lblResult.Text = mpg.ToString("n1");
                }
                else
                {
                    MessageBox.Show("Invalid input for gallon.");
                }
            }
            else
            {
                MessageBox.Show("invalid input for miles.");
            }    
         
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
