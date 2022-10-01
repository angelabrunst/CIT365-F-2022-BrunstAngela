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

        public AddQuote()
        {
            InitializeComponent();
        }

        private void returnHomeQuoteButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Tag = this;
            mainMenu.Show();
            Close();
        }
    }
}
