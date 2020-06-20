using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MarathonChinaApp.Entities
{
    public partial class CompetitionOfChampionship
    {
        public string CodeAndNameCompetition => (CompetitionId == 0) ? Competition.Name : Competition.Id + " - " + Competition.Name;
        //{
        //    get
        //    {
        //        if (CompetitionId == 0)
        //        {
        //            return Competition.Name;
        //        }
        //        else
        //        {
        //            return Competition.Id + " - " + Competition.Name;
        //        }
        //    }
    }
    
}
