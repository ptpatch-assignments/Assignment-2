namespace SchoolProject.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class Courses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Courses()
        {
            Students = new HashSet<Students>();
            Assignments = new HashSet<Assignments>();
            Students1 = new HashSet<Students>();
            Trainers = new HashSet<Trainers>();
        }

        [Key]
        public int CourseID { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(255)]
        public string Stream { get; set; }

        [StringLength(255)]
        public string CourseType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Students> Students { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assignments> Assignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Students> Students1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trainers> Trainers { get; set; }

        public static void EnterCourse()
        {
            Schools courseschool = new Schools();
            Courses course = new Courses();
            Console.WriteLine("Give new course's title: ");
            course.Title = Console.ReadLine();
            Console.WriteLine("Give new course's stream: ");
            course.Stream = Console.ReadLine();
            Console.WriteLine("Give new course's type: ");
            course.CourseType = Console.ReadLine();
            Console.WriteLine("Give new course's starting date: ");
            course.StartDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give new course's ending date: ");
            course.EndDate = Convert.ToDateTime(Console.ReadLine());
            courseschool.Courses.Add(course);
            courseschool.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu...");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void ShowAllCourses()
        {
            Schools courseschool = new Schools();
            List<Courses> courseList = courseschool.Courses.ToList();
            foreach (Courses c in courseList)
            {
                Console.WriteLine($"Course title: {c.Title}");
                Console.WriteLine($"Course stream: {c.Stream}");
                Console.WriteLine($"Course type: {c.CourseType}");
                Console.WriteLine($"Course starting date: {c.StartDate}");
                Console.WriteLine($"Course ending date: {c.EndDate}");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu...");
            Console.WriteLine();
            Console.ReadKey();
        }

    }
}
