using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Aula223.Models
{
    public class Aula223Context : DbContext
    {
        public Aula223Context (DbContextOptions<Aula223Context> options)
            : base(options)
        {
        }

        public DbSet<Aula223.Models.Department> Department { get; set; }
    }
}
