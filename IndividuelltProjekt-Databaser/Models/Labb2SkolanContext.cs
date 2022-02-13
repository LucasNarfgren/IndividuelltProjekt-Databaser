using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IndividuelltProjekt_Databaser.Models
{
    public partial class Labb2SkolanContext : DbContext
    {
        public Labb2SkolanContext()
        {
        }

        public Labb2SkolanContext(DbContextOptions<Labb2SkolanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Personnel> Personnels { get; set; }
        public virtual DbSet<PersonnelRank> PersonnelRanks { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentClass> StudentClasses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = LUKKAN-DESKTOP; Initial Catalog = Labb-2-Skolan; Integrated Security = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.Property(e => e.ClassName).HasMaxLength(50);
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.Property(e => e.Grade1)
                    .HasColumnName("Grade")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Personnel>(entity =>
            {
                entity.Property(e => e.FkroleId).HasColumnName("FKroleId");

                entity.Property(e => e.HiringDate)
                    .HasColumnName("hiringDate")
                    .HasColumnType("date");

                entity.Property(e => e.PFirstName)
                    .HasColumnName("pFirstName")
                    .HasMaxLength(50);

                entity.Property(e => e.PLastName)
                    .HasColumnName("pLastName")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Fkrole)
                    .WithMany(p => p.Personnel)
                    .HasForeignKey(d => d.FkroleId)
                    .HasConstraintName("FK_Personnel_PersonnelRank");
            });

            modelBuilder.Entity<PersonnelRank>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Role).HasMaxLength(50);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.FkclassId).HasColumnName("FKclassId");

                entity.Property(e => e.SocialSecurityNumber)
                    .HasColumnName("socialSecurityNumber")
                    .HasMaxLength(12);

                entity.Property(e => e.StudentAge).HasColumnName("studentAge");

                entity.Property(e => e.StudentFname)
                    .HasColumnName("studentFName")
                    .HasMaxLength(50);

                entity.Property(e => e.StudentGender)
                    .HasColumnName("studentGender")
                    .HasMaxLength(50);

                entity.Property(e => e.StudentLname)
                    .HasColumnName("studentLName")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Fkclass)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.FkclassId)
                    .HasConstraintName("FK_Student_Class");
            });

            modelBuilder.Entity<StudentClass>(entity =>
            {
                entity.Property(e => e.FkclassId).HasColumnName("FKclassId");

                entity.Property(e => e.FkgradeId).HasColumnName("FKgradeId");

                entity.Property(e => e.FkpersonnelId).HasColumnName("FKpersonnelId");

                entity.Property(e => e.FkstudentId).HasColumnName("FKstudentId");

                entity.Property(e => e.GradeSetDate)
                    .HasColumnName("gradeSetDate")
                    .HasColumnType("date");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Fkclass)
                    .WithMany(p => p.StudentClass)
                    .HasForeignKey(d => d.FkclassId)
                    .HasConstraintName("FK_StudentClass_Class");

                entity.HasOne(d => d.Fkgrade)
                    .WithMany(p => p.StudentClass)
                    .HasForeignKey(d => d.FkgradeId)
                    .HasConstraintName("FK_StudentClass_Grade");

                entity.HasOne(d => d.Fkpersonnel)
                    .WithMany(p => p.StudentClass)
                    .HasForeignKey(d => d.FkpersonnelId)
                    .HasConstraintName("FK_StudentClass_Personnel");

                entity.HasOne(d => d.Fkstudent)
                    .WithMany(p => p.StudentClass)
                    .HasForeignKey(d => d.FkstudentId)
                    .HasConstraintName("FK_StudentClass_Student");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
