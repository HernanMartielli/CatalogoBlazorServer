using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CatalogoBlazorServer.Models
{
    public class MarcaVehiculo
    {
        [Key]
        public int IdMarca { get; set; }
        public string Marca { get; set; }
       // public int IdSegmento { get; set; }
    }
}
