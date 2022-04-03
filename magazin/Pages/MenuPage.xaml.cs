using magazin.Cl;
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
using magazin.Bd;

namespace magazin.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage(User user)
        {
            InitializeComponent();
            TbUser.Text = user.Login;
            DataHelper.frmProduct = FrmProduct;
        }

        private void Product_Click(object sender, RoutedEventArgs e)
        {
            DataHelper.frmProduct.Navigate(new ProductPage());
        }

        private void Dev_Click(object sender, RoutedEventArgs e)
        {
            DataHelper.frmProduct.Navigate(new DeliveryPage());
        }

        private void Grav_Click(object sender, RoutedEventArgs e)
        {
            DataHelper.frmProduct.Navigate(new GravPage());
        }

        private void Zakaz_Click(object sender, RoutedEventArgs e)
        {
            DataHelper.frmProduct.Navigate(new OrdersPage());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            
            DataHelper.frmProduct.Navigate(null);
        }
    }
}
