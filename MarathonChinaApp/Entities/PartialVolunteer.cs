using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarathonChinaApp.Entities
{
    public partial class Volunteer
    {
        public string FullName => FirstName + " " + LastName;
        public string CityAndCountry => City.Name + ", " + City.Country.Name;
        public string Skills => CompetitionOfChampionship.Competition.Id + " - " + CompetitionOfChampionship.Competition.Name;
    }
}
