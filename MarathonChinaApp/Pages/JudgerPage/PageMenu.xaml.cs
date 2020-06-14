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

namespace MarathonChinaApp.Pages.JudgerPage
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
            if (AppData.Context.Registrations.Where(p => p.UserId == p.User.IdNumber).FirstOrDefault() == null)
            {
                MessageBox.Show(AppData.AuthorizedUser.FirstName + ", Вы не зарегистрированы на чемпионат! Пожалуйста, зарегистрируйтесь и повторите попытку.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                BtnDrawLots.IsEnabled = false;
                BtnInputScore.IsEnabled = false;
                BtnResult.IsEnabled = false;
            }
        }
    }
}
