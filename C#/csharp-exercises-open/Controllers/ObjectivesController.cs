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
    public class ObjectivesController : ControllerBase
    {
        private readonly UniversityContext _context;

        public ObjectivesController(UniversityContext context)
        {
            _context = context;
        }

        // GET: api/Objectives
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Objective>>> GetObjectives()
        {
          if (_context.Objectives == null)
          {
              return NotFound();
          }
            return await _context.Objectives.ToListAsync();
        }

        // GET: api/Objectives/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Objective>> GetObjective(int id)
        {
          if (_context.Objectives == null)
          {
              return NotFound();
          }
            var objective = await _context.Objectives.FindAsync(id);

            if (objective == null)
            {
                return NotFound();
            }

            return objective;
        }

        // PUT: api/Objectives/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObjective(int id, Objective objective)
        {
            if (id != objective.Id)
            {
                return BadRequest();
            }

            _context.Entry(objective).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObjectiveExists(id))
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

        // POST: api/Objectives
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Objective>> PostObjective(Objective objective)
        {
          if (_context.Objectives == null)
          {
              return Problem("Entity set 'UniversityContext.Objectives'  is null.");
          }
            _context.Objectives.Add(objective);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObjective", new { id = objective.Id }, objective);
        }

        // DELETE: api/Objectives/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteObjective(int id)
        {
            if (_context.Objectives == null)
            {
                return NotFound();
            }
            var objective = await _context.Objectives.FindAsync(id);
            if (objective == null)
            {
                return NotFound();
            }

            _context.Objectives.Remove(objective);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ObjectiveExists(int id)
        {
            return (_context.Objectives?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
