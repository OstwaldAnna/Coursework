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
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        public AddProductPage()
        {
            InitializeComponent();
            CbCategory.SelectedValuePath = "id";
            CbCategory.DisplayMemberPath = "Name";
            CbCategory.ItemsSource = ODBClass.entities.Category.ToList();

            CbSize.SelectedValuePath = "id";
            CbSize.DisplayMemberPath = "Name";
            CbSize.ItemsSource = ODBClass.entities.SizeObject.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
          Closes closes = new Closes()
           {
               idSize = (int)CbSize.SelectedValue,
               idCategory = (int)CbCategory.SelectedValue,
               Product = TbProduct.Text,
               Amount = int.Parse(TbAmount.Text),
           };
            ODBClass.entities.Closes.Add(closes);
            ODBClass.entities.SaveChanges();
            MessageBox.Show("Товар успешно добавлен", "Сообщение", MessageBoxButton.OK);



        }
    }
}
