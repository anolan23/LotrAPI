using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LordOfTheRingsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LordOfTheRingsAPI.Controllers
{
    [Route("api/[controller]")]
    public class CharactersController : Controller
    {

        [HttpGet]
        public IActionResult Get()
        {
            var context = new LotrDbContext();
            var characters = context.Characters.ToList();
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            using var context = new LotrDbContext();
            var character = context.Characters.Find(id);
            if (character != null)
            {
                return NotFound();
            }
            return Ok(character);
        }

        [HttpPost]
        public IActionResult Create(Character character)
        {
            try {
                using var context = new LotrDbContext();
                context.Characters.Add(character);
                context.SaveChanges();
                return Ok();
        
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

