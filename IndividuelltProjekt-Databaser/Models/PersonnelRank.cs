using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IndividuelltProjekt_Databaser.Models
{
    public partial class PersonnelRank
    {
        public PersonnelRank()
        {
            Personnel = new HashSet<Personnel>();
        }

        public int Id { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Personnel> Personnel { get; set; }
    }
}
