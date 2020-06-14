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

namespace MarathonChinaApp.Pages.CompetitorPage
{
    /// <summary>
    /// Interaction logic for PageMySlills.xaml
    /// </summary>
    public partial class PageMySlills : Page
    {
        public PageMySlills()
        {
            InitializeComponent();
            if (AppData.Context.Registrations.Where(p => p.UserId == p.User.IdNumber).FirstOrDefault() == null)
            {
                MessageBox.Show(AppData.AuthorizedUser.FirstName + ", Вы не зарегистрированы на чемпионат! Пожалуйста, зарегистрируйтесь.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            TBCompetitor.Text = AppData.AuthorizedUser.IdNumber.ToString() + " - " + AppData.AuthorizedUser.FirstName.ToString();
            LViewCompetitors.ItemsSource = AppData.Context.Registrations.Where(p => p.User.RoleId == 1).ToList();
            LViewJudgers.ItemsSource = AppData.Context.Registrations.Where(p => p.User.RoleId == 4).ToList();
            LViewPlan.ItemsSource = AppData.Context.PhotoCompetitions.Where(p => p.CompetitionId == 7).ToList();
            LViewInfrastructure.ItemsSource = AppData.Context.InfrastructureLists.Where(p => p.CompetitionId == 7).ToList();
            LViewShedule.ItemsSource = AppData.Context.ScheduleCompetitions.Where(p => p.CompetitionId == 7).ToList();
        }
    }
}
