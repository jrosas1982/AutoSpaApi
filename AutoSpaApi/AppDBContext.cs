using AutoSpaApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSpaApi
{
    public class AppDBContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set;}
        public DbSet<Perfil> Perfiles { get; set;}
        public DbSet<Rol> Roles { get; set;}
        public DbSet<Servicio> Servicios { get; set;}
        public DbSet<Encuesta> Encuesta { get; set; }
        public DbSet<EncuestaPorUsuario> EncuestaPorUsuario { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<DetallesCompras> DetallesCompras { get; set; }
        public DbSet<DetallesReserva> DetallesReserva { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Consulta> Consultas { get; set; }

        public AppDBContext(DbContextOptions <AppDBContext> options) : base(options)
        {
        }

        protected AppDBContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EncuestaPorUsuario>().HasKey(x => new { x.Encuestaid, x.Usuarioid });
            modelBuilder.Entity<DetallesCompras>().HasKey(s => new { s.Productoid, s.Compraid });
            modelBuilder.Entity<DetallesReserva>().HasKey(z => new { z.Servicioid, z.Reservaid});


            base.OnModelCreating(modelBuilder);
        }

        
    }
}
