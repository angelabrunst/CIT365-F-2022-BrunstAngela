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
        public event System.Windows.Forms.KeyPressEventHandler KeyPress;

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

        // Validate the depth input


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
