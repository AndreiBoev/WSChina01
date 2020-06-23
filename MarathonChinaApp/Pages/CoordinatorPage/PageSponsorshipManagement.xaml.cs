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

namespace MarathonChinaApp.Pages.CoordinatorPage
{
    /// <summary>
    /// Interaction logic for PageSponsorshipManagement.xaml
    /// </summary>
    public partial class PageSponsorshipManagement : Page
    {
        public PageSponsorshipManagement()
        {
            InitializeComponent();
        }

        private void BtnStatistics_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageSponsorshipStatistics());
        }
    }
}
