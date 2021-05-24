using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace logical_games
{
    public partial class Form1 : Form
    {
        public XmlSerializer xmlSerializer = new XmlSerializer(typeof(User[]));
        public User[] arrayOfUsers;
        public Form1()
        {
            InitializeComponent();
        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[0-9]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[0-9]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        public List<User> ReadUsers()
        {
            using (FileStream fs = new FileStream(@"xml\logins.xml", FileMode.OpenOrCreate))
            {
                arrayOfUsers = (User[])xmlSerializer.Deserialize(fs);
            }

            var list = arrayOfUsers.Cast<User>().ToList();
            return list;
        }

        public void ValidateUser(string login, string password)
        {
            var listOfUsers = ReadUsers();
            bool isRegistred = false;

            foreach (User u in listOfUsers)
            {
                if (login.Equals(u.Login))
                {
                    isRegistred = true;
                    if (password.Equals(u.Password))
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль");
                    }
                }
            }

            if (isRegistred == false)
            {
                User user = new User(loginInput.Text, passwordInput.Text);
                listOfUsers.Add(user);
                File.Delete(@"xml\logins.xml");

                using (FileStream fs = new FileStream(@"xml\logins.xml", FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fs, listOfUsers.ToArray());
                }
                MessageBox.Show("Вы успешно зарегистрированы!");
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            ValidateUser(loginInput.Text, passwordInput.Text);
        }
    }
}
