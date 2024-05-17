using System.ComponentModel.DataAnnotations;

namespace Api_Face.Entidades
{
    public class ROSTRO
    {
        [Required(ErrorMessage = "REQUEST_ID ES REQUERIDO")]  
        public string request_id { get; set; }

        [Required(ErrorMessage = "TIME_USED ES REQUERIDO")]
        public int time_used    { get; set; }

        [Required(ErrorMessage = "IMAGE_ID ES REQUERIDO")]
        public string image_id  { get; set; }

        [Required(ErrorMessage = "FACE_NUM ES REQUERIDA")]
        public int face_num     { get; set; }   
    }
}
