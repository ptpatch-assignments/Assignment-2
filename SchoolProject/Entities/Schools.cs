namespace SchoolProject.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Schools : DbContext
    {
        public Schools()
            : base("name=SchoolSettings")
        {
        }

        public virtual DbSet<Assignments> Assignments { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Trainers> Trainers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignments>()
                .HasMany(e => e.Courses)
                .WithMany(e => e.Assignments)
                .Map(m => m.ToTable("AssPerCourse").MapLeftKey("AssID").MapRightKey("CourseID"));

            modelBuilder.Entity<Courses>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.Courses)
                .HasForeignKey(e => e.CourseID);

            modelBuilder.Entity<Courses>()
                .HasMany(e => e.Students1)
                .WithMany(e => e.Courses1)
                .Map(m => m.ToTable("StudentsPerCourse").MapLeftKey("CourseID").MapRightKey("StudentID"));

            modelBuilder.Entity<Courses>()
                .HasMany(e => e.Trainers)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("TrainersPerCourse").MapLeftKey("CourseID").MapRightKey("TrainerID"));

            modelBuilder.Entity<Students>()
                .Property(e => e.TuitionFees)
                .HasPrecision(10, 2);
        }

        public static int FirstMenu()
        {
            try
            {
                Console.WriteLine("1. Enter new student.");
                Console.WriteLine("2. Enter new trainer.");
                Console.WriteLine("3. Enter new course.");
                Console.WriteLine("4. Enter new assignment.");
                Console.WriteLine("5. Enter new student per course.");
                Console.WriteLine("6. Enter new trainer per course.");
                Console.WriteLine("7. Enter new assignments per student per course. -- not implemented");
                Console.WriteLine("8. Show all students.");
                Console.WriteLine("9. Show all trainers.");
                Console.WriteLine("10. Show all courses.");
                Console.WriteLine("11. Show all assignments.");
                Console.WriteLine("12. Show all students per course.");
                Console.WriteLine("13. Show all trainers per course.");
                Console.WriteLine("14. Show all assignments per course.");
                Console.WriteLine("15. Show a list of students who are registered in more than one course.");
                Console.WriteLine();
                Console.WriteLine("Press 0 to quit.");
                Console.WriteLine();
                var selection = Console.ReadLine();
                return Convert.ToInt32(selection);
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a valid selection.");
                Console.WriteLine();
                return 100;
            }
        }
    }
}
