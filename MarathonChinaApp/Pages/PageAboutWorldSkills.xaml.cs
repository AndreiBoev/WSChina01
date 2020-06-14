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
    /// Interaction logic for PageAboutWorldSkills.xaml
    /// </summary>
    public partial class PageAboutWorldSkills : Page
    {
        public PageAboutWorldSkills()
        {
            InitializeComponent();
        }

        private void HisOfWS_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageHistoryOfWorldSkills());
        }

        private void BtnPrevComp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PagePreviousCompetition());
        }

        private void BtnCompSkills_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageCompetitionSkills());
        }
    }
}
