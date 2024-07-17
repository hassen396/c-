namespace PersonLib;

public class Person
{
    public virtual void walk(){
        Console.WriteLine("the person walks");
    }
    public int age = 32;
    public string name = "kebede";

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
