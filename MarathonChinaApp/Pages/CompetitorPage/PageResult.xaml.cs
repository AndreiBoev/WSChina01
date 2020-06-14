using MarathonChinaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Interaction logic for PageResult.xaml
    /// </summary>
    public partial class PageResult : Page
    {
        /// <summary>
        /// Для теста использовать пользователя 23, остальные не заполнены ¯\_(ツ)_/¯           
        /// </summary>
        public PageResult()
        {
            InitializeComponent();
            DataContext = AppData.AuthorizedUser.Registrations;
            TBName.Text = AppData.AuthorizedUser.FirstName;
            TBGender.Text = AppData.AuthorizedUser.Gender.Name;
            TBNumber.Text = AppData.AuthorizedUser.IdNumber.ToString();
            TBProvince.Text = AppData.AuthorizedUser.City.Name + " (" + AppData.AuthorizedUser.City.ZipCode + ")";
            TBOrganization.Text = AppData.AuthorizedUser.Organization;
            TBEvent.Text = AppData.AuthorizedUser.Registrations.FirstOrDefault().CompetitionOfChampionship.Championship.Year.ToString() + " - " + AppData.AuthorizedUser.Registrations.FirstOrDefault().CompetitionOfChampionship.Championship.Name;
            TBSkills.Text = AppData.AuthorizedUser.Registrations.FirstOrDefault().CompetitionOfChampionship.Competition.Id.ToString() + " - " + AppData.AuthorizedUser.Registrations.FirstOrDefault().CompetitionOfChampionship.Competition.Name;
            TBCompNum.Text = AppData.AuthorizedUser.Registrations.FirstOrDefault().Id.ToString();
            LVScore.ItemsSource = AppData.AuthorizedUser.Registrations.FirstOrDefault().Scores.ToList();
            //TBCount.Text = AppData.AuthorizedUser.Registrations.FirstOrDefault().SumScore.ToString();
        } 
    }
}
