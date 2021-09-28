using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FarmaciaWeb.Models;
using FarmaciaWeb.Utils;

namespace FarmaciaWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options){
            
        }
        public Persona persona{get; set;}
        public DbSet<Persona> Personas{get; set;}
        public DbSet<Producto> Productos{get; set;}
        public DbSet<Categoria> Categorias{get; set;}
    }
}
