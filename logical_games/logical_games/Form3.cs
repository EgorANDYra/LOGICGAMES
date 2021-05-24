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
    public partial class Form3 : Form
    {
        private static int number;
        private static int inputNumber;
        private static int cows;
        private static int bulls;
        private static StringBuilder result;
        public Form3()
        {
            InitializeComponent();
            number = generateNumber();
        }

        private void numInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[0-9]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        private int generateNumber()
        {
            int[] digits = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int buf, j, i, p = 1000, res = 0;
            Random r = new Random();
            for (i = 0; i < 10; i++)
            {
                j = r.Next(10);
                buf = digits[i];
                digits[i] = digits[j];
                digits[j] = buf;
            }
            if (digits[0] == 0)
            {
                i = 1;
            }
            else
            {
                i = 0;
            }
            for (; p >= 1; p /= 10, i++)
            {
                res += digits[i] * p;
            }
            return res;        
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            inputNumber = Convert.ToInt32(numInput.Text);

            int[] numberArray = toIntegerArray(number);
            int[] inputNumberArray = toIntegerArray(inputNumber);

            var both = numberArray.Intersect(inputNumberArray);
            cows = both.Count();

            for(int i = 0; i < 4; i++)
            {
                if(numberArray[i] == inputNumberArray[i])
                {
                    bulls++;
                }
            }

            output.Text += "Коровы - " + cows + " быки - " + bulls + "\n";
            cows = 0;
            bulls = 0;
        }

        public int[] toIntegerArray(int number)
        {
            int a = number;
            List<int> l = new List<int>();
            while (a > 0)
            {
                l.Add(a % 10);
                a = a / 10;
            }
            return l.ToArray();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Компьютер задумывает четыре различные цифры из 0,1,2,...9. Игрок делает ходы, чтобы узнать эти цифры и их порядок. Каждый ход состоит из четырёх цифр, 0 может стоять на первом месте. В ответ компьютер показывает число отгаданных цифр, стоящих на своих местах(число быков) и число отгаданных цифр, стоящих не на своих местах(число коров).");
        }
    }
}
