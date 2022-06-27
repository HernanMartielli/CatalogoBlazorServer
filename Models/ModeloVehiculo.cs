using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CatalogoBlazorServer.Models
{
    public class ModeloVehiculo
    {
        [Key]
        public int IdModelo { get; set; }
        public string Modelo { get; set; }
        //public int IdMarca { get; set; }

    }

   
}
