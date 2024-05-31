using System.ComponentModel.DataAnnotations;

namespace TiendaWeb.Models
{
    public class Estilo
    {
        [Key]
        public int id {  get; set; }
        [Required(ErrorMessage ="Ingresa el Nombre del Estilo")]
        [Display(Name ="Nombre Estilo")]
        public string nombre { get; set; }
    }
}
