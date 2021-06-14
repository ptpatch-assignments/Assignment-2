namespace SchoolProject.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("StudentsPerCourse")]
    public partial class StudentsPerCourse
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        public static void EnterSPC()
        {
            Schools2 spcschool = new Schools2();
            StudentsPerCourse spc = new StudentsPerCourse();
            Console.WriteLine("Give student ID: ");
            spc.StudentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("To sign up in course ID: ");
            spc.CourseID = Convert.ToInt32(Console.ReadLine());
            spcschool.StudentsPerCourses.Add(spc);
            spcschool.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu...");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void ShowAllSPC()
        {
            Schools2 spcschool2 = new Schools2();
            List<StudentsPerCourse> spcList = spcschool2.StudentsPerCourses.ToList();
            foreach (var spc in spcList)
            {
                Console.WriteLine($"Student ID {spc.StudentID} belongs in course ID {spc.CourseID}");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
