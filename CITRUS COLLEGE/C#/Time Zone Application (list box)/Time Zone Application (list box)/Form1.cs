using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone_Application__list_box_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Declarations
            string city;

            if (ltbxCityList.SelectedIndex != -1)
            {
                //User input
                city = ltbxCityList.SelectedItem.ToString();

                switch (city)
                {
                    case "Honolulu":
                        lblResult.Text = "Hawaii - Aleutian";
                        break;

                    case "San Francisco":
                        lblResult.Text = "Pacific";
                        break;

                    case "Denver":
                        lblResult.Text = "Mountain";
                        break;

                    case "Minneapolis":
                        lblResult.Text = "Central";
                        break;

                    case "New York":
                        lblResult.Text = "Eastern";
                        break;

                } 
                
                
            }
            else
            {
                MessageBox.Show("Select a City");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
