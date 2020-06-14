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
    /// Interaction logic for PageHistoryOfWorldSkills.xaml
    /// </summary>
    public partial class PageHistoryOfWorldSkills : Page
    {
        public PageHistoryOfWorldSkills()
        {
            InitializeComponent();
            TBDescription.Text = "WorldSkills International is an international non-profit Association whose goal is to raise the status and standards" +
                " of professional training and qualifications around the world, to promote working professions through international competitions around the world.";
        }

        private void BorderWS_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BorderWS.BorderBrush = Brushes.Green;
            BorderFrancisco.BorderBrush = Brushes.Transparent;
            BorderConpetition.BorderBrush = Brushes.Transparent;
            BorderDirectors.BorderBrush = Brushes.Transparent;
            TBDescription.Text = "WorldSkills International is an international non-profit Association whose goal is to raise the status and standards" +
                " of professional training and qualifications around the world, to promote working professions through international competitions around the world.";
        }

        private void BorderFrancisco_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BorderFrancisco.BorderBrush = Brushes.Green;
            BorderWS.BorderBrush = Brushes.Transparent;
            BorderConpetition.BorderBrush = Brushes.Transparent;
            BorderDirectors.BorderBrush = Brushes.Transparent;
            TBDescription.Text = "Some took this challenge as an opportunity to introduce young people to the world of vocational skills. " +
    "Francisco Albert Vidal was charged with creating a skills contest for the youth of Spain and Portugal. " +
    "Madrid 1950 was a modest event by today’s standards but an international movement was born.";
        }

        private void BorderConpetition_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BorderConpetition.BorderBrush = Brushes.Green;
            BorderWS.BorderBrush = Brushes.Transparent;
            BorderFrancisco.BorderBrush = Brushes.Transparent;
            BorderDirectors.BorderBrush = Brushes.Transparent;
            TBDescription.Text = "The competition moved abroad for the first time, to Brussels in Belgium. " +
                "It was the start of the WorldSkills movement expanding across the globe.";
        }

        private void BorderDirectors_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BorderConpetition.BorderBrush = Brushes.Transparent;
            BorderWS.BorderBrush = Brushes.Transparent;
            BorderFrancisco.BorderBrush = Brushes.Transparent;
            BorderDirectors.BorderBrush = Brushes.Green;
            TBDescription.Text = "The WorldSkills Australia Board of Directors play an important role in shaping our social enterprise. " +
                "As Members, our non-executive Directors collectively bring decades of experience and expertise in skills, trades, education, jobs and" +
                " business across a huge range of industries. As volunteers, each Director is dedicated to contributing to Australia’s sustainable economic " +
                "prosperity by positively promoting excellence throughout Australia’s vocational training sectors and providing opportunities for young Australian’s " +
                "to excel.";
        }

        private void TBDescription_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
