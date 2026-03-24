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

namespace Pr_PC_Builder.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {

        public MainPage()
        {
            InitializeComponent();
            Assemble ass = new Assemble();
            UnitList.ItemsSource = ass.partlist;
            //basepart_ baza = new basepart_{ id = 101, name = "AAAA",
            //manufacturerid = 1,
            //price = 200,
            //parttypeid = 2,
            //image = ""};
            //basepart_ smth = 
            //MessageBox.Show(baza.parttype_.name);
        }

        private void Butt1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
