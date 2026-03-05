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
using static System.Collections.Specialized.BitVector32;

namespace Pr_Kino
{
    /// <summary>
    /// Логика взаимодействия для AccPage.xaml
    /// </summary>
    public partial class AccPage : Page
    {
        public List<Ticket> Ticket = Core.Context.Ticket.ToList();
        public AccPage()
        {
            InitializeComponent();
            DataContext = MainWindow.user;
            Ticket = Ticket.Where(s => s.ID_User == MainWindow.user.ID).ToList();
            TicketList.ItemsSource = Ticket;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void TicketList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Ticket ticket = TicketList.SelectedItem as Ticket;
            NavigationService.Navigate(new Pages.TicketPage(ticket.Session.Session_Seat.FirstOrDefault(s => s.ID_Session == ticket.ID_Session && s.ID_Seat == ticket.ID_Seat)));
        }
    }
}
