using System;
using System.Text;

namespace Records
{
    public record Person
    {
        public string LastName { get; }
        public string FirstName { get; }

        public Person(string first, string last) => (FirstName, LastName) = (first, last);
    }

    public record Teacher : Person
    {
        public string Subject { get; }

        public Teacher(string first, string last, string sub)
            : base(first, last) => Subject = sub;
    }

    public sealed record Student : Person
    {
        public int Level { get; }

        public Student(string first, string last, int level) : base(first, last) => Level = level;
    }

    class CompareClass
    {

        public void Compare()
        {
            var person = new Person("Bill", "Wagner");
            var student = new Student("Bill", "Wagner", 11);

            Console.WriteLine(student == person); // false
        }
    }

}


namespace ShortRecord
{

    public record Person(string FirstName, string LastName);

    public record Teacher(string FirstName, string LastName,
        string Subject)
        : Person(FirstName, LastName);

    public sealed record Student(string FirstName,
        string LastName, int Level)
        : Person(FirstName, LastName);




    public record Pet(string Name)
    {
        public void ShredTheFurniture() =>
            Console.WriteLine("Shredding furniture");
    }

    public record Dog(string Name) : Pet(Name)
    {
        public void WagTail() =>
            Console.WriteLine("It's tail wagging time");

        public override string ToString()
        {
            StringBuilder s = new();
            base.PrintMembers(s);
            return $"{s.ToString()} is a dog";
        }
    }


    class DeconstructClass
    {
        public void DeconstrucExample()
        {
            var person = new Person("Bill", "Wagner");

            var (first, last) = person;
            Console.WriteLine(first);
            Console.WriteLine(last);
        }

        public void With()
        {
            var person = new Person("Bill", "Wagner");

            Person brother = person with { FirstName = "Paul" };

            Person clone = person with { };


        }
    }
}