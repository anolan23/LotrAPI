using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LordOfTheRingsAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LordOfTheRingsAPI.Controllers
{
    [Route("api/[controller]")]
    public class CharactersController : Controller
    {
        List<Character> characters;
        public CharactersController()
        {
            characters = Character.CreateCharacters();
        }

        [HttpGet]
        public IActionResult Get()
        {
            // return an OkObjectResult with the data
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var character = characters.Where(c => c.Id == id).FirstOrDefault();
            if(character == null)
            {
                return NotFound();
            }
            return Ok(character);
        }

        [HttpPost]
        public IActionResult Create(Character character)
        {
            characters.Add(character);
            return Ok(characters);
        }
    }
}

