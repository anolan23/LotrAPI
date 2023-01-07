using System;
using Microsoft.EntityFrameworkCore;

namespace LordOfTheRingsAPI.Models
{
	public class LotrDbContext: DbContext
	{
        public DbSet<Character> characters { get; set; }
    }
}

