using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports_and_Ages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Declarations
            string sport = " ";
            string ageGroup = " ";
            string userName = " ";
            string output = " ";

            //Get user Input
            userName = txtUserNum.Text;

            //Calculations
            if (rdbBaseball.Checked == true)
                sport = "Baseball";
            else if (rdbFootball.Checked == true)
                sport = "Football";
            else if (rdbSoccer.Checked == true)
                sport = "Soccer";
            else if (rdbVolleyball.Checked == true)
                sport = "Volleyball";

            if (rdb10U.Checked == true)
                ageGroup = "10 years old";
            else if (rdb11U.Checked == true)
                ageGroup = "11 years old";
            else if (rdb12U.Checked == true)
                ageGroup = "12 years old";
            else if (rdb13U.Checked == true)
                ageGroup = "13 years old";

            //Output
            output = userName + " is " + ageGroup + " and plays " + sport + ".";
            lblOutput.Text = output;
        }
    }
}
