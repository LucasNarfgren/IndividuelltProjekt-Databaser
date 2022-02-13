using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IndividuelltProjekt_Databaser.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentClass = new HashSet<StudentClass>();
        }

        public int Id { get; set; }
        public string StudentFname { get; set; }
        public string StudentLname { get; set; }
        public int? StudentAge { get; set; }
        public string StudentGender { get; set; }
        public int? FkclassId { get; set; }
        public string SocialSecurityNumber { get; set; }

        public virtual Class Fkclass { get; set; }
        public virtual ICollection<StudentClass> StudentClass { get; set; }
    }
}
