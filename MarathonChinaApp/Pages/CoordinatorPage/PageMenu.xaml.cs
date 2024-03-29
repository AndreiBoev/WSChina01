﻿using System;
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
    /// Interaction logic for PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
            DataContext = AppData.AuthorizedUser;
        }

        private void BtnVolunteer_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageVolunteerManagement());
        }

        private void BtnSponsorship_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageSponsorshipManagement());
        }

        private void BtnCompetitionSer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
