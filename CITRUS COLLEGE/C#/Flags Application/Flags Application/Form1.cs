using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pctrbFinland_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "Finland";
        }

        private void pctrbFrance_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "France";
        }

        private void pctrbGermany_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "Germany";
        }
    }
}
