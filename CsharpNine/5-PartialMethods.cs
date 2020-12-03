using System;

var person = new Person("John");
Console.WriteLine($"{person.GetNameToLower()} - {person.GetNameToUpper()}");


partial class Person : IPerson
{
    public string GetNameToLower() => Name.ToLower();
    public partial string GetNameToUpper();
}

partial class Person : IPerson
{
    public string Name { get; }
    public Person(string name)
    {
        Name = name;
    }

    public partial string GetNameToUpper() =>
        Name.ToUpper();
}

public interface IPerson
{
    string GetNameToUpper();
}