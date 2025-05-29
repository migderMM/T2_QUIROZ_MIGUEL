using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
namespace T2_QUIROZ_MIGUEL.Models
{
    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del Distribuidor es obligatorio")]
        public string NombreDistribuidor { get; set; }
        [Required(ErrorMessage = "La razon social es obligatorio")]
        public string RazonSocial { get; set; }
        [Required(ErrorMessage = "El numero de Telefono es obligatorio")]
        public int Telefono { get; set; }
        //AnioInicioOperacion debe tener un rango de 1900 a 3000
        [Required(ErrorMessage = "El Año de Inicio de Operacion es Obligatorio es obligatorio")]
        [Range(1900, 3000, ErrorMessage = "El orden debe ser entre 1900 y 3000")]
        public int AnioInicioOperacion { get; set; }
        [Required(ErrorMessage = "El contacto es obligatorio")]
        public string Contacto { get; set; }
    }
}
