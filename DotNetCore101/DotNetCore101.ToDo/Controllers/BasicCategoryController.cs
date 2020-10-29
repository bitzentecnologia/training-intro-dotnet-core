using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore101.ToDo.Data;
using DotNetCore101.ToDo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore101.ToDo.Controllers
{
    [Route("api/basic")]
    [ApiController]
    public class BasicCategoryController : ControllerBase
    {

        private StoreDbContext _context;

        public BasicCategoryController(StoreDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult ReadAll()
        {
            return Ok(_context.Categories.ToList());
        }

        [HttpPost]
        public ActionResult Create([FromBody] Category model)
        {
            _context.Categories.Add(model);
            _context.SaveChanges();
            return Created("Category", new {model.Id});
        }
    }
}
