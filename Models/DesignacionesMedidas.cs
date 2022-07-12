using System.ComponentModel.DataAnnotations;

namespace CatalogoBlazorServer.Models
{
    public class DesignacionesMedidas
    {
        
        [Key]
        public int Grupo { get; set; } 
        public string foto { get; set; }
        public string plano { get; set; }
        public string imagenSubrubro { get; set; }
        public string Designacion { get; set; }
        public string Rubro { get; set; }
        public string SubRubro { get; set; }
        public decimal M1 { get; set; }
        public decimal M2 { get; set; }
        public decimal M3 { get; set; }
        public decimal M4 { get; set; }
        public decimal M5 { get; set; }
        public decimal M6 { get; set; }
        public string I1 { get; set; }
        public string I2 { get; set; }
        


    }
}
