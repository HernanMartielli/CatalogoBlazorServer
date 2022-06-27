using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CatalogoBlazorServer.Models
{
    public class VersionModelo
    {
        [Key]
        public int IdVehiculo { get; set; }
        public string Version { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
    }
}
