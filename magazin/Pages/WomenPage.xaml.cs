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

namespace magazin.Pages
{
    /// <summary>
    /// Логика взаимодействия для WomenPage.xaml
    /// </summary>
    public partial class WomenPage : Page
    {
        public WomenPage()
        {
            InitializeComponent();
        }

        private void women_Click(object sender, RoutedEventArgs e)
        {
            DataHelper.frame.Navigate(new WomenPage());
        }

        private void girl_Click_1(object sender, RoutedEventArgs e)
        {
            DataHelper.frame.Navigate(new GirlPage());
        }

        private void boys_Click(object sender, RoutedEventArgs e)
        {
            DataHelper.frame.Navigate(new BoysPage());
        }
    }
}
