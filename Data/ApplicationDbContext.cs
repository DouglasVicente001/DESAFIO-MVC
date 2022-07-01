using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VirtualMagazine.Models;

namespace VirtualMagazine.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {   
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<UnidadeDeMedida> UnidadeDeMedidas { get; set; }
        public DbSet<Igrediente> Igredientes { get; set; }
   
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
