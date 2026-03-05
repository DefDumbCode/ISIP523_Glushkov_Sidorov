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

namespace Pr_Kino.Pages
{
    /// <summary>
    /// Логика взаимодействия для SessionPage.xaml
    /// </summary>
    public partial class SessionPage : Page
    {
        public static List<Seat> Seats = Core.Context.Seat.ToList();
        public static List<Session_Seat> SesSeats = Core.Context.Session_Seat.ToList();
        public SessionPage(Session session)
        {
            InitializeComponent();
            SesSeats = SesSeats.Where(s => s.ID_Session == session.ID).ToList();
            SeatList.ItemsSource = SesSeats;
            SesSeats = Core.Context.Session_Seat.ToList();
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void SeatList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(MainWindow.user == null)
            {
                MessageBox.Show("Для покупки билетов необходим аккаунт!");
            }
            else
            {
                Session_Seat selectedSeat = SeatList.SelectedItem as Session_Seat;
                NavigationService.Navigate(new TicketPage(selectedSeat));
            }
        }
    }
}
