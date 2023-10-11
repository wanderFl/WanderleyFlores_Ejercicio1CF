using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WanderleyFlores_Ejercicio1CF.Models;

namespace WanderleyFlores_Ejercicio1CF.Data
{
    public class WanderleyFlores_Ejercicio1CFContext : DbContext
    {
        public WanderleyFlores_Ejercicio1CFContext (DbContextOptions<WanderleyFlores_Ejercicio1CFContext> options)
            : base(options)
        {
        }

        public DbSet<WanderleyFlores_Ejercicio1CF.Models.Burger> Burger { get; set; } = default!;
    }
}
