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
                Console.Clear();
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

                int userChoice; // = Convert.ToInt32(Console.ReadLine());

                while (!int.TryParse(Console.ReadLine(), out userChoice)) // if the input is invalid
                {
                    Console.Write("Invalid option. Pick 1-6: ");
                }
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
                if (userChoice.Equals(5))
                {
                    ListStudents();
                    Console.Clear();

                }
                if (userChoice.Equals(6))
                {
                    break;
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
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {

                Console.WriteLine("You entered an invalid Age");
                Console.Write("Enter age: ");
            }


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
                    Console.WriteLine("Class 1: " + EntireClass.ListOfStudents[i].Schedule[0] + "         | Grade: " + EntireClass.ListOfStudents[i].Grades[0]);
                    Console.WriteLine("Class 2: " + EntireClass.ListOfStudents[i].Schedule[1] + "      | Grade: " + EntireClass.ListOfStudents[i].Grades[1]);
                    Console.WriteLine("Class 3: " + EntireClass.ListOfStudents[i].Schedule[2] + "      | Grade: " + EntireClass.ListOfStudents[i].Grades[2]);
                    Console.WriteLine("Class 4: " + EntireClass.ListOfStudents[i].Schedule[3] + "      | Grade: " + EntireClass.ListOfStudents[i].Grades[3]);
                    Console.WriteLine("Class 5: " + EntireClass.ListOfStudents[i].Schedule[4] + " | Grade: " + EntireClass.ListOfStudents[i].Grades[4]);
                    Console.WriteLine("");
                    Console.WriteLine("Press enter to return to main menu...");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Student not found, press enter to go back...");
                    Console.ReadLine();
                }
            }


        }

        static void ListStudents() //couldnt figure this out at all so it just lists the number of students in the class
        {
            Console.Clear();
            Console.WriteLine("1. Math");
            Console.WriteLine("2. Science");
            Console.WriteLine("3. History");
            Console.WriteLine("4. English");
            Console.WriteLine("5. Physical ED.");
            Console.Write("Pick the class you want to see the students of: ");
            int input = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (input.Equals(1))
                {
                    Console.WriteLine("Students in Math:");
                    Console.WriteLine(EntireClass.ListOfStudents.Count);
                    Console.WriteLine("");
                    Console.WriteLine("Press enter to go back...");
                    Console.ReadLine();
                    break;
                }
                if (input.Equals(2))
                {
                    Console.WriteLine("Students in Science:");
                    Console.WriteLine(EntireClass.ListOfStudents.Count);
                    Console.WriteLine("");
                    Console.WriteLine("Press enter to go back...");
                    Console.ReadLine();
                    break;

                }
                if (input.Equals(3))
                {
                    Console.WriteLine("Students in History:");
                    Console.WriteLine(EntireClass.ListOfStudents.Count);
                    Console.WriteLine("");
                    Console.WriteLine("Press enter to go back...");
                    Console.ReadLine();
                    break;

                }
                if (input.Equals(4))
                {
                    Console.WriteLine("Students in English:");
                    Console.WriteLine(EntireClass.ListOfStudents.Count);
                    Console.WriteLine("");
                    Console.WriteLine("Press enter to go back...");
                    Console.ReadLine();
                }
                if (input.Equals(5))
                {
                    Console.WriteLine("Students in Physical ED:");
                    Console.WriteLine(EntireClass.ListOfStudents.Count);
                    Console.WriteLine("");
                    Console.WriteLine("Press enter to go back...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Not valid. Press enter to go back...");
                    Console.ReadLine();
                }
            } while (true);

        }
        static void RemoveStudent()
        {
            Console.Clear();
            Console.WriteLine("Enter the student ID to remove: ");
            int idnum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < EntireClass.ListOfStudents.Count; i++)

                if (EntireClass.ListOfStudents[i].IDnumber.Equals(idnum))
                {
                    Console.WriteLine($"Student {EntireClass.ListOfStudents[i].Name} removed.");
                    EntireClass.ListOfStudents.RemoveAt(i);
                    Console.WriteLine("Press enter to go back to main menu...");
                    Console.ReadLine();
                    break;
                }
                else if (EntireClass.ListOfStudents.Count == 0)
                {
                    Console.WriteLine("No students in the system.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Student not found. Press enter to go back...");
                    Console.ReadLine();
                }
        }

        static void AddGrades() //add grades to the grades[] array and then u can see them in PrintClasses()
        {
            Console.Clear();
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

                    Console.WriteLine($"Grades entered for {EntireClass.ListOfStudents[i].Name}. Press enter to return to main menu...");
                    Console.ReadLine();
                    break;

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
