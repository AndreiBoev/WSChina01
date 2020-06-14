using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;
using System.IO;
using System.IO.Packaging;
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
    /// Interaction logic for PageAbotWSChina.xaml
    /// </summary>
    public partial class PageAbotWSChina : Page
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        private string exePath = AppDomain.CurrentDomain.BaseDirectory;
        public PageAbotWSChina()
        {
            InitializeComponent();
            BtnAccessionWS.Content = new TextBlock() { Text = "China's Accession to the WorldSkills", TextWrapping = TextWrapping.Wrap, TextAlignment = TextAlignment.Center};
            BtnCommitteeChina.Content = new TextBlock() { Text = "Committee of WorldSkils China", TextWrapping = TextWrapping.Wrap, TextAlignment = TextAlignment.Center };
            BtnResult.Content = new TextBlock() { Text = "Participation and Result", TextWrapping = TextWrapping.Wrap, TextAlignment = TextAlignment.Center };
            saveFileDialog.Filter = "Formats |.doc, .docx";
        }

        private void BtnAccessionWS_Click(object sender, RoutedEventArgs e)
        {
            SPAccessionWS.Visibility = Visibility.Visible;
            SPCommitteeChina.Visibility = Visibility.Collapsed;
            SPResult.Visibility = Visibility.Collapsed;
        }

        private void BtnCommitteeChina_Click(object sender, RoutedEventArgs e)
        {
            SPAccessionWS.Visibility = Visibility.Collapsed;
            SPCommitteeChina.Visibility = Visibility.Visible;
            SPResult.Visibility = Visibility.Collapsed;
        }

        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            SPAccessionWS.Visibility = Visibility.Collapsed;
            SPCommitteeChina.Visibility = Visibility.Collapsed;
            SPResult.Visibility = Visibility.Visible;
        }

        private void ImAccessionWS_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            saveFileDialog.FileName = "Вступление Китая в WS.docx";
            if(saveFileDialog.ShowDialog() == true)
            {
                string ofd = saveFileDialog.FileName;
                var path = System.IO.Path.Combine(exePath, "..//..//Assets//About WS China//Вступление Китая в WS.docx");
                System.IO.File.Copy(path, ofd);
                if(MessageBox.Show("Файл сохранен. Хотите его открыть?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Process.Start(ofd);
                }
            } 
        }

        private void ImCommitteeChina_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            saveFileDialog.FileName = "Комитет.docx";
            if (saveFileDialog.ShowDialog() == true)
            {
                string ofd = saveFileDialog.FileName;
                var path = System.IO.Path.Combine(exePath, "..//..//Assets//About WS China//Комитет.docx");
                System.IO.File.Copy(path, ofd);
                if (MessageBox.Show("Файл сохранен. Хотите его открыть?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Process.Start(ofd);
                }
            }
        }

        private void ImResult_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            saveFileDialog.FileName = "Результаты.docx";
            if (saveFileDialog.ShowDialog() == true)
            {
                string ofd = saveFileDialog.FileName;
                var path = System.IO.Path.Combine(exePath, "..//..//Assets//About WS China//Результаты.docx");
                System.IO.File.Copy(path, ofd);
                if (MessageBox.Show("Файл сохранен. Хотите его открыть?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Process.Start(ofd);
                }
            }
        }
    }
}
