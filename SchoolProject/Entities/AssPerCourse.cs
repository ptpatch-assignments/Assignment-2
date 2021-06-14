namespace SchoolProject.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("AssPerCourse")]
    public partial class AssPerCourse
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AssID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        public static void EnterAPC()
        {
            Schools2 apcschool = new Schools2();
            AssPerCourse apc = new AssPerCourse();
            Console.WriteLine("Give assignment ID: ");
            apc.AssID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("For course ID: ");
            apc.CourseID = Convert.ToInt32(Console.ReadLine());
            apcschool.AssPerCourses.Add(apc);
            apcschool.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu...");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void ShowAllAPC()
        {
            Schools2 apcschool2 = new Schools2();
            List<AssPerCourse> apcList = apcschool2.AssPerCourses.ToList();
            foreach (var apc in apcList)
            {
                Console.WriteLine($"Assignment ID {apc.AssID} in course ID {apc.CourseID}");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
