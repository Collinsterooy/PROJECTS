using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Validation_Applicication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Methods Delcaration

        private int NumberOfUpperCase (string str)
        {
            int upperCase = 0;

            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                    {
                    upperCase++;
                }

                
            }
            return upperCase;

        }

        private int NumberOfLowerCase (string str)
        {
            int lowerCase = 0;

            foreach (char ch in str)
            {
                if (char.IsLower(ch))
                {
                    lowerCase++;
                }


            }
            return lowerCase;

        }

        private int NumberofDigits(string str)
        {
            int digits = 0;

            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    digits++;
                }

            }
            return digits;
        }

        // Password Validation & Output
        private void btnPaswrdChck_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8;

            //User Input
            string password = txtPassword.Text;


            if (password.Length >= MIN_LENGTH &&
                NumberOfUpperCase(password) >= 1
                && NumberOfLowerCase(password) >= 1
                && NumberofDigits(password) >= 1)
            {
                MessageBox.Show("Password is valid");
            }
            else
            {
                MessageBox.Show("Password does not meet the requirments.");

            }
            



          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
