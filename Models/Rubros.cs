using System.ComponentModel.DataAnnotations;

namespace CatalogoBlazorServer.Models
{
    public class Rubros
    {
        [Key]
        public int Iden { get; set; }
        public string Detalle { get; set; }
        
    }
}
