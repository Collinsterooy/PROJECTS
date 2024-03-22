using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards_Project__Methods_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Method Declaration
        private void showCard(string card)
        {
            switch (card)
            {
                case "Ace of Spades":
                    showAceOfspades();
                    break;

                case "10 of Hearts":
                    showTenOfhearts();
                    break;

                case "King of Clubs":
                    showKingsOfclubs();
                    break;  
            }
        }

        private void showAceOfspades()
        {
            pctBxAceOfspades.Visible = true;
            pctBx10ofHearts.Visible = false;
            pctBxKingOfclubs.Visible = false;
        }
        private void showTenOfhearts()
        {
            pctBxAceOfspades.Visible = false;
            pctBx10ofHearts.Visible = true;
            pctBxKingOfclubs.Visible = false;
        }
        private void showKingsOfclubs()
        {
            pctBxAceOfspades.Visible = false;
            pctBx10ofHearts.Visible = false;
            pctBxKingOfclubs.Visible = true;
        }
        private void btnShowCards_Click(object sender, EventArgs e)
        {
            if (lstBxCards.SelectedIndex != -1)
            {
                showCard(lstBxCards.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a card from the listbox");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
