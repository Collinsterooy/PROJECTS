using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericToWord
{
    public partial class NumericToWord : Form
    {
        public NumericToWord()
        {
            InitializeComponent();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            lblFive.Text = "Five";
            lblFive.Visible = true;
            lblNine.Visible = false;
            lblThree.Visible = false;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            lblNine.Text = "Nine";
            lblNine.Visible = true;
            lblFive.Visible = false;
            lblThree.Visible=false;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            lblThree.Text = "Three";
            lblThree.Visible = true;
            lblFive.Visible = false;
            lblNine.Visible = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
