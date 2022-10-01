using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Brunst
{
    public partial class AddQuote : Form
    {
        public event System.ComponentModel.CancelEventHandler Validating;

        public AddQuote()
        {
            InitializeComponent();
        }


        // Validate the width input
        private void widthInput_Validating(object sender, CancelEventArgs e)
        {
            if(int.TryParse(widthInput.Text, out int WidthInput) == true)
            {
                if (WidthInput < Desk.MIN_WIDTH || WidthInput > Desk.MAX_WIDTH)
                {
                    MessageBox.Show($"Please enter a width from {Desk.MIN_WIDTH} to {Desk.MAX_WIDTH}");
                    widthInput.Text = String.Empty;
                    widthInput.BackColor = Color.Red;
                    widthInput.Focus();
                }
                else
                {
                    widthInput.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            else if (int.TryParse(widthInput.Text, out WidthInput) == false && widthInput.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                widthInput.Text = String.Empty;
                widthInput.BackColor = Color.Red;
                widthInput.Focus();
            }
            else
            {
                widthInput.BackColor = System.Drawing.SystemColors.Window;
            }

        }

        /*        private void widthInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
                {
                    string errorMsg;
                    if (!ValidWidth(widthInput.Text, out errorMsg))
                    {
                        e.Cancel = true;
                        widthInput.Select(0, 2);
                    }
                }

                private void widthInput_Validated(object sender, System.EventArgs e)
                {
                }

                public bool ValidWidth(decimal width, out string errorMessage)
                {
                    if (widthInput.Value < 24)
                    {
                        errorMessage = "Width of desk must be greater than 24 inches";
                        return false;
                    }
                    if (widthInput.Value > 96)
                    {
                        errorMessage = "Width of desk must be less than 96 inches.";
                        return false;
                    }
                    errorMessage = "Width must be between 24 and 96 inches.";
                    return false;
                }*/

        private void returnHomeQuoteButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Tag = this;
            mainMenu.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
