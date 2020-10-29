using DotNetCore101.ToDo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DotNetCore101.ToDo.Data
{
    public class StoreDbContext : DbContext
    {

        public StoreDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Todo> Todos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ToDo;Trusted_Connection=True;");
        }
    }
}
