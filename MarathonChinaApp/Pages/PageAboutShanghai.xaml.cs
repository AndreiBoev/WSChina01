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
    /// Interaction logic for PageAboutShanghai.xaml
    /// </summary>
    public partial class PageAboutShanghai : Page
    {
        public PageAboutShanghai()
        {
            InitializeComponent();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SPAllPictures.Visibility = Visibility.Collapsed;
            SPPicture.Visibility = Visibility.Visible;
            Image currentPicture = sender as Image;
            ImPicture.Source = currentPicture.Source;
        }

        private void ImPicture_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SPAllPictures.Visibility = Visibility.Visible;
            SPPicture.Visibility = Visibility.Collapsed;
        }
    }
}
