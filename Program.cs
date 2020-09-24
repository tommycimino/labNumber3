using System;
using System.Collections.Generic;

namespace lab_3
{
    class Program
    {
        public static string[] schedule = new string[5];  //each student is assigned 5 classes from the user
        public static double[] grades = new double[5]; //1 grade for each class
        public static int z = 0;

        static void Main(string[] args)
        {

            do
            {
            Console.WriteLine("------------------School Management------------------");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("");
            Console.WriteLine("1. Add a new student.");
            Console.WriteLine("2. Remove a student.");
            Console.WriteLine("3. Print a students classes.");
            Console.WriteLine("4. Add a grade to a students class.");
            Console.WriteLine("5. List all students in a class.");
            Console.WriteLine("6. Quit / Exit.");
            Console.Write("Pick 1-6: ");

            int userChoice = Convert.ToInt32(Console.ReadLine());


            if (userChoice.Equals(1))
            {
                CreateStudent();
                Console.Clear();
            }
            if (userChoice.Equals(2))
            {
                RemoveStudent();
                Console.Clear();
            }
            if (userChoice.Equals(3))
            {
                PrintClasses();
                Console.Clear();
            }
            if (userChoice.Equals(4))
            {
                AddGrades();
                Console.Clear();
            }
            } while(true);

        }

        public static void CreateStudent()
        {
            Console.Clear();
            Console.WriteLine("Adding a new Student");
            Console.WriteLine("What is the students name?: ");
            string name = Console.ReadLine();

            Console.WriteLine("What is the students Age?: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the students classes: ");
            Console.WriteLine("Class 1: ");
            schedule[0] = Console.ReadLine();
            Console.WriteLine("Class 2: ");
            schedule[1] = Console.ReadLine();
            Console.WriteLine("Class 3: ");
            schedule[2] = Console.ReadLine();
            Console.WriteLine("Class 4: ");
            schedule[3] = Console.ReadLine();
            Console.WriteLine("Class 5: ");
            schedule[4] = Console.ReadLine();

            int idnumber = new Random().Next(1, 1000);

            Student newkid = new Student(name, age, schedule, idnumber);
            Console.WriteLine("Done! Press enter to return to main menu...");
            Console.ReadLine();

        }
        public static void PrintClasses()
        {
            Console.WriteLine("Enter the student ID you want to list classes of: ");
            int idnum = Convert.ToInt32(Console.ReadLine());

            foreach (Student newkid in EntireClass.ListOfStudents)
            {
                if (idnum == Student.IDnumber)
                {
                    Console.WriteLine($"{Student.Name}'s classes:");
                    Console.WriteLine("Class 1: " + Student.Schedule[0] + " Grade: " + grades[0]);
                    Console.WriteLine("Class 2: " + Student.Schedule[1] + " Grade: " + grades[1]);
                    Console.WriteLine("Class 3: " + Student.Schedule[2] + " Grade: " + grades[2]);
                    Console.WriteLine("Class 4: " + Student.Schedule[3] + " Grade: " + grades[3]);
                    Console.WriteLine("Class 5: " + Student.Schedule[4] + " Grade: " + grades[4]);
                    Console.WriteLine("");
                    Console.WriteLine("Press enter to return to main menu...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Student not found, press enter to go back...");
                    Console.ReadLine();
                }
            }

        }
        public static void RemoveStudent()
        {
            Console.WriteLine("Enter the student ID to remove: ");
            int idnum = Convert.ToInt32(Console.ReadLine());

            foreach (Student newkid in EntireClass.ListOfStudents)
            {
                if ( idnum == Student.IDnumber)
                {
                    EntireClass.ListOfStudents.Remove(newkid);
                    Console.WriteLine("Student removed. Press enter to return to main menu..."); 
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("ID not valid.");
                }
            }
        }

        public static void AddGrades()
        {
            Console.Write("Adding Grades. See students schedule for class names.");
            Console.WriteLine("");
            Console.Write("Enter the student ID you want to add grades to: ");

            int input = Convert.ToInt32(Console.ReadLine());

            foreach (Student newkid in EntireClass.ListOfStudents)
            {
                if (input == newkid.studentID)
                {
                    Console.Clear();
                    Console.WriteLine("Student found: " + Student.Name);
                    Console.WriteLine("");
                    Console.WriteLine("Enter a grade for class 1: ");
                    grades[0] = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("Enter a grade for class 2: ");
                    grades[1] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter a grade for class 3: ");
                    grades[2] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter a grade for class 4: ");
                    grades[3] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter a grade for class 5: ");
                    grades[4] = Convert.ToDouble(Console.ReadLine());
                }
                else 
                {
                    Console.WriteLine("Student not found. Press enter to return to main menu...");
                    Console.ReadLine();
                }
            }       

        }
    }
}
