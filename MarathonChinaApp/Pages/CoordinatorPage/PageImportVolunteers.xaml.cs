using Microsoft.Win32;
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
    /// Interaction logic for PageImportVolunteers.xaml
    /// </summary>
    public partial class PageImportVolunteers : Page
    {
            OpenFileDialog ofd = new OpenFileDialog();
        public PageImportVolunteers()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnImport_Click(object sender, RoutedEventArgs e)
        {
            if (ofd.FileName == "")
            {
                BtnBrowse_Click(null, null);
                return;
            }

        }

        private void BtnBrowse_Click(object sender, RoutedEventArgs e)
        {
            ofd.Filter = "Image formats | *.xls";
            if (ofd.ShowDialog() == true)
            {
                TBPath.Text = ofd.FileName;
            }
        }
    }
}
