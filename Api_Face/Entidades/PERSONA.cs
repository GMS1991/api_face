using System.ComponentModel.DataAnnotations;

namespace Api_Face.Entidades
{
    public class PERSONA
    {
        public int ID           { get; set; }

        [Required(ErrorMessage = "EL CUI ES REQUERIDO")]
        public string cui       { get; set; }

        [Required(ErrorMessage = "LOS NOMBRES SON REQUERIDA")]
        public string nombres   { get; set; }

        [Required(ErrorMessage = "LOS APELLIDOS SON REQUERIDA")]
        public string apellidos { get; set; }

        [Required(ErrorMessage = "LA DIRECCION ES REQUERIDA")]
        public string direccion { get; set; }

        [Required(ErrorMessage = "LA TELEFONO ES REQUERIDA")]
        [MaxLength(8)]
        public string telefono  { get; set; }

        [Required(ErrorMessage = "EL USUARIO ES REQUERIDO")]
        public string usuario { get; set; }

        [Required(ErrorMessage = "LA CLAVE ES REQUERIDA")]
        public string clave { get; set; }

        [Required (ErrorMessage ="LA IMAGEN ES REQUERIDA")]
        public string image_64  { get; set; }



    }
}
