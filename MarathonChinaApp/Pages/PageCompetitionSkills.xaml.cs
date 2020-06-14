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

namespace MarathonChinaApp.Pages
{
    /// <summary>
    /// Interaction logic for PageCompetitionSkills.xaml
    /// </summary>
    public partial class PageCompetitionSkills : Page
    {
        public PageCompetitionSkills()
        {
            InitializeComponent();
            TVItemBlock.ItemsSource = AppData.Context.BlockSkills.ToList();
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var item = TVAllBloks.SelectedItem;
            if (item is Competition currentCompetition)
            {
                TBCompetition.Text = currentCompetition.Id + " - " + currentCompetition.Name;
                TBDescription.Text = currentCompetition.Description;
            }
        }
    }
}
