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
    /// Interaction logic for PageStart.xaml
    /// </summary>
    public partial class PageStart : Page
    {
        public PageStart()
        {
            InitializeComponent();
        }

        private void BtnAbWS_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageAboutWorldSkills());
        }

        private void BtnAbWSChina_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageAbotWSChina());
        }

        private void BtnAbShangHai_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageAboutShanghai());
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageLogin());
        }
    }
}
