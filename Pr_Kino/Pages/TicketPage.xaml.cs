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
    /// Логика взаимодействия для TicketPage.xaml
    /// </summary>
    public partial class TicketPage : Page
    {

        public static Session_Seat _Session_seat;
        public int price = 250;
        public TicketPage(Session_Seat seat)
        {
            InitializeComponent();
            DataContext = seat;
            _Session_seat = seat;
            switch (seat.Session.Room.Room_Rating.RoomQuality)
            {
                case "VIP":
                    price *= 2;
                    break;
                case "Люкс":
                    price *= 3; 
                    break;
                case "Обычный":
                    break;
            }
            PriceTB.Text += price.ToString();
            if(Core.Context.Session_Seat.FirstOrDefault(c => c.ID == _Session_seat.ID).Taken == true)
            {
                BuyBTN.Visibility = Visibility.Hidden;
            }
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void BuyBTN_Click(object sender, RoutedEventArgs e)
        {
            Ticket ticket = new Ticket
            {
                ID_User = MainWindow.user.ID,
                ID_Seat = _Session_seat.ID_Seat,
                ID_Session = _Session_seat.ID_Session,
                Price = price
            };
            Core.Context.Ticket.Add(ticket);
            Core.Context.Session_Seat.FirstOrDefault(c => c.ID == _Session_seat.ID).Taken = true;
            Core.Context.SaveChanges();
            MessageBox.Show("Покупка произведена!");
            NavigationService.Navigate(new MainePage());
            
        }
    }
}
