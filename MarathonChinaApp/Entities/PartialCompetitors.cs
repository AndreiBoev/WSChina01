using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarathonChinaApp.Entities
{
    public partial class User
    {
        public string FullNameAndCountry => FirstName + " " + LastName + "(" + City.Country.Name + ")";
    }
}
