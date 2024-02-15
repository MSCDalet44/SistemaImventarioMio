using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El Campo Nombre es REQUERIDO")]
        [MaxLength(60,ErrorMessage ="El Nombre no debe de exceder de 60 Caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Campo Descripción es REQUERIDO")]
        [MaxLength(100, ErrorMessage = "La Descripción no debe de exceder de 100 Caracteres")]
        public string Descripcion  { get; set; }
        [Required]
        public bool Estado { get; set; }
    }
}
