using ServiceDepartamentosRDSMySql.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDepartamentosRDSMySql.Data
{
    public class CaraoqueContext :  DbContext
    {
        public CaraoqueContext(DbContextOptions<CaraoqueContext> options) : base(options)
        { }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Artista> Artistas { get; set; }

        public DbSet<Cancion> Cancion { get; set; }

        public DbSet<Genero> Generos { get; set; }

    }
}
