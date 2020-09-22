using System;

public class Student 
{
    public static string Name;
    public static int Age;
    public static string[] Schedule;

    public int studentID { get; private set; }

    public Student(string name, int age, string[] schedule)
    {
        Name = name;
        Age = age;
        Schedule = schedule;

        studentID = new Random().Next(1, 1000);

        EntireClass.ListOfStudents.Add(this);

    }







}