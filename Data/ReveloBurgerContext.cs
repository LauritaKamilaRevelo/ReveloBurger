using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReveloBurger.Models;

    public class ReveloBurgerContext : DbContext
    {
        public ReveloBurgerContext (DbContextOptions<ReveloBurgerContext> options)
            : base(options)
        {
        }

        public DbSet<ReveloBurger.Models.Burger> Burger { get; set; } = default!;

public DbSet<ReveloBurger.Models.Promo> Promo { get; set; } = default!;
    }
