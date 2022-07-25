using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoDEU_API;

namespace ProyectoDEU_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RespuestasController : ControllerBase
    {
        private readonly ProyectoDEUContext _context;

        public RespuestasController(ProyectoDEUContext context)
        {
            _context = context;
        }

        // GET: api/Respuestas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Respuesta>>> GetRespuesta()
        {
          if (_context.Respuesta == null)
          {
              return NotFound();
          }
            return await _context.Respuesta.ToListAsync();
        }

        // GET: api/Respuestas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Respuesta>> GetRespuesta(Guid id)
        {
          if (_context.Respuesta == null)
          {
              return NotFound();
          }
            var respuesta = await _context.Respuesta.FindAsync(id);

            if (respuesta == null)
            {
                return NotFound();
            }

            return respuesta;
        }

        // PUT: api/Respuestas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRespuesta(Guid id, Respuesta respuesta)
        {
            if (id != respuesta.Id)
            {
                return BadRequest();
            }

            _context.Entry(respuesta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RespuestaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Respuestas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Respuesta>> PostRespuesta(Respuesta respuesta)
        {
            if (_context.Respuesta == null)
            {
                return Problem("Entity set 'ProyectoDEUContext.Respuesta'  is null.");
            }
            respuesta.Id = Guid.NewGuid();
            _context.Respuesta.Add(respuesta);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RespuestaExists(respuesta.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRespuesta", new { id = respuesta.Id }, respuesta);
        }

        // DELETE: api/Respuestas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRespuesta(Guid id)
        {
            if (_context.Respuesta == null)
            {
                return NotFound();
            }
            var respuesta = await _context.Respuesta.FindAsync(id);
            if (respuesta == null)
            {
                return NotFound();
            }

            _context.Respuesta.Remove(respuesta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RespuestaExists(Guid id)
        {
            return (_context.Respuesta?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
