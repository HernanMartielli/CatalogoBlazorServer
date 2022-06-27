using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CatalogoBlazorServer.Models
{
    public class AplicacionesModelo
    {
        [Key]
        public int IdAplicacion { get; set; }
        public string PosicionGrupo { get; set; }
        public string Posicion { get; set; }
        public string SubPosicion { get; set; }
        public string DesignacionSkfGlobal { get; set; }
        public string DesignacionSKF { get; set; }
        public string Observacion { get; set; }
        public int IdVehiculo { get; set; }
        public string NombreImagen { get; set; }
       
    }
}
