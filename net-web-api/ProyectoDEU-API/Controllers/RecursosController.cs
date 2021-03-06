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
    public class RecursosController : ControllerBase
    {
        private readonly ProyectoDEUContext _context;

        public RecursosController(ProyectoDEUContext context)
        {
            _context = context;
        }

        // GET: api/Recursos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recurso>>> GetRecursos()
        {
          if (_context.Recursos == null)
          {
              return NotFound();
          }
            return await _context.Recursos.ToListAsync();
        }

        // GET: api/Recursos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Recurso>> GetRecurso(Guid id)
        {
          if (_context.Recursos == null)
          {
              return NotFound();
          }
            var recurso = await _context.Recursos.FindAsync(id);

            if (recurso == null)
            {
                return NotFound();
            }

            return recurso;
        }

        // PUT: api/Recursos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecurso(Guid id, Recurso recurso)
        {
            if (id != recurso.Id)
            {
                return BadRequest();
            }

            _context.Entry(recurso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecursoExists(id))
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

        // POST: api/Recursos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Recurso>> PostRecurso(Recurso recurso)
        {
            if (_context.Recursos == null)
            {
                return Problem("Entity set 'ProyectoDEUContext.Recursos'  is null.");
            }
            recurso.Id = Guid.NewGuid();
            _context.Recursos.Add(recurso);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RecursoExists(recurso.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRecurso", new { id = recurso.Id }, recurso);
        }

        // DELETE: api/Recursos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecurso(Guid id)
        {
            if (_context.Recursos == null)
            {
                return NotFound();
            }
            var recurso = await _context.Recursos.FindAsync(id);
            if (recurso == null)
            {
                return NotFound();
            }

            _context.Recursos.Remove(recurso);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RecursoExists(Guid id)
        {
            return (_context.Recursos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
