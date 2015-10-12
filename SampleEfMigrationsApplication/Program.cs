using System;
using System.Linq;
using SampleEfMigrationsApplication.Data;

namespace SampleEfMigrationsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new DataContext())
            {
                if (!ctx.Persons.Any())
                {
                    ctx.Persons.Add(new Person {Name = "John Doe"});
                    ctx.SaveChanges();
                }

                foreach (var person in ctx.Persons.ToList())
                {
                    Console.Write(person.Name);
                }
            }

            Console.ReadKey();
        }
    }
}
