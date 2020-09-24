using System;

public class Student 
{
    public string Name;
    public int Age;
    public string[] Schedule = {"Math", "Science", "History", "English", "Physical Ed."};
    public int IDnumber;
    public double[] Grades = new double[5]; // 5 grades bc 5 classes

    public int studentID { get; private set; }

    public Student(string name, int age, string[] schedule, int idnumber, double[] grades)
    {
        Name = name;
        Age = age;
        Schedule = schedule;
        IDnumber = idnumber;
        Grades = grades;

        

        //EntireClass.ListOfStudents.Add(this);

        Console.WriteLine("Student added! Student ID: " + IDnumber); // prints student id for the user

    }







}