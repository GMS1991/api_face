using Api_Face.DTOs;
using Api_Face.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Api_Face.Controllers
{
    [ApiController]
    [Route("api/persona")]
    public class PersonaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("listado")]
        public async Task<ActionResult<List<PERSONA>>> Get()
        {
            var list = await _context.PERSONAS.ToListAsync();
            if (list.Count == 0 )
                return NotFound(list);
            return Ok(list);
        }

        [HttpGet("{user}/{password}")]
        public async Task<ActionResult<PERSONA>> Get(string user, string password)
        {
            var list =  await _context.PERSONAS.ToListAsync();
            
            if(list.Count == 0)
                return NotFound(list);
            
            var objpersona = list.Where(p => p.usuario == user
                                            && p.clave == password);
            if (objpersona == null)
                return NotFound();

            return Ok(objpersona);
        }

        [HttpPost("inserta")]
        public async Task<ActionResult> Post(AddPersonaDto personadto)
        {
            if (personadto == null || String.IsNullOrEmpty(personadto.image_64))
                return NotFound();

            var persona = new PERSONA();
            persona.cui         = personadto.cui;
            persona.nombres     = personadto.nombres;
            persona.apellidos   = personadto.apellidos;
            persona.direccion   = personadto.direccion;
            persona.telefono    = personadto.telefono;
            persona.usuario     = personadto.usuario;
            persona.clave       = personadto.clave;
            persona.image_64    = personadto.image_64;

            _context.Add(persona);
            await _context.SaveChangesAsync(); 
            return Ok();
        }

        [HttpPut("actualiza")]
        public async Task<ActionResult> Put(AddPersonaDto personadto)
        {
            var list = await _context.PERSONAS.ToListAsync();

            if (list.Count > 0)
            {
                var objpersona = list.Where(p => p.usuario == personadto.usuario
                                            && p.clave == personadto.clave).First();
                if (objpersona == null)
                    return NotFound();

                objpersona.cui         = personadto.cui;
                objpersona.nombres     = personadto.nombres;
                objpersona.apellidos   = personadto.apellidos;
                objpersona.direccion   = personadto.direccion;
                objpersona.telefono    = personadto.telefono;
                objpersona.usuario     = personadto.usuario;
                objpersona.clave       = personadto.clave;
                objpersona.image_64    = personadto.image_64;

                _context.Update(objpersona);
                await _context.SaveChangesAsync();
                return Ok();
            }
        
            return BadRequest();
        }

    }
}
