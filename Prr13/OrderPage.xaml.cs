using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public List<Order_Product> Ords = Core.Context.Order_Product.ToList();

        public OrderPage(List<Product> _CartSpisok)
        {
            InitializeComponent();
            CartSpisok = _CartSpisok;
            //NewOrd = _NewOrd;
            string b = "";
            double total = 0;
            for(int i = 0; i < CartSpisok.Count; i++)
            {
                b += ($"{CartSpisok[i].Name}\n");
                Product beb = MainPage.Products.FirstOrDefault(c => c.ID == CartSpisok[i].ID);
                total += beb.Price;
            }
            TotalTB.Text = b;
            Cost.Content = ($"Итоговая стоимость: {total}");

        }

        private void Butt5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Butt6_Click(object sender, RoutedEventArgs e)
        {
            Order NewOrd = new Order { FIO = FIOtb.Text, Email = EMAILtb.Text, Adress = ADREStb.Text, };
            Core.Context.Order.Add(NewOrd);
            Core.Context.SaveChanges();


            List<Order_Product> ExisList = Core.Context.Order_Product.ToList();
            for (int i = 0; i < CartSpisok.Count; i++)
            {
                Order_Product ExisOrdPro = ExisList.FirstOrDefault(c => c.ID_Product == CartSpisok[i].ID && c.ID_Order == NewOrd.ID);

                if (ExisOrdPro == null)
                {
                    Order_Product OrdPro = new Order_Product { ID_Order = NewOrd.ID, Amount = 1, ID_Product = CartSpisok[i].ID };
                    ExisList.Add(OrdPro);
                    Core.Context.Order_Product.Add(OrdPro);
                }
                else
                {
                    
                    ExisOrdPro.Amount++;
                    
                }
            }
                Core.Context.SaveChanges();
            
            MessageBox.Show("Заказ оформлен.");
        }

        private void ADREStb_TextChanged(object sender, TextChangedEventArgs e)
        {
           if(!string.IsNullOrEmpty(EMAILtb.Text) && !string.IsNullOrEmpty(FIOtb.Text) && !string.IsNullOrEmpty(ADREStb.Text))
                Butt6.IsEnabled = true;

        }


    }
}
