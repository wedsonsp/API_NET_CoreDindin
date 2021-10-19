using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiDindin.Models;

namespace ApiDindin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AulasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AulasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Aulas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aula>>> GetAulas()
        {
            return await _context.Aulas.ToListAsync();
        }

        // GET: api/Aulas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aula>> GetAula(int id)
        {
            var aula = await _context.Aulas.FindAsync(id);

            if (aula == null)
            {
                return NotFound();
            }

            return aula;
        }

        // PUT: api/Aulas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAula(int id, Aula aula)
        {
            if (id != aula.AulaId)
            {
                return BadRequest();
            }

            _context.Entry(aula).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AulaExists(id))
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

        // POST: api/Aulas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Aula>> PostAula(Aula aula)
        {
            _context.Aulas.Add(aula);
            await _context.SaveChangesAsync();

            if (aula.CursoId == 0)
            {
                aula.CursoId = aula.AulaId;
            }

            return CreatedAtAction("GetAula", new { id = aula.AulaId },  aula);
        }

        // DELETE: api/Aulas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAula(int id)
        {
            var aula = await _context.Aulas.FindAsync(id);
            if (aula == null)
            {
                return NotFound();
            }

            _context.Aulas.Remove(aula);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AulaExists(int id)
        {
            return _context.Aulas.Any(e => e.AulaId == id);
        }
    }
}
