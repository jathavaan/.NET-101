using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Application
{
    class Person
    {
        private long SSN { get; set; }
        private string FirstName { get; set; }
        private string Surname { get; set; }

        public Person(long ssn, string firstName, string surname)
        {
            SSN = ssn;
            FirstName = firstName;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{SSN} | {FirstName} {Surname}";
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            var ssn = 12070184972;
            var names = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("Jathavaan", "Shankarr"),
                new Tuple<string, string>("Shathavaan", "Jankarr")
            };

            var persons = new Person[names.Count];

            for (var i=0; i < names.Count; i++)
            {
                var name = names[i];
                var firstName = name.Item1;
                var surname = name.Item2;

                var person = new Person(ssn, firstName, surname);
                System.Console.WriteLine(person);
                ssn++;
                persons[i] = person;
            }
        }
    }
}