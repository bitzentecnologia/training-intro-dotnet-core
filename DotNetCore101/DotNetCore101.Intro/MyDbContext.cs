using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DotNetCore101.Intro
{
    class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=playground;Trusted_Connection=True;");
        }

        public DbSet<Person> People { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}
