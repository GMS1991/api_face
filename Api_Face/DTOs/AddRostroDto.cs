using System.ComponentModel.DataAnnotations;

namespace Api_Face.DTOs
{
    public class AddRostroDto
    {

        [Required]
        public string request_id { get; set; }

        [Required]
        public int time_used { get; set; }

        [Required]
        public string image_id { get; set; }

        [Required]
        public int face_num { get; set; }
    }
}
