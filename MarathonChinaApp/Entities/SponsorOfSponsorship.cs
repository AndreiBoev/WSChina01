//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarathonChinaApp.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SponsorOfSponsorship
    {
        public int Id { get; set; }
        public int SponsorshipId { get; set; }
        public int SponsorId { get; set; }
    
        public virtual Sponsor Sponsor { get; set; }
        public virtual Sponsorship Sponsorship { get; set; }
    }
}
