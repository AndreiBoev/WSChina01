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
    
    public partial class Volunteer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GenderId { get; set; }
        public int OccupationCityId { get; set; }
        public int ProvinceCityId { get; set; }
        public int CompetitionOfChampionshipId { get; set; }
    
        public virtual City City { get; set; }
        public virtual City City1 { get; set; }
        public virtual CompetitionOfChampionship CompetitionOfChampionship { get; set; }
        public virtual Gender Gender { get; set; }
    }
}