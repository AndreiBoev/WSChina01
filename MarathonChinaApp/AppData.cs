using MarathonChinaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarathonChinaApp
{
    public class AppData
    {
        public static WSChina2020BaseComp01Entities Context = new WSChina2020BaseComp01Entities();
        public static Entities.User AuthorizedUser = null;
    }
}
