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

        public static List<Product> CartSpisok = new List<Product>();
        //public static Order NewOrd = new Order();
        int count = 0;
      
        public MainPage()
        {
            InitializeComponent();
            ProductList.ItemsSource = Products;
            //Core.Context.Order.Add(NewOrd);
            Core.Context.SaveChanges();

        }

        private void Butt1_Click(object sender, RoutedEventArgs e)
        {
            Button Btn = sender as Button;
            Product SelectProd = Btn.DataContext as Product;
            
            if(SelectProd == null)
                return;
            //if (CartSpisok.FirstOrDefault(c => c.ID == SelectProd.ID) == null)
            //{
            //    Order_Product OrdPro = new Order_Product { ID_Order = MainPage.NewOrd.ID, Amount = 1, ID_Product = SelectProd.ID };
            //    Core.Context.Order_Product.Add(OrdPro);
            //    count++;
            //}
            //else
            //{
            //    for (int i = 0; i < Ords.Count; i++)
            //    {
            //        if (Ords[i].ID_Order == MainPage.NewOrd.ID && Ords[i].ID_Product == SelectProd.ID)
            //        {
            //            Ords[i].Amount++;
            //            count++;
                        
            //        }

            //    }
            //}

            //Core.Context.SaveChanges();
            CartSpisok.Add(SelectProd);


            MessageBox.Show($"{SelectProd.Name} добавлен(а) в корзину");
        }

        private void Butt2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CartPage(CartSpisok));
        }
    }
}
