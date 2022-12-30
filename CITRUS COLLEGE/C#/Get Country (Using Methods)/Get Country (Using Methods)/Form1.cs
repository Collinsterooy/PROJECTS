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

namespace Get_Country__Using_Methods_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Method Declaration

        private void GetFileName(out string SelectedFile)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                SelectedFile = openFile.FileName;
            }
            else
            {
                SelectedFile = null;
            }
        }

       private void GetCountry(string filename)
        {
            try
            {

                //Declarations
                string counrtyName;

                StreamReader inputfile;

                inputfile = File.OpenText(filename);

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
        private void btnGetCntry_Click(object sender, EventArgs e)
        {
            string filename;

            GetFileName(out filename);
            GetCountry(filename);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
