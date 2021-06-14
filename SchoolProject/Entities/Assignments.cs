namespace SchoolProject.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class Assignments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Assignments()
        {
            Courses = new HashSet<Courses>();
        }

        [Key]
        public int AssID { get; set; }

        [StringLength(510)]
        public string Descript { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SubDate { get; set; }

        public int? OralMark { get; set; }

        public int? TotalMark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Courses> Courses { get; set; }

        public static void EnterAss()
        {
            Schools assschool = new Schools();
            Assignments ass = new Assignments();
            Console.WriteLine("Give new assignment's description: ");
            ass.Descript = Console.ReadLine();
            Console.WriteLine("Give new assignment's submit date: ");
            ass.SubDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give new assignment's oral mark: ");
            ass.OralMark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give new assignment's total mark: ");
            ass.TotalMark = Convert.ToInt32(Console.ReadLine());
            assschool.Assignments.Add(ass);
            assschool.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu...");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void ShowAllAssignments()
        {
            Schools assschool = new Schools();
            List<Assignments> assList = assschool.Assignments.ToList();
            foreach (Assignments a in assList)
            {
                Console.WriteLine($"Assignment description: {a.Descript}");
                Console.WriteLine($"Assignment submit date: {a.SubDate}");
                Console.WriteLine($"Assignment oral mark: {a.OralMark}");
                Console.WriteLine($"Assignment total mark: {a.TotalMark}");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
