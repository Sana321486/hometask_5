using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tAdding Students");
            Console.WriteLine("--------------------------");
            Student std1= new Student (1,"Ahmad");
            Student std2 = new Student(2, "Ahsan");
            Student std3 = new Student(3, "Ali");

            Console.WriteLine("--------------------------");
            Console.WriteLine("\tAdding Teachers");
            Console.WriteLine("--------------------------");
            Teacher teacher1 = new Teacher(1, "Zain", "OOP");
            Teacher teacher2 = new Teacher(2, "Umair", "Stats");

            Console.WriteLine("--------------------------");
            Console.WriteLine("\tManging School");
            Console.WriteLine("--------------------------");
            School school = new School("NTU", "FSD", 20);

            
            Console.WriteLine("Adding Students to School");
            school.AddStudent(std1);
            school.AddStudent(std2);
            school.AddStudent(std3);


            Console.WriteLine("Assigning Grades to Students");
            teacher1.AssignGrade(std1, 98);
            teacher1.AssignGrade(std2, 74);
            teacher2.AssignGrade(std1, 50);
            teacher2.AssignGrade(std3, 43);

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\tDisplay Average of Grades of Each Students");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine($"{ std1.getName()} has Average {std1.CalculateAverageGrade()}");
            Console.WriteLine($"{std2.getName()} has Average {std2.CalculateAverageGrade()}");
            Console.WriteLine($"{std3.getName()} has Average {std3.CalculateAverageGrade()}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\tDisplay School Information");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(school.GetName());
            Console.WriteLine(school.GetLocation());

            foreach(Student std in school.GetStudent())
            {
                Console.WriteLine(std.getName() );
                Console.WriteLine(std.getstudentID());

            }

        }
    }
}
