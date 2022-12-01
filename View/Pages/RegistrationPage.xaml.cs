using BeautySalonWPF.Controllers;
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

namespace BeautySalonWPF.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {

            Users newUser = new Users
            {
                IDRole = 2,
                UserName = NameTextBox.Text,
                UserLastName = LastNameTextBox.Text,
                UserOtherName = OtherNamaTextBox.Text,
                UserLogin = LoginTextBox.Text,
                UserPassword = PasswordPasswordBox.Password
            };
            if (RepeatPasswordPasswordBox.Password != PasswordPasswordBox.Password)
            {
                MessageBox.Show("Пароли разные");
            }
            else
            if (UsersController.AddUser(newUser))
            {
                MessageBox.Show("Пользователь добавлен");
            }
            else
            {
                MessageBox.Show("Пользователь не добавлен");
            }
           
        }
    }
}
