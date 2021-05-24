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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            secondPlayerEnter.Enabled = false;
        }

        private void enterMainLettersButton_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Owner = this;
            form7.Show();
        }

        private void changePlayerButton_Click(object sender, EventArgs e)
        {
            if (firstPlayerEnter.Enabled == true)
            {
                firstPlayerEnter.Enabled = false;
                secondPlayerEnter.Enabled = true;
            }
            else
            {
                secondPlayerEnter.Enabled = false;
                firstPlayerEnter.Enabled = true;
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите несколько букв через запятую. Необходимо придумать как можно больше слов, в которых встречаются эти буквы. Буквы можно менять местами. Для передачи хода другому игроку нажмите кнопку Передать ход");
        }

        private void writeWordButton_Click(object sender, EventArgs e)
        {
            if (firstPlayerEnter.Enabled == true)
            {
                if (firstPlayerEnter.Text.Length != 0)
                {
                    char[] mainLetters = mainLettersTextBox.Text.ToString().Trim().Replace(",", string.Empty).ToCharArray();
                    char[] firstPlayerWordLetters = wordToArray(firstPlayerEnter.Text);
                    bool containsMainLetters = !mainLetters.Except(firstPlayerWordLetters).Any();

                    if (containsMainLetters == true)
                    {
                        firstPlayerWords.Text += firstPlayerEnter.Text + "\n";
                    }
                    else
                    {
                        MessageBox.Show("Введите другое слово!");
                    }
                    firstPlayerEnter.Text = "";
                }
            }
            else
            {
                if (secondPlayerEnter.Text.Length != 0)
                {
                    char[] mainLetters = mainLettersTextBox.Text.ToString().Trim().Replace(",", string.Empty).ToCharArray();
                    char[] secondPlayerWordLetters = wordToArray(secondPlayerEnter.Text);
                    bool containsMainLetters = !mainLetters.Except(secondPlayerWordLetters).Any();

                    if (containsMainLetters == true)
                    {
                        secondPlayerWords.Text += secondPlayerEnter.Text + "\n";
                    }
                    else
                    {
                        MessageBox.Show("Введите другое слово!");
                    }
                    secondPlayerEnter.Text = "";
                }
            }
        }

        private char[] wordToArray(string s)
        {
            return s.ToCharArray();
        }

        private void firstPlayerEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[а-я]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        private void secondPlayerEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[а-я]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }
    }
}
