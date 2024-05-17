using System.ComponentModel.DataAnnotations;

namespace Api_Face.Entidades
{
    public class ROL_USUARIO
    {
        [Required(ErrorMessage = "ID ROL ES REQUERIDO")]  
        public int id_rol { get; set; }

        [Required(ErrorMessage = "DESCRIPCION ES REQUERIDO")]
        public string descripcion   { get; set; }

        [Required(ErrorMessage = "ESTADO ES REQUERIDO")]
        public bool estado  { get; set; }

        [Required(ErrorMessage = "FECHA CREACION ES REQUERIDA")]
        public string fecha_creacion     { get; set; }   
    }
}
