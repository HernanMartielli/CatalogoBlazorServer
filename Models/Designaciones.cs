using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoBlazorServer.Models
{
    public class Designaciones
    {
        [Key]
        public int IdDesignacion { get; set; }
        public string DesignacionSkfGlobal { get; set; }
    }
}
