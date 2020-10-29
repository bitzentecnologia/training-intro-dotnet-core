using Microsoft.VisualStudio.Web.CodeGeneration.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore101.ToDo.Controllers
{
    public class TodoRequest
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(100)]
        public string Details { get; set; }

        public bool Done { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
