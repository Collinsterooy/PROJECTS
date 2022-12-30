using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Balance__While_Loop_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Declarations
            const decimal INTEREST_RATE = 0.005m;

            decimal balance;
            int months;
            int count = 1;

            //User input and Validation
            if (decimal.TryParse(txtStartBalnce.Text, out balance))
            {
                if (int.TryParse(txtMonth.Text, out months))
                {
                    while (count <= months)
                    {
                        balance = balance + (balance * INTEREST_RATE);

                        lstbxDetails.Items.Add("The ending balance for month " + count + " is " + balance.ToString("c"));
                        count++;
                    }
                    lblResult.Text = balance.ToString("c");
                }
                else
                {
                    MessageBox.Show("invalid value for months");
                }    
            }
            else
            {
                MessageBox.Show("invalid value for starting balance");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStartBalnce.Text = "";
            txtMonth.Text = "";
            lblResult.Text = "";
            lstbxDetails.Items.Clear();
            txtStartBalnce.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
