using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Producto
    {
        [Required(ErrorMessage = "El Campo Código es Obligatorio")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El Campo Descripción es Obligatorio")]
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public int Existencia { get; set; }
    }
}
