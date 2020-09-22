using System;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            UserChoice();
            WhatToDo(UserChoice);
        }

        public static void WhatToDo()
        {
            if (UserChoice() == 1)
            {
                
            }
        }
        public static int UserChoice()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a new student.");
            Console.WriteLine("2. Remove a student.");
            Console.WriteLine("3. Print a students classes.");
            Console.WriteLine("4. Add a grade to a students class.");
            Console.WriteLine("5. List all students in a class.");
            Console.WriteLine("6. Quit / Exit.");


            return Convert.ToInt32(Console.ReadLine());

        }
    }
}
