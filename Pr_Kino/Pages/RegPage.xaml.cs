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
            if(users.FirstOrDefault(p => p.Login == LogRegName.Text) != null)
            {
                MessageBox.Show("Аккаунт с таким логином был уже создан");
            }
            else if(PassAgRegName.Text != PassRegName.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
            }
            else
            {
                MainWindow.user = new User {
                    Login = LogRegName.Text,
                    Password = PassRegName.Text
                };
                MessageBox.Show("Регистрация прошла успешно!");
                Core.Context.User.Add(MainWindow.user);
                Core.Context.SaveChanges();
                NavigationService.Navigate(new MainePage());
            }

        }
    }
}
