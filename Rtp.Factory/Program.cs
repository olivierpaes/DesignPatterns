using System;
using System.Collections.Generic;

namespace Rtp.Factory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // var french = new Frenchman(); // Does not compile anymore because frenchman is inside person
            var belgian = Person.ForBelgium("1234", "B", "P", "dutch");
            var frenchman = Person.ForFrance("123", "F", "P");

            //var x = new Person.Frenchman(); 
            
            PrintPerson(belgian);
            PrintPerson(frenchman);
            
        }

        public static void PrintPerson(Person p)
        {
            Console.WriteLine(p.GetType().FullName);
            Console.WriteLine($"ssnr: {p.Ssnr}");
            Console.WriteLine($"Firstname: {p.Firstname}");
            Console.WriteLine($"Lastname: {p.Lastname}");
            Console.WriteLine($"Language: {p.Language}");
        }
    }
}