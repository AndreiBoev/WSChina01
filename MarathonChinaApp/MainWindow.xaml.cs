﻿using MarathonChinaApp.Pages;
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
using System.Windows.Threading;

namespace MarathonChinaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _dispatcherTimer;
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new PageStart());
            TBDate.Text = DateTime.Now.ToShortDateString();
            _dispatcherTimer = new DispatcherTimer();
            _dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            _dispatcherTimer.Tick += DispatcherTimer_Tick;
            _dispatcherTimer.Start();
            DispatcherTimer_Tick(null, null);
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            Page currentPage = (Page)MainFrame.Content;

            if (currentPage.Tag?.ToString() == "Unauth")
            {
                BtnLogout.Visibility = Visibility.Collapsed;
            }
            else
            {
                BtnLogout.Visibility = Visibility.Visible;
            }

            if (MainFrame.Content is PageStart)
            {
                GridLarge.Visibility = Visibility.Visible;
                GridLittle.Visibility = Visibility.Collapsed;
            }
            else
            {
                GridLarge.Visibility = Visibility.Collapsed;
                GridLittle.Visibility = Visibility.Visible;
            }
        }
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime(2021, 9, 22, 0, 00, 00);
            TimeSpan timeSpan = dateTime - DateTime.Now;
            TBCount.Text = timeSpan.Days.ToString("N0") + " days " + timeSpan.Hours.ToString("N0") + " hours " 
                + timeSpan.Minutes.ToString("N0") + " minutes and " + timeSpan.Seconds.ToString("N0") + " seconds until the WorldSkills Shanghai 2021 starts.";
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.GoBack();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            AppData.AuthorizedUser = null;
            MainFrame.Navigate(new PageStart());
        }
    }
}
