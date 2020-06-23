using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarathonChinaApp.Entities
{
    public partial class Championship
    {
        public string FullNameEvent => (Id == 0) ? Name : Year + " - " + Name;  
    }
}
