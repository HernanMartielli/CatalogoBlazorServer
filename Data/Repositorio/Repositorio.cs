using CatalogoBlazorServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoBlazorServer.Data.Repositorio
{

    public class Repositorio : IRepositorio
    {
        private readonly ApplicationDbContext _context;

        public Repositorio( ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<List<SegmentoVehiculo>> ObtenerSegmentosVehiculos()
        {
            return await _context.Catalogo_Segmento.ToListAsync();
        }


        public  async Task<List<MarcaVehiculo>> ObtenerMarcasVehiculos()
        {
            return await _context.Catalogo_MarcaVehiculo.ToListAsync();
            //return await _context.Catalogo_MarcaVehiculo.FromSqlRaw<MarcaVehiculo>("sp_MarcaVehiculos_Get").ToListAsync();
        }


        public async Task<List<MarcaVehiculo>> ObtenerMarcaVehiculo(int IdSegmentoVehiculo)
        {
            return await  _context.Catalogo_MarcaVehiculo.FromSqlRaw<MarcaVehiculo>("sp_MarcaVehiculos_GetByIdSegmento {0}", IdSegmentoVehiculo).ToListAsync();
        }


        public async Task<List<ModeloVehiculo>> ObtenerModelosVehiculos(int IdSegmentoVehiculo, int IdMarcaVehiculo)
        {
            // return await _context.Catalogo_ModeloVehiculo.ToListAsync();
            var modelos = await _context.Catalogo_ModeloVehiculo.FromSqlRaw<ModeloVehiculo>("sp_ModelosVehiculos_GetByIdSeg_IdMarca {0}, {1}", IdSegmentoVehiculo, IdMarcaVehiculo).ToListAsync();
            return modelos;
        }


        public Task<ModeloVehiculo> ObtenerModeloVehiculo(int IdMarcaVehiculo)
        {
            //falta crear la tabla que relacion modelo con marca en sql
            throw new NotImplementedException();
        }

        public async Task<List<VersionModelo>> ObtenerVersionesModelo(int IdSegmentoVehiculo, int IdModeloVehiculo)
        {
            var versiones = await _context.Catalogo_Vehiculos.FromSqlRaw<VersionModelo>("sp_VersionVehiculos_GetByIdSeg_IdModelo {0}, {1}", IdSegmentoVehiculo, IdModeloVehiculo).ToListAsync();
            return versiones;
        }

        public async Task<List<AplicacionesModelo>> ObtenerAplicacionesModelo(int IdVehiculo)
        {
            var aplicaciones = await _context.Catalogo_Aplicaciones.FromSqlRaw<AplicacionesModelo>("sp_AplicacionesVehiculos_GetByIdVehiculo {0}", IdVehiculo).ToListAsync();
            return aplicaciones;
        }

        public async Task<List<Designaciones>> ObtenerDesignaciones()
        {
            return await _context.Catalogo_Designaciones.FromSqlRaw<Designaciones>("sp_DesigancionesArticulos_Get").ToListAsync();
        }

        public async Task<List<AplicacionesDesignacion>> ObtenerAplicacionesDesignacion(int IdDesignacion)
        {
            //var versiones = await _context.Catalogo_Vehiculos.FromSqlRaw<AplicacionesDesignacion>("sp_ModelosVehiculos_GetByIdDesignacion {0}", IdDesignacion).ToListAsync();
            var AplicacionesDesig = await _context.Apli.FromSqlRaw("exec sp_ModelosVehiculos_GetByIdDesignacion " + IdDesignacion).ToListAsync();
            return AplicacionesDesig;
        }
    }
}
