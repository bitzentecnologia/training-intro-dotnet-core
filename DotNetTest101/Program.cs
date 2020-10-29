using System;
using System.Linq;
using System.Collections.Generic;
using DotNetTest101.Model;
namespace DotNetTest101
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            Console.WriteLine($"Hello World! {x}");


            Person p = new Person()
            {
               Name = "Wellington",
               Id = 55,
               Age = 34
            };

            Console.WriteLine(p);

            var lst = new List<Person>();
            lst.Add(new Person("Huguinho", 45));
            lst.Add(new Person("Zezinho", 12));
            lst.Add(new Person("Luizinho", 17));
            lst.Add(new Programmer("Dijkstra"));

            lst.ForEach(y =>
            {
                Console.WriteLine(y);
            });
            Console.WriteLine("----");
            var sublst = lst.Where(p => p.Age > 18).ToList();
            sublst.ForEach(y =>
            {
                Console.WriteLine(y);
            });
            var subnames = lst.Select<Person, string>(p => p.Name).ToList();
            Console.WriteLine("----");
            subnames.ForEach(y =>
            {
                Console.WriteLine(y);
            });
        }
    }
}
