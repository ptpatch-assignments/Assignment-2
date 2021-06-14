namespace SchoolProject.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("TrainersPerCourse")]
    public partial class TrainersPerCourse
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TrainerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        public static void EnterTPC()
        {
            Schools2 tpcschool = new Schools2();
            TrainersPerCourse tpc = new TrainersPerCourse();
            Console.WriteLine("Give trainer ID: ");
            tpc.TrainerID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("To teach in course ID: ");
            tpc.CourseID = Convert.ToInt32(Console.ReadLine());
            tpcschool.TrainersPerCourses.Add(tpc);
            tpcschool.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu...");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void ShowAllTPC()
        {
            Schools2 tpcschool2 = new Schools2();
            List<TrainersPerCourse> tpcList = tpcschool2.TrainersPerCourses.ToList();
            foreach (var tpc in tpcList)
            {
                Console.WriteLine($"Trainer ID {tpc.TrainerID} teaches in course ID {tpc.CourseID}");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
