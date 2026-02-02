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

namespace Prr13
{
    /// <summary>
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        public OrderPage(List<Product> _CartSpisok)
        {
            InitializeComponent();
        }

        private void Butt5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Butt6_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
