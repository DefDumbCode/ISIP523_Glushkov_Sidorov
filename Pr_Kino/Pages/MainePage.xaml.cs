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
    /// Логика взаимодействия для MainePage.xaml
    /// </summary>
    public partial class MainePage : Page
    {
        public static List<Film> Films = Core.Context.Film.ToList();
        public MainePage()
        {
            InitializeComponent();
            FilmList.ItemsSource = Films;
            List<String> genre = new List<String> {"По названию", "По рейтингу"};
            FilterBox.ItemsSource = genre;
            if(MainWindow.user == null)
            {
                UserButt.Content = "Войти в аккаунт";
            }
            else
            {
                UserButt.Content = "Аккаунт";
            }
        }



        private void UserButt_Click(object sender, RoutedEventArgs e)
        {
            if(MainWindow.user == null)
            {
                NavigationService.Navigate(new LogPage());
            }
            else
            {
                NavigationService.Navigate(new AccPage());
            }
        }

        private void FilmList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new FilmPage(FilmList.SelectedItem as Film));
        }

        private void FilterBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (FilterBox.SelectedIndex)
            {
                case 0:
                    FilmList.ItemsSource = Films.OrderBy(p => p.Name);
                    break;
                case 1:
                    FilmList.ItemsSource = Films.OrderBy(p => p.Rating);
                    break;
                default:
                    FilmList.ItemsSource = Films.OrderBy(p => p.Name);
                    break;
            }

        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            FilmList.ItemsSource = Films.Where(p => p.Name.ToLower().Contains(SearchBar.Text.ToLower()));
        }
    }
}
