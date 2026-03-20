using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Логика взаимодействия для LogPage.xaml
    /// </summary>
    public partial class LogPage : Page
    {
        public static List<User> users = Core.Context.User.ToList();
        public LogPage()
        {
            InitializeComponent();
        }

        private void RegButt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }

        private void EnterButt_Click(object sender, RoutedEventArgs e)
        {
            if (users.FirstOrDefault(p => p.Login == LogName.Text && p.Password == PassName.Text) != null)
            {
                MainWindow.user = users.FirstOrDefault(p => p.Login == LogName.Text && p.Password == PassName.Text);
                MessageBox.Show("Вход прошёл успешно!");
                NavigationService.Navigate(new MainePage());
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль!");
            }
        }

        private void PassName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(PassName.Text) && !string.IsNullOrEmpty(LogName.Text))
                EnterButt.IsEnabled = true;
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack) 
            {
                NavigationService.GoBack();
            }
        }

    }
}
