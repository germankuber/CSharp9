
//1- Top-Level Statements
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//       Console.WriteLine("Hello, world!");
//     }
// }



// class Program
// {
//     static void Main(string[] args)
//     {
//       System.Console.WriteLine("Hello, world!");
//     }
// }



// public class Program
// {
//     public static void Main(string[] args) =>
//         System.Console.WriteLine("Hello, world!");
// }



// System.Console.WriteLine("Hello, world!");


// var param = System.String.Empty;

// if (args.Length is > 0)
//      param = args[0];

// System.Console.WriteLine($"You passed the param '{param}'");


// var name = "c#";
// System.Console.WriteLine($"{NameToUpperCase(name)}");

// string NameToUpperCase(string name) => name.ToUpper();


// var name = "c#";
// var sample = new Sample();
// System.Console.WriteLine($"{sample.NameToUpperCase(name)}");

// public class Sample
// {
//     public string NameToUpperCase(string name) => name.ToUpper();
// }


//2 - Target type object creation

// using System.Collections.Generic;

// var user = new User(email :"email");
// User user2 = new("Email");

// List<User> users = new();
// users.Add(new("email"));
// class User
// {
    
//     public string Email { get; set; }

//     public User(string email)
//     {
//         Email = email;
//     }

//     public int Age { get; set; }
// }



// class User
// {
//     public string Email { get; set; }
//     public int Edad { get; set; }

//     public User(int edad,string email)
//     {
//         Edad = edad;
//         Email = email;
//     }
//     public User()
//     {
        
//     }
//     public virtual User GetUser()=>  new User(1,"test");
// }
// class AdminUser : User{
//     public override AdminUser GetUser() => new AdminUser();

// }




//3 - Covariant Return Types