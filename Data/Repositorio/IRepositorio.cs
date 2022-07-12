using CatalogoBlazorServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoBlazorServer.Data.Repositorio
{
    public interface IRepositorio
    {
        //segmentos
        public Task<List<SegmentoVehiculo>> ObtenerSegmentosVehiculos();

        //marcas segun segmento
        public Task<List<MarcaVehiculo>> ObtenerMarcasVehiculos();
        public Task<List<MarcaVehiculo>> ObtenerMarcaVehiculo(int IdSegmentoVehiculo);

        //modelos segun marca
        public Task<List<ModeloVehiculo>> ObtenerModelosVehiculos(int IdSegmentoVehiculo, int IdMarcaVehiculo);
        public Task<ModeloVehiculo> ObtenerModeloVehiculo(int IdMarcaVehiculo );

        //versiones segun modelo y segmento
        public Task<List<VersionModelo>> ObtenerVersionesModelo(int IdSegmentoVehiculo, int IdModeloVehiculo);

        //aplicaciones segun vehiculo
        public Task<List<AplicacionesModelo>> ObtenerAplicacionesModelo(int IdVehiculo);
        public Task<List<AplicacionesDesignacion>> ObtenerAplicacionesDesignacion(int IdVehiculo);

        //Designaciones
        public Task<List<Designaciones>> ObtenerDesignaciones();

        //Rubros
        public Task<List<Rubros>> ObtenerRubros();
        public Task<List<SubRubro>> ObtenerSubRubros(int rubro);

        //DesignacionesPorMedidas
        public Task<List<DesignacionesMedidas>> ObtenerDesignacionesMedidas(Dictionary<string, string> rubySub, Dictionary<string, string> medidas);

    }
}
