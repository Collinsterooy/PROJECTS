using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus_Application
{
    public partial class Form1 : Form
    {
        private const decimal CONTRIB_RATE = 0.05m;
        public Form1()
        {
            InitializeComponent();
        }

        private bool InputValid (ref decimal pay, ref decimal Bonus)
        {
            bool output = false;
            if (decimal.TryParse(txtGrossPay.Text, out pay))
            {
                if (decimal.TryParse(txtBonus.Text, out Bonus))
                {
                    output = true;
                }
                else
                {
                    MessageBox.Show("Bonus amount is invalid.");
                }
            }
            else
            {
                MessageBox.Show("Gross Pay amount is invalid");
            }
            return output;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal grossPay = 0m, bonus = 0m, contributions = 0m;

            if (InputValid(ref grossPay, ref bonus))
            {
                contributions = (grossPay + bonus) * CONTRIB_RATE;
                lblResult.Text = contributions.ToString("c");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
