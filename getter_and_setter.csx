private class Person
{
    private string name;
    public string Name
    {
        get { return name; }
        set
        { Name = value; }
    }
    public static string Jain()
    {
        var john = new Person();
        john.name = "john";
        return john.name;
    }
}
Console.WriteLine(Person.Jain());