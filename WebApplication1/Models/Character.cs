using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Character
    {
        public int Id { get; set; }
        [DisplayName("Date Created")]
        public DateTime TimeCreated { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
    }

    public class CharContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
    }
}