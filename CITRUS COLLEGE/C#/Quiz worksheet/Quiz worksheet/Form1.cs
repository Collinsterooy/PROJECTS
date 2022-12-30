using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_worksheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click_Click(object sender, EventArgs e)
        {
            int finalValue;
            int row = 3;
            int col = 4;

            finalValue = myFunc(row, col);
            llblResult.Text = Convert.ToString(finalValue);
        }
        int myFunc(int rowPar, int colPar)
        {
            int counter = 1;
            int tempCol;

            tempCol = colPar;

            while (rowPar >= 0)
            {
                while (colPar >= 0)
                {
                    counter = counter + 1;
                    colPar = colPar - 1;
                }
                colPar = tempCol;
                rowPar = rowPar - 1;
            }

            return counter;

        }
    }
}
               

            

