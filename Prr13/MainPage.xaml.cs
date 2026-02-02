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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public static List<Product> Products = Core.Context.Product.ToList();
        List<Product> CartSpisok = new List<Product>();
        public MainPage()
        {
            InitializeComponent();
            ProductList.ItemsSource = Products;
        }

        private void Butt1_Click(object sender, RoutedEventArgs e)
        {
            Button Btn = sender as Button;
            Product SelectProd = Btn.DataContext as Product;
            if(SelectProd == null)
                return;
            CartSpisok.Add(SelectProd);
            MessageBox.Show($"{SelectProd.Name} добавлен(а) в корзину");
        }

        private void Butt2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CartPage(CartSpisok));
        }
    }
}
