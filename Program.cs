using System;
using System.Collections.Generic;

namespace lab_3
{
    class Program
    {
        public static string[] schedule = new string[5];  //each student is assigned 5 classes from the user
        public static double[] grades = new double[5]; //1 grade for each class
        public static int z = 0;

        public static void Main(string[] args)
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
                    //RemoveStudent();
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

            } while (true);

        }

        static void CreateStudent()
        {
            Console.Clear();
            Console.WriteLine("Adding a new Student");
            Console.WriteLine("What is the students name?: ");
            string name = Console.ReadLine();

            Console.WriteLine("What is the students Age?: ");
            int age = Convert.ToInt32(Console.ReadLine());

            int idnumber = new Random().Next(1, 1000); //random student ID
            string[] schedule = { "Math", "Science", "History", "English", "Physical Ed." }; //students automatically assigned these classes
            double[] grades = new double[5];

            //new Student(name, age, schedule, idnumber, grades);
            EntireClass.ListOfStudents.Add(new Student(name, age, schedule, idnumber, grades));
            Console.WriteLine("Done! Press enter to return to main menu...");
            Console.ReadLine();

        }
        static void PrintClasses()
        {
            Console.Clear();
            Console.WriteLine("Enter the student ID you want to list classes of: ");
            int idnum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < EntireClass.ListOfStudents.Count; i++)
            {
                if (EntireClass.ListOfStudents[i].IDnumber.Equals(idnum))
                {
                    Console.WriteLine($"{EntireClass.ListOfStudents[i].Name}'s classes:");
                    Console.WriteLine("Class 1: " + EntireClass.ListOfStudents[i].Schedule[0] + "         | Grade: " + grades[0]);
                    Console.WriteLine("Class 2: " + EntireClass.ListOfStudents[i].Schedule[1] + "      | Grade: " + grades[1]);
                    Console.WriteLine("Class 3: " + EntireClass.ListOfStudents[i].Schedule[2] + "      | Grade: " + grades[2]);
                    Console.WriteLine("Class 4: " + EntireClass.ListOfStudents[i].Schedule[3] + "      | Grade: " + grades[3]);
                    Console.WriteLine("Class 5: " + EntireClass.ListOfStudents[i].Schedule[4] + " | Grade: " + grades[4]);
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
        // static void RemoveStudent()
        // {
        //     Console.WriteLine("Enter the student ID to remove: ");
        //     int idnum = Convert.ToInt32(Console.ReadLine());



        //     Console.WriteLine("Student removed. Press enter to return to main menu...");
        //     Console.ReadLine();

        //     Console.WriteLine("ID not valid. Press enter to go back...");
        //     Console.ReadLine();
        // }

        static void AddGrades()
        {
            Console.Write("Adding Grades. See students schedule for class names.");
            Console.WriteLine("");
            Console.Write("Enter the student ID you want to add grades to: ");

            int input = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < EntireClass.ListOfStudents.Count; i++)
            {
                if (EntireClass.ListOfStudents[i].IDnumber.Equals(input))
                {
                    Console.Clear();
                    Console.WriteLine("Student found: " + EntireClass.ListOfStudents[i].Name);
                    Console.WriteLine("");
                    Console.WriteLine($"Enter a grade for {EntireClass.ListOfStudents[i].Schedule[0]}: ");
                    EntireClass.ListOfStudents[i].Grades[0] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Enter a grade for {EntireClass.ListOfStudents[i].Schedule[1]}: ");
                    EntireClass.ListOfStudents[i].Grades[1] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Enter a grade for {EntireClass.ListOfStudents[i].Schedule[2]}: ");
                    EntireClass.ListOfStudents[i].Grades[2] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Enter a grade for {EntireClass.ListOfStudents[i].Schedule[3]}: ");
                    EntireClass.ListOfStudents[i].Grades[3] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Enter a grade for {EntireClass.ListOfStudents[i].Schedule[4]}: ");
                    EntireClass.ListOfStudents[i].Grades[4] = Convert.ToDouble(Console.ReadLine());

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
