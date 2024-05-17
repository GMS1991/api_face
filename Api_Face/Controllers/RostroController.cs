using Api_Face.DTOs;
using Api_Face.Entidades;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_Face.Controllers
{
    [ApiController]
    [Route("api/rostro")]
    public class RostroController : ControllerBase
    {
        private readonly ApplicationDbContext _context; 

        public RostroController(ApplicationDbContext context) 
        { 
            _context = context;
        }



        [HttpGet]
        public async Task<ActionResult<List<ROSTRO>>> Get()
        {
            return await _context.ROSTROS.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult> Post(AddRostroDto rostrodto)
        {
            if (rostrodto == null || String.IsNullOrEmpty(rostrodto.image_id))
                return NotFound();

            var rostro = new ROSTRO
            {
                request_id = rostrodto.request_id,
                time_used = rostrodto.time_used,
                face_num = rostrodto.face_num,
                image_id = rostrodto.image_id
            };
            _context.Add(rostro);
            await _context.SaveChangesAsync();
            return Ok();
        }





    }
}
