﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //declarations
            string name = "";
                //get user input
                name = txtName.Text;
            //calculation(s)
            name = "Hello " + name;
                //output
                lblResult.Text = name;
                
            
        }
    }
}
