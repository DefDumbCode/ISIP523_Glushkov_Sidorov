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
    /// Логика взаимодействия для CartPage.xaml
    /// </summary>
    public partial class CartPage : Page
    {
        List<Product> CartSpisok;
        Order NewOrd;
        public CartPage(List<Product> _CartSpisok, Order _NewOrd)
        {
            InitializeComponent();
            CartSpisok = _CartSpisok;
            NewOrd = _NewOrd;
            string b = "";
            for (int i = 0; i < CartSpisok.Count; i++)
            {
                b += ($"{CartSpisok[i].Name}\n");
            }
            CartList.Text = b;
            
        }

        private void Butt3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrderPage(CartSpisok, NewOrd));
        }

        private void Butt4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
