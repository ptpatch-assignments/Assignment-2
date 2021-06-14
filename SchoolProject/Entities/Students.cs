namespace SchoolProject.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    public partial class Students
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Students()
        {
            Courses1 = new HashSet<Courses>();
        }

        [Key]
        public int StudentID { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        public decimal? TuitionFees { get; set; }

        public int? CourseID { get; set; }

        public virtual Courses Courses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Courses> Courses1 { get; set; }


        public static void EnterStudent()
        {
            Schools studentschool = new Schools();
            Students student = new Students();
            Console.WriteLine("Give new student's first name:");
            student.FirstName = Console.ReadLine();
            Console.WriteLine("Give new student's last name:");
            student.LastName = Console.ReadLine();
            Console.WriteLine("Give new student's date of birth:");
            student.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give new student's tuition fees:");
            student.TuitionFees = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Give new student's course id:");
            student.CourseID = Convert.ToInt32(Console.ReadLine());
            studentschool.Students.Add(student);
            studentschool.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu...");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void ShowAllStudents()
        {
            Schools studentschool = new Schools();
            List<Students> studentList = studentschool.Students.ToList();
            foreach(Students s in studentList)
            {
                Console.WriteLine($"Student first name: {s.FirstName}");
                Console.WriteLine($"Student last name: {s.LastName}");
                Console.WriteLine($"Student DoB: {s.DateOfBirth}");
                Console.WriteLine($"Student fees: {s.TuitionFees}");
                Console.WriteLine($"Student course id: {s.CourseID}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu...");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void ShowSpecialList()
        {
            //Schools sschool = new Schools();
            //Schools2 spcschool = new Schools2();
            //List<Students> studentsList = sschool.Students.ToList();
            //List<StudentsPerCourse> spcList = spcschool.StudentsPerCourses.ToList()
        }
    }
}
