using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Declarations
                double OriginalPrice, discountPercentage, discountPrice, salesPrice;

                //Get User Imput
                OriginalPrice = double.Parse(txtPriceOriginal.Text);
                discountPercentage = double.Parse(txtSalesPercentage.Text);

                //Calculate
                discountPrice = (discountPercentage / 100) * OriginalPrice;
                salesPrice = OriginalPrice - discountPrice;

                //Output
                lblResult.Text = salesPrice.ToString("c");
            }
            catch
            {
                MessageBox.Show("Enter a number");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
