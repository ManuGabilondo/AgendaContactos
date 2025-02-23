using System.ComponentModel.DataAnnotations;

namespace AgendaContactos.Models
{
    public class Contacto
    {
        public int Id { get; set; } // ID único del contacto

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }

        [Phone]
        public string Telefono { get; set; }

        public string Direccion { get; set; }

    }
}
