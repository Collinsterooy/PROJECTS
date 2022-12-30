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

namespace Get_Country__Read_to_End_of_File_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetCntry_Click(object sender, EventArgs e)
        {
            try
            {

                //Declarations
                string counrtyName;

                StreamReader inputfile;

                inputfile = File.OpenText(@"C:\Users\colli\iCloudDrive\EDUCATION\UNIVERSITY\CITRUS COLLEGE\COMPUTER SCIENCE 111\PROJECT FOLDER\Countries.txt");

                lstbxCountries.Items.Clear();

                while (!inputfile.EndOfStream)
                {
                    counrtyName = inputfile.ReadLine();

                    lstbxCountries.Items.Add(counrtyName);
                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();ii
        }
    }
}
