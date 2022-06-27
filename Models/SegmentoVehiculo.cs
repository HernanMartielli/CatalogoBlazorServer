using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CatalogoBlazorServer.Models
{
    public class SegmentoVehiculo
    {
        [Key]
        public int IdSegmento { get; set; }
        public string Segmento { get; set; }
    }
}
