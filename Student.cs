using System;

public class Student 
{
    public static string Name;
    public static int Age;
    public static string[] Schedule;
    public static int IDnumber;

    public int studentID { get; private set; }

    public Student(string name, int age, string[] schedule, int idnumber)
    {
        Name = name;
        Age = age;
        Schedule = schedule;
        IDnumber = idnumber;

        

        EntireClass.ListOfStudents.Add(this);

        Console.WriteLine("Student added! Student ID: " + IDnumber);

    }







}