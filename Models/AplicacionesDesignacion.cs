using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoBlazorServer.Models
{
    public class AplicacionesDesignacion
    {
        [Key]
        public int IdAplicacion { get; set; }
        public int IdDesignacion { get; set; }
        public string NombreImagen { get; set; }
        public string NombreImagen2 { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string DesignacionSkfGlobal { get; set; }
        public string Cilindrada { get; set; }
        public string Combustible { get; set; }
        public string Motor { get; set; }
        public string FechaInicial { get; set; }
        public string FechaFinal { get; set; }

    }




}
