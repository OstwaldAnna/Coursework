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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();

        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                var user = ODBClass.entities.User.FirstOrDefault(x => x.Login == NameTextBox.Text && x.Password == PasswordBox.Password);
                if (user != null)
                {
                    DataHelper.iduser = user.id;
                    DataHelper.frame.Navigate(new MenuPage(user));
                }
                else { MessageBox.Show("Что-то пошло не так. Повторите попытку."); }

            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так. Повторите попытку.");
            }


        }
    }
}

