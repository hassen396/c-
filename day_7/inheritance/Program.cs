using System;
using PersonLib;
class Teacher : Person
{
    public string subject;
    public int salary;
    public Teacher(string subject, int salary, string name, int age):base(name, age)
    {
        
        this.subject = subject;
        this.salary = salary;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Teacher teacher = new Teacher("Mathematics", 5000, "Abebe", 23);
        Console.WriteLine($"Teacher {teacher.name} teaches {teacher.subject} and earns {teacher.salary} per month");
    }

}