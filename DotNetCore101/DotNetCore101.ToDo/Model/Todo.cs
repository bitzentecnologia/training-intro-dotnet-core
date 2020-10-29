using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore101.ToDo.Model
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Details { get; set; }

        [Required]
        public bool Done { get; set; } = false;

        [Required]
        public Category Category { get; set; }
    }
}
