using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pr_Kino
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public static List<User> users = Core.Context.User.ToList();
        public RegPage()
        {
            InitializeComponent();
        }

        private void LogRegName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(LogRegName.Text) && !string.IsNullOrEmpty(PassRegName.Text) && !string.IsNullOrEmpty(PassAgRegName.Text))
                EnterButt.IsEnabled = true;
        }

        private void EnterButt_Click(object sender, RoutedEventArgs e)
        {
            if (Registration(LogRegName.Text, PassRegName.Text, PassAgRegName.Text))
            {
                MainWindow.user = new User
                {
                    Login = LogRegName.Text,
                    Password = PassRegName.Text
                };
                Core.Context.User.Add(MainWindow.user);
                Core.Context.SaveChanges();
                NavigationService.Navigate(new MainePage());
            }
        }

        /// <summary>
        /// Метод проверяет правильность заполнения полей регистрации
        /// </summary>
        /// <param name="login">Логин пользователя</param>
        /// <param name="password">Пароль пользователя</param>
        /// <param name="password2">Подтверждение пароля</param>
        /// <returns>Успех/неуспех регистрации</returns>
        public bool Registration(string login, string password, string password2)
        {
            if (users.FirstOrDefault(p => p.Login == login) != null)
            {
                MessageBox.Show("Аккаунт с таким логином был уже создан");
                return false;
            }

            if (password2 != password)
            {
                MessageBox.Show("Пароли не совпадают!");
                return false;
            }

            if (login.IndexOf("@") == -1 || login.IndexOf(".") == -1 || login.IndexOf(".") < login.IndexOf("@"))
            {
                MessageBox.Show("Неверный формат логина!");
                return false;
            }

            if (password.Length < 8 || password.Length > 255)
            {
                MessageBox.Show("Длина пароля должна быть минимум 8 символов, максимум - 255!");
                return false;
            }
            
            MessageBox.Show("Регистрация прошла успешно!");
            return true;
        }
    }
}
