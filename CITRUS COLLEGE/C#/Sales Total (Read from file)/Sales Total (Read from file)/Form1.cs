using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sales_Total__Read_from_file_
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
                decimal sales;
                decimal total = 0m;
                StreamReader inputFile;


                //File Input

                inputFile = File.OpenText(@"C:\Users\colli\iCloudDrive\EDUCATION\UNIVERSITY\CITRUS COLLEGE\COMPUTER SCIENCE 111\PROJECT FOLDER\Sales.txt");

                //Calculate
                while (!inputFile.EndOfStream)
                {
                    sales = decimal.Parse(inputFile.ReadLine());
                    total += sales;
                }
                inputFile.Close();

                // Output
                lblResult.Text = total.ToString("C");
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
