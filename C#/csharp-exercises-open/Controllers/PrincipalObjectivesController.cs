using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using csharp_exercises_open.DataAccess;
using csharp_exercises_open.Models.DataModels;

namespace csharp_exercises_open.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrincipalObjectivesController : ControllerBase
    {
        private readonly UniversityContext _context;

        public PrincipalObjectivesController(UniversityContext context)
        {
            _context = context;
        }

        // GET: api/PrincipalObjectives
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PrincipalObjective>>> GetPrincipalObjectives()
        {
          if (_context.PrincipalObjectives == null)
          {
              return NotFound();
          }
            return await _context.PrincipalObjectives.ToListAsync();
        }

        // GET: api/PrincipalObjectives/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PrincipalObjective>> GetPrincipalObjective(int id)
        {
          if (_context.PrincipalObjectives == null)
          {
              return NotFound();
          }
            var principalObjective = await _context.PrincipalObjectives.FindAsync(id);

            if (principalObjective == null)
            {
                return NotFound();
            }

            return principalObjective;
        }

        // PUT: api/PrincipalObjectives/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrincipalObjective(int id, PrincipalObjective principalObjective)
        {
            if (id != principalObjective.Id)
            {
                return BadRequest();
            }

            _context.Entry(principalObjective).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrincipalObjectiveExists(id))
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

        // POST: api/PrincipalObjectives
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PrincipalObjective>> PostPrincipalObjective(PrincipalObjective principalObjective)
        {
          if (_context.PrincipalObjectives == null)
          {
              return Problem("Entity set 'UniversityContext.PrincipalObjectives'  is null.");
          }
            _context.PrincipalObjectives.Add(principalObjective);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrincipalObjective", new { id = principalObjective.Id }, principalObjective);
        }

        // DELETE: api/PrincipalObjectives/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrincipalObjective(int id)
        {
            if (_context.PrincipalObjectives == null)
            {
                return NotFound();
            }
            var principalObjective = await _context.PrincipalObjectives.FindAsync(id);
            if (principalObjective == null)
            {
                return NotFound();
            }

            _context.PrincipalObjectives.Remove(principalObjective);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PrincipalObjectiveExists(int id)
        {
            return (_context.PrincipalObjectives?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
