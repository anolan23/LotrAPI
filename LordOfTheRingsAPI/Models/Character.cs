using System;
using System.ComponentModel.DataAnnotations;

namespace LordOfTheRingsAPI.Models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Gender { get; set; }
    }
}

