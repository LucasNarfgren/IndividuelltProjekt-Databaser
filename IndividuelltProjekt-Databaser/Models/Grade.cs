using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IndividuelltProjekt_Databaser.Models
{
    public partial class Grade
    {
        public Grade()
        {
            StudentClass = new HashSet<StudentClass>();
        }

        public int Id { get; set; }
        public string Grade1 { get; set; }
        public int? Value { get; set; }

        public virtual ICollection<StudentClass> StudentClass { get; set; }
    }
}
