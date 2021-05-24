using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logical_games
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 main = this.Owner as Form6;
            main.mainLettersTextBox.Text = enterLettersTextBox.Text;
            main.enterMainLettersButton.Enabled = false;
            Close();
        }

        private void mainLettersTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[а-я]").Success)
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',')
            {
                e.Handled = false;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }
    }
}
