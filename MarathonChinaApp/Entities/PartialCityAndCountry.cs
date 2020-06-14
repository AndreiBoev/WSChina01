using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarathonChinaApp.Entities
{
    public partial class PreviousCompetition
    {
        public string CityAndCountry => City.Name + ", " + City.Country.Name;
    }
}
