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
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
            DgProduct.ItemsSource = ODBClass.entities.Closes.ToList();
            CbProduct.SelectedValuePath = "id";
            CbProduct.DisplayMemberPath = "Name";
            CbProduct.ItemsSource = ODBClass.entities.Category.ToList();
        }

        private void CbProduct_DropDownClosed(object sender, EventArgs e)
        {
            DgProduct.ItemsSource = ODBClass.entities.Closes.Where(x => x.Category.id == (int)CbProduct.SelectedValue).ToList();
        }

        private void BtnAll_Click(object sender, RoutedEventArgs e)
        {
            DgProduct.ItemsSource = ODBClass.entities.Closes.ToList();
        }
    }
}
