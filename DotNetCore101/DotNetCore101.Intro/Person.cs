using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCore101.Intro
{
    class Person
    {
        [Key]
        public int Id { get; set; }
        
        private string _name;
        
        [Required]
        public string Name
        {
            get { return _name; }
            set { _name = value.ToUpper(); }
        }

        [Required]
        public int Age { get; set; }

        [Required]
        public ETipo Tipo { get; set; }

//        [ForeignKey("Department")]
  
                
        public Department Department { get; set; }

        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
            Tipo = ETipo.gerente;
        }

        public Person() { }


    }


    public enum ETipo
    {
        funcionario, gerente, diretor
    }
}
