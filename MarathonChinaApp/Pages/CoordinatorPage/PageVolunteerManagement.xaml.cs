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
    /// Interaction logic for PageVolunteerManagement.xaml
    /// </summary>
    public partial class PageVolunteerManagement : Page
    {
        public PageVolunteerManagement()
        {
            InitializeComponent();
            BtnAdjustVolunteers.Content = new TextBlock() { Text = "Adjust volunteers between skills", TextWrapping = TextWrapping.Wrap, TextAlignment = TextAlignment.Center };
            Update();
            var currentSkills = AppData.Context.CompetitionOfChampionships.ToList();
            currentSkills.Insert(0, new CompetitionOfChampionship
            {
                Competition = new Competition
                {
                    Name = "Все компетенции"
                }
            });
            CBSkills.ItemsSource = currentSkills.ToList();
            CBSkills.SelectedIndex = 0;
            CBSort.SelectedIndex = 0;
        }
        private void Update()
        {
            var currentVoluteers = AppData.Context.Volunteers.ToList();
            if(CBSkills.SelectedIndex > 0)
            {
                currentVoluteers = currentVoluteers.Where(p => p.CompetitionOfChampionship == CBSkills.SelectedItem as Entities.CompetitionOfChampionship).ToList();
            }
            switch (CBSort.SelectedIndex)
            {
                case 0: 
                    currentVoluteers = currentVoluteers.OrderBy(p => p.Id).ToList();
                    break;
                case 1:
                    currentVoluteers = currentVoluteers.OrderBy(p => p.FullName).ToList();
                    break;
                case 2:
                    currentVoluteers = currentVoluteers.OrderBy(p => p.Gender.Name).ToList();
                    break;
                case 3:
                    currentVoluteers = currentVoluteers.OrderBy(p => p.CityAndCountry).ToList();
                    break;
                case 4:
                    currentVoluteers = currentVoluteers.OrderBy(p => p.CityAndCountry).ToList();
                    break;
                case 5:
                    currentVoluteers = currentVoluteers.OrderBy(p => p.Skills).ToList();
                    break;
                default:
                    break;
            }
            TBCount.Text = currentVoluteers.Count.ToString();
            DGVolunteers.ItemsSource = currentVoluteers.ToList();
            if (currentVoluteers.Count == 0)
            {
                TBResult.Visibility = Visibility.Visible;
                DGVolunteers.Visibility = Visibility.Collapsed;
                TBResult.Text = "По запросу " + CBSkills.Text + " ничего не найдено";
            }
            else
            {
                TBResult.Visibility = Visibility.Collapsed;
                DGVolunteers.Visibility = Visibility.Visible;
            }
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void BtnImport_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageImportVolunteers());
        }
    }
}
