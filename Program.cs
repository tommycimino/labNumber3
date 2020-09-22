using System;
using System.Collections.Generic;

namespace lab_3
{
    class Program
    {
        public static string[] schedule = new string[5];
        static void Main(string[] args)
        {

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a new student.");
            Console.WriteLine("2. Remove a student.");
            // Console.WriteLine("3. Print a students classes.");
            // Console.WriteLine("4. Add a grade to a students class.");
            // Console.WriteLine("5. List all students in a class.");
            // Console.WriteLine("6. Quit / Exit.");
            Console.Write("Enter 1-6:");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateStudent();
                    break;

                    //case 2:

            }
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

            Student newkid = new Student(name, age, schedule);

        }
        public void PrintClasses()
        {
            Console.WriteLine("Enter the student ID you want to list classes of: ");
            int idnum = Convert.ToInt32(Console.ReadLine());

            foreach (Student newkid in EntireClass.ListOfStudents)
            {
                if (idnum == newkid.studentID)
                {
                    Console.WriteLine($"{Student.Name}'s classes:");
                    Console.WriteLine("Class 1: " + Student.Schedule[0]);
                    Console.Write("Class 2: " + Student.Schedule[1]);
                    Console.WriteLine("Class 3: " + Student.Schedule[2]);
                    Console.Write("Class 4: " + Student.Schedule[3]);
                    Console.WriteLine("Class 5: " + Student.Schedule[4]);
                }
            }
        }
        public static void RemoveStudent()
        {
            Console.WriteLine("Enter the student ID to remove: ");
            int idnum = Convert.ToInt32(Console.ReadLine());

            foreach (Student newkid in EntireClass.ListOfStudents)
            {
                if (newkid.studentID == idnum)
                {
                    EntireClass.ListOfStudents.Remove(newkid);
                }
            }
        }
    }
}
