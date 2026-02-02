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

        List<Product> CartSpisok;
        List<Order_Product> Ords;
        public OrderPage(List<Product> _CartSpisok, List<Order_Product> _Ords)
        {
            InitializeComponent();
            CartSpisok = _CartSpisok;
            Ords = _Ords;

        }

        private void Butt5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Butt6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ADREStb_TextChanged(object sender, TextChangedEventArgs e)
        {
           if(!string.IsNullOrEmpty(EMAILtb.Text) && !string.IsNullOrEmpty(ADREStb.Text) && !string.IsNullOrEmpty(ADREStb.Text))
                Butt6.IsEnabled = true;

        }


    }
}
