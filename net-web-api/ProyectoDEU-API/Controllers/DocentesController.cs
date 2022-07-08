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
    public class DocentesController : ControllerBase
    {
        private readonly ProyectoDEUContext _context;

        public DocentesController(ProyectoDEUContext context)
        {
            _context = context;
        }

        // GET: api/Docentes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Docente>>> GetDocentes()
        {
          if (_context.Docentes == null)
          {
              return NotFound();
          }
            return await _context.Docentes.ToListAsync();
        }

        // GET: api/Docentes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Docente>> GetDocente(Guid id)
        {
          if (_context.Docentes == null)
          {
              return NotFound();
          }
            var docente = await _context.Docentes.FindAsync(id);

            if (docente == null)
            {
                return NotFound();
            }

            return docente;
        }

        // PUT: api/Docentes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDocente(Guid id, Docente docente)
        {
            if (id != docente.Id)
            {
                return BadRequest();
            }

            _context.Entry(docente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocenteExists(id))
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

        // POST: api/Docentes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Docente>> PostDocente(Docente docente)
        {
          if (_context.Docentes == null)
          {
              return Problem("Entity set 'ProyectoDEUContext.Docentes'  is null.");
          }
            _context.Docentes.Add(docente);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DocenteExists(docente.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDocente", new { id = docente.Id }, docente);
        }

        // DELETE: api/Docentes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDocente(Guid id)
        {
            if (_context.Docentes == null)
            {
                return NotFound();
            }
            var docente = await _context.Docentes.FindAsync(id);
            if (docente == null)
            {
                return NotFound();
            }

            _context.Docentes.Remove(docente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DocenteExists(Guid id)
        {
            return (_context.Docentes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
