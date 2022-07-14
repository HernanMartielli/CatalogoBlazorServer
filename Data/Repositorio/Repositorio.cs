using CatalogoBlazorServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoBlazorServer.Data.Repositorio
{

    public class Repositorio : IRepositorio
    {
        private readonly ApplicationDbContext _context;

        public Repositorio(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<List<SegmentoVehiculo>> ObtenerSegmentosVehiculos()
        {
            return await _context.Catalogo_Segmento.ToListAsync();
        }


        public async Task<List<MarcaVehiculo>> ObtenerMarcasVehiculos()
        {
            return await _context.Catalogo_MarcaVehiculo.ToListAsync();
            //return await _context.Catalogo_MarcaVehiculo.FromSqlRaw<MarcaVehiculo>("sp_MarcaVehiculos_Get").ToListAsync();
        }


        public async Task<List<MarcaVehiculo>> ObtenerMarcaVehiculo(int IdSegmentoVehiculo)
        {
            return await _context.Catalogo_MarcaVehiculo.FromSqlRaw<MarcaVehiculo>($"sp_MarcaVehiculos_GetByIdSegmento {IdSegmentoVehiculo}" ).ToListAsync();
        }


        public async Task<List<ModeloVehiculo>> ObtenerModelosVehiculos(int IdSegmentoVehiculo, int IdMarcaVehiculo)
        {
            // return await _context.Catalogo_ModeloVehiculo.ToListAsync();
            var modelos = await _context.Catalogo_ModeloVehiculo.FromSqlRaw<ModeloVehiculo>($"sp_ModelosVehiculos_GetByIdSeg_IdMarca {IdSegmentoVehiculo}, {IdMarcaVehiculo}").ToListAsync();
            return modelos;
        }


        public Task<ModeloVehiculo> ObtenerModeloVehiculo(int IdMarcaVehiculo)
        {
            //falta crear la tabla que relacion modelo con marca en sql
            throw new NotImplementedException();
        }

        public async Task<List<VersionModelo>> ObtenerVersionesModelo(int IdSegmentoVehiculo, int IdModeloVehiculo)
        {
            var versiones = await _context.Catalogo_Vehiculos.FromSqlRaw<VersionModelo>($"sp_VersionVehiculos_GetByIdSeg_IdModelo {IdSegmentoVehiculo} , {IdModeloVehiculo}" ).ToListAsync();
            return versiones;
        }

        public async Task<List<AplicacionesModelo>> ObtenerAplicacionesModelo(int IdVehiculo)
        {
            var aplicaciones = await _context.Catalogo_Aplicaciones.FromSqlRaw<AplicacionesModelo>($"sp_AplicacionesVehiculos_GetByIdVehiculo {IdVehiculo}").ToListAsync();
            return aplicaciones;
        }

        public async Task<List<Designaciones>> ObtenerDesignaciones()
        {
           return await _context.Catalogo_Designaciones.FromSqlRaw<Designaciones>("sp_DesigancionesArticulos_Get").ToListAsync();
        }

        public async Task<List<AplicacionesDesignacion>> ObtenerAplicacionesDesignacion(int IdDesignacion)
        {
            var AplicacionesDesig = await _context.Apli.FromSqlRaw($"exec sp_ModelosVehiculos_GetByIdDesignacion {IdDesignacion}").ToListAsync();
            return AplicacionesDesig;
        }

        public async Task<List<Rubros>> ObtenerRubros()
        {
            //return await _context.Catalogo_Segmento.ToListAsync();
            System.Threading.Thread.Sleep(2000);
            return await _context.XRUBROS.ToListAsync();
        }

        public async Task<List<SubRubro>> ObtenerSubRubros(int rubro )
        {
            return await _context.XSUBRUBROS.Where(x => x.Rubro == rubro).ToListAsync();
        }

        public async Task<List<DesignacionesMedidas>> ObtenerDesignacionesMedidas(Dictionary<string, string> rubySub, Dictionary<string, string> medidas )
        {
            var DesigPorMedidas = await _context.Designaciones_Medidas.FromSqlRaw<DesignacionesMedidas>
                                        ("EXEC sp_DesigancionesArticulos_GetByMedidas {0}, {1}, {2}, {3}, {4}, {5},{6}", 
                                        rubySub["Rubro"], rubySub["Subrubro"], medidas["M1"], medidas["M2"], medidas["M3"],
                                        medidas["M4"], medidas["M5"], medidas["M6"]).ToListAsync();
        
            return DesigPorMedidas;




        }
    }
}
    