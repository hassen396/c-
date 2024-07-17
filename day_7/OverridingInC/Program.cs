using System;
using PersonLib;
class Student : Person
{
    public override void walk()
    {
        Console.WriteLine("Student walks");
    }
    public char grade;
    public Student(char grade, string name, int age) : base(name, age)
    {
        this.grade = grade;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int year = 2024;
        Student student = new Student('A', "smilex", 18);
        // Person student1 = new Student('A', "similexx", 12);
        student.walk();// overriding the default walk method in the Person class
        Console.WriteLine($"Student {student.name} has a grade of {student.grade} and he was born in {year - student.age}");
    }
}