using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;

namespace MarathonChinaApp.Entities
{
    public partial class User
    {
        public string Greeting
        {
            get
            {
                string greeting = null;
                string gender = (AppData.AuthorizedUser.GenderId == 1) ? "Mr. " : "Mrs. ";
                string timeName = null;
                if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 6)
                {
                    timeName = "Good Night, ";
                }
                else if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
                {
                    timeName = "Good Morning, ";
                }
                else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
                {
                    timeName = "Good Afternoon, ";
                }
                else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 23)
                {
                    timeName = "Good Evening, ";
                }
                greeting = timeName + gender + AppData.AuthorizedUser.FirstName.ToString();
                return greeting;
            }
        }
    }
}