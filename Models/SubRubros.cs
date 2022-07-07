using System.ComponentModel.DataAnnotations;

namespace CatalogoBlazorServer.Models
{
    public class SubRubros
    {
        [Key]
        public int Iden { get; set; }
        public string Detalle { get; set; }
        public int Rubro { get; set; }
        public string Imagen { get; set; }
        public string NbreMedida1 { get; set; }
        public string NbreMedida2 { get; set; }
        public string NbreMedida3 { get; set; }
        public string NbreMedida4 { get; set; }
        public string NbreMedida5 { get; set; }
        public string NbreMedida6 { get; set; }
        public string NbreInfo1 { get; set; }
        public string NbreInfo2 { get; set; }
    }
}
