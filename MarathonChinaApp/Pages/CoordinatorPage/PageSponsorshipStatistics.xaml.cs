using MarathonChinaApp.Entities;
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
    /// Interaction logic for PageSponsorshipStatistics.xaml
    /// </summary>
    public partial class PageSponsorshipStatistics : Page
    {
        public PageSponsorshipStatistics()
        {
            InitializeComponent();            
            CBSort.SelectedIndex = 0;
            var currentEvent = AppData.Context.Championships.ToList();
            CBEvent.SelectedIndex = 0;
            BtnStatistics_Click(null, null);
            currentEvent.Insert(0, new Championship
            {
                Name = "All Events"
            });
            CBEvent.ItemsSource = currentEvent;
            TBCount.Text = AppData.Context.Sponsorships.Sum(p => p.Amount).ToString();
        }

        private void BtnStatistics_Click(object sender, RoutedEventArgs e)
        {
            var currentSponsorship = AppData.Context.Sponsorships.ToList();
            switch (CBSort.SelectedIndex)
            {
                case 0:
                    currentSponsorship = currentSponsorship.OrderBy(p => p.SponsorClass.Name).ToList();
                    break;
                case 1:
                    currentSponsorship = currentSponsorship.OrderBy(p => p.AllSponsor).ToList();
                    break;
                default:
                    break;
            }
            if(CBEvent.SelectedIndex > 0)
            {
                currentSponsorship = currentSponsorship.Where(p => p.Championship == CBEvent.SelectedItem as Entities.Championship).ToList();
            }
            DGSponsorship.ItemsSource = currentSponsorship;
        }
    }
}
