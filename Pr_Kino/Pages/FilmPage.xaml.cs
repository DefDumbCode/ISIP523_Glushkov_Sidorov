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
    /// Логика взаимодействия для FilmPage.xaml
    /// </summary>
    public partial class FilmPage : Page
    {
        public Film film { get; set; }
        public static List<Session> Sessions = Core.Context.Session.ToList();
        public FilmPage(Film _Film)
        {
            InitializeComponent();
            DataContext = _Film;
            this.film = _Film;
            SeansList.ItemsSource = Sessions.Where(s => s.ID_Film == _Film.ID).ToList(); ;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }




        private void SeansList_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Pages.SessionPage(SeansList.SelectedItem as Session));
        }
    }
}
