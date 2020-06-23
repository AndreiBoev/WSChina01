using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarathonChinaApp.Entities
{
    public partial class Sponsorship
    {
        public string AllSponsor
        {
            get
            {
                List<SponsorOfSponsorship> sponsorOfSponsorship = SponsorOfSponsorships.ToList();
                //var sponsor = SponsorOfSponsorship.ToList();
                //List<SponsorOfSponsorship> sponsor = new List<SponsorOfSponsorship>(SponsorOfSponsorship.ToList());
                return string.Join("; ", sponsorOfSponsorship.Select(p => p.Sponsor.Name).ToArray());
            }
        }
    }
}
