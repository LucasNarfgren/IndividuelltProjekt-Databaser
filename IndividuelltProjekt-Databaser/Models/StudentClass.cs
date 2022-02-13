using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IndividuelltProjekt_Databaser.Models
{
    public partial class StudentClass
    {
        public int Id { get; set; }
        public int? FkclassId { get; set; }
        public int? FkstudentId { get; set; }
        public int? FkpersonnelId { get; set; }
        public int? FkgradeId { get; set; }
        public DateTime? GradeSetDate { get; set; }
        public string IsActive { get; set; }

        public virtual Class Fkclass { get; set; }
        public virtual Grade Fkgrade { get; set; }
        public virtual Personnel Fkpersonnel { get; set; }
        public virtual Student Fkstudent { get; set; }
    }
}
