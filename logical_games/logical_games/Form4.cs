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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            secondPlayerEnter.Enabled = false;
        }

        private void enterMainWordButton_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Owner = this;
            form5.Show();
        }

        private void writeWordButton_Click(object sender, EventArgs e)
        {
            if(firstPlayerEnter.Enabled == true)
            {
                if(firstPlayerEnter.Text.Length != 0)
                {
                    char[] mainWordLetters = wordToArray(mainWordTextBox.Text);
                    char[] firstPlayerWordLetters = wordToArray(firstPlayerEnter.Text);
                    bool isSubword = !firstPlayerWordLetters.Except(mainWordLetters).Any();

                    if (isSubword == true)
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
                    char[] mainWordLetters = wordToArray(mainWordTextBox.Text);
                    char[] secondPlayerWordLetters = wordToArray(secondPlayerEnter.Text);
                    bool isSubword = !secondPlayerWordLetters.Except(mainWordLetters).Any();

                    if (isSubword == true)
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

        private void changePlayerButton_Click(object sender, EventArgs e)
        {
            if(firstPlayerEnter.Enabled == true)
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
            MessageBox.Show("Введите длинное слово. Каждый игрок записывает как можно больше слов, которые получится составить из букв введённого слова. Для передачи хода другому игроку нажми на кнопку Передать ход");
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
