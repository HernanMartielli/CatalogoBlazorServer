using CatalogoBlazorServer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoBlazorServer.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SegmentoVehiculo> Catalogo_Segmento { get; set; }
        public DbSet<MarcaVehiculo> Catalogo_MarcaVehiculo { get; set; }
        public DbSet<ModeloVehiculo> Catalogo_ModeloVehiculo { get; set; }
        public DbSet<VersionModelo> Catalogo_Vehiculos { get; set; }
        public DbSet<AplicacionesModelo> Catalogo_Aplicaciones { get; set; }
        public DbSet<Designaciones> Catalogo_Designaciones { get; set; }
        public virtual DbSet<AplicacionesDesignacion> Apli  { get; set; }

        public DbSet<Rubros> XRUBROS { get; set; }
        public DbSet<SubRubros> XSUBRUBROS { get; set; }






    }
}
