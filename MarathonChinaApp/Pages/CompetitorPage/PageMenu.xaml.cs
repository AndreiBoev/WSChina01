using MarathonChinaApp.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace MarathonChinaApp.Pages.CompetitorPage
{
    /// <summary>
    /// Interaction logic for PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
            DataContext = AppData.AuthorizedUser;
            if (AppData.AuthorizedUser.Photo != null)
            {
                ImAvatar.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(AppData.AuthorizedUser.Photo);
            }
        }

        private void BtnMySkills_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CompetitorPage.PageMySlills());
        }

        private void BtnProfile_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CompetitorPage.PageMyProfile());
        }

        private void BtnMyResult_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CompetitorPage.PageResult());
        }
    }
}
