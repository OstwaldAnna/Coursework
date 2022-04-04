using magazin.Bd;
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
    /// Логика взаимодействия для AddCategoryPage.xaml
    /// </summary>
    public partial class AddCategoryPage : Page
    {
        public AddCategoryPage()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Category сategory = new Category()
            {
                Name = TbCategory.Text,
            };
            ODBClass.entities.Category.Add(сategory);
            ODBClass.entities.SaveChanges();
            MessageBox.Show("Товар успешно добавлен", "Сообщение", MessageBoxButton.OK);
        }
    }
}
