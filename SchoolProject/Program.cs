using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int choice = 100;
                do
                {
                    choice = Schools.FirstMenu();
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine();
                            Students.EnterStudent();
                            break;
                        case 2:
                            Console.WriteLine();
                            Trainers.EnterTrainer();
                            break;
                        case 3:
                            Console.WriteLine();
                            Courses.EnterCourse();
                            break;
                        case 4:
                            Console.WriteLine();
                            Assignments.EnterAss();
                            break;
                        case 5:
                            Console.WriteLine();
                            StudentsPerCourse.EnterSPC();
                            break;
                        case 6:
                            Console.WriteLine();
                            TrainersPerCourse.EnterTPC();
                            break;
                        case 7:
                            Console.WriteLine();
                            AssPerCourse.EnterAPC();
                            break;
                        case 8:
                            Console.WriteLine();
                            Students.ShowAllStudents();
                            break;
                        case 9:
                            Console.WriteLine();
                            Trainers.ShowAllTrainers();
                            break;
                        case 10:
                            Console.WriteLine();
                            Courses.ShowAllCourses();
                            break;
                        case 11:
                            Console.WriteLine();
                            Assignments.ShowAllAssignments();
                            break;
                        case 12:
                            Console.WriteLine();
                            StudentsPerCourse.ShowAllSPC();
                            break;
                        case 13:
                            Console.WriteLine();
                            TrainersPerCourse.ShowAllTPC();
                            break;
                        case 14:
                            Console.WriteLine();
                            AssPerCourse.ShowAllAPC();
                            break;
                        case 15:
                            Console.WriteLine();
                            Students.ShowSpecialList();
                            break;
                        default:
                            break;
                    }
                } while (choice != 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
