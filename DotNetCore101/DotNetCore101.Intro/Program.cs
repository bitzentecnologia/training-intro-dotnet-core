using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetCore101.Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Person> p = new List<Person>
            //{
            //    new Person(1,"José",35),
            //    new Person(2,"João",50),
            //    new Person(3,"Joaquim",48),
            //    new Person(4,"Joana",75),
            //    new Person(5,"Maria",20),
            //};

            //var f = p.Where(pp => pp.Age > 30).ToList();
            //var m = p.Select<Person, int>(u => u.Age).ToList();
            //var r = p.Count(c => c.Age > 70);
            //var s = p.Sum(c => c.Age);

            //Console.WriteLine("foo");

            MyDbContext ctx = new MyDbContext();



            //ctx.People.RemoveRange(ctx.People);

            //var dpt = Bitzen.Todo.Apictx.Departments.Find(1);


            //ctx.People.Add(new Person() { Name = "Miguel Milani Della Mura", Age = 35, Tipo = ETipo.diretor, Department = dpt });
            //ctx.People.Add(new Person() { Name = "Wellington Aparecido Della Mura", Age = 34, Tipo = ETipo.funcionario, Department = dpt });
            //ctx.People.Add(new Person() { Name = "Jaciani Carolina Milani Della Mura", Age = 34, Tipo = ETipo.gerente, Department = dpt });

            //ctx.Departments.Add(new Department() { Name = "Contábil" });
            //ctx.Departments.Add(new Department() { Name = "Recursos Humanos" });
            //ctx.Departments.Add(new Department() { Name = "Financeiro" });
            //ctx.Departments.Add(new Department() { Name = "Jurídico" });
            //ctx.Departments.Add(new Department() { Name = "Obras" });


            //var res = ctx.SaveChanges();



            //Console.WriteLine($"{res} linhas afetadas.");


            var p = ctx.People.Include(pp=>pp.Department).ToList();

            p.ForEach(pp => Console.WriteLine($"{pp.Name} trabalha no departamento {pp.Department.Name}"));

        }


    }
}
