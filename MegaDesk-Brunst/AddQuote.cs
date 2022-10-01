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

        #region declare variables
        public string customerName = String.Empty;
        int width = 0;
        int depth = 0;
        int numOfDrawers = 0;
        int rushDays = 0;
        Desk.DesktopMaterial material;
        int QuoteTotal = 0;
        #endregion

        public AddQuote()
        {
            InitializeComponent();
        }


        // Validate the width input
        private void WidthInput_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(widthInput.Text, out int WidthInput) == true)
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
        private void DepthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) == false && Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please enter a number");
                e.Handled = true;
                DepthInput.BackColor = Color.DarkRed;
                DepthInput.Focus();
            }
            else
            {
                DepthInput.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void returnHomeQuoteButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Tag = this;
            mainMenu.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // User Input assigned to variables
                customerName = customerNameInput.Text;
                width = int.Parse(widthInput.Text);
                depth = int.Parse(DepthInput.Text);
                numOfDrawers = int.Parse(NumOfDrawersInput.Text);   
                material = (Desk.DesktopMaterial)SurfaceMaterialsSelect.SelectedItem;
                rushDays = int.Parse(rushDaysInput.Text);

                // Create new quote
                DeskQuote NewQuote = new DeskQuote(customerName, DateTime.Now, width, depth, numOfDrawers, material, rushDays);
                QuoteTotal = NewQuote.CalcQuote();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
