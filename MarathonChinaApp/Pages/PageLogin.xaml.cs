using MarathonChinaApp.Pages.CompetitorPage;
using MarathonChinaApp.Pages.CoordinatorPage;
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

namespace MarathonChinaApp.Pages
{
    /// <summary>
    /// Interaction logic for PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (TBIdNumber.Text == "" || PBPassword.Password == null)
            {
                MessageBox.Show("Все поля обязательны для заполнения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var currentUser = AppData.Context.Users.FirstOrDefault(p => p.IdNumber + "" == TBIdNumber.Text && p.Password == PBPassword.Password);
            if (currentUser != null)
            {
                AppData.AuthorizedUser = currentUser;
                switch (currentUser.RoleId)
                {
                    case 1:
                        NavigationService.Navigate(new CompetitorPage.PageMenu());
                        break;
                    case 2:
                        NavigationService.Navigate(new CoordinatorPage.PageMenu());
                        break;
                    case 3:
                        NavigationService.Navigate(new AdministratorPage.PageMenu());
                        break;
                    case 4:
                        NavigationService.Navigate(new JudgerPage.PageMenu());
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
