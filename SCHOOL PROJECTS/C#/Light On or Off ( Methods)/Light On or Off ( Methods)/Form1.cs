using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Light_On_or_Off___Methods_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Method Declaraion

        private void LightOff()
        {
            pctBxOff.Visible = true;
            pctBxON.Visible = false;
            lblResult.Text = "OFF";
        }

        private void LightOn()
        {
            pctBxOff.Visible = false;
            pctBxON.Visible = true;
            lblResult.Text = "ON";
        }
        private void btnSwitchLight_Click(object sender, EventArgs e)
        {
            if (pctBxOff.Visible == true)
            {
                LightOn();
            }
            else
            {
                LightOff();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
