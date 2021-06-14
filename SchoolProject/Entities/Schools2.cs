namespace SchoolProject.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Schools2 : DbContext
    {
        public Schools2()
            : base("name=School2")
        {
        }

        public virtual DbSet<AssPerCourse> AssPerCourses { get; set; }
        public virtual DbSet<StudentsPerCourse> StudentsPerCourses { get; set; }
        public virtual DbSet<TrainersPerCourse> TrainersPerCourses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
