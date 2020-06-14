using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarathonChinaApp.Entities
{
    public partial class ScheduleCompetition
    {
        public string SheduleWorkCompetititon => Name + "      " + TimeStart + " - " + TimeEnd;
    }
}
