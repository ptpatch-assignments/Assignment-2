namespace SchoolProject.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class Trainers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trainers()
        {
            Courses = new HashSet<Courses>();
        }

        [Key]
        public int TrainerID { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string Stream { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Courses> Courses { get; set; }

        public static void EnterTrainer()
        {
            Schools trainerschool = new Schools();
            Trainers trainer = new Trainers();
            Console.WriteLine("Give new trainer's first name: ");
            trainer.FirstName = Console.ReadLine();
            Console.WriteLine("Give new trainer's last name: ");
            trainer.LastName = Console.ReadLine();
            Console.WriteLine("Give new trainer's main stream: ");
            trainer.Stream = Console.ReadLine();
            trainerschool.Trainers.Add(trainer);
            trainerschool.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu...");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void ShowAllTrainers()
        {
            Schools trainerschool = new Schools();
            List<Trainers> trainerList = trainerschool.Trainers.ToList();
            foreach (Trainers t in trainerList)
            {
                Console.WriteLine($"Trainer first name: {t.FirstName}");
                Console.WriteLine($"Trainer last name: {t.LastName}");
                Console.WriteLine($"Trainer stream: {t.Stream}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
