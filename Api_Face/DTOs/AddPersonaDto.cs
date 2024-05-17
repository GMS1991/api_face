using System.ComponentModel.DataAnnotations;

namespace Api_Face.DTOs
{
    public class AddPersonaDto
    {
        [Required]
        public string cui { get; set; }

        [Required]
        public string nombres { get; set; }

        [Required]
        public string apellidos { get; set; }

        [Required]
        public string direccion { get; set; }

        [Required]
        [MaxLength(8)]
        public string telefono { get; set; }

        [Required]
        public string usuario { get; set; }

        [Required]
        public string clave { get; set; }

        [Required]
        public string image_64 { get; set; }

    }
}
