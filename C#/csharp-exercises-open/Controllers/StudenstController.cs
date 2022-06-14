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
    public class StudenstController : ControllerBase
    {
        private readonly UniversityContext _context;

        public StudenstController(UniversityContext context)
        {
            _context = context;
        }

        // GET: api/Studenst
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudenst()
        {
          if (_context.Students == null)
          {
              return NotFound();
          }
            return await _context.Students.ToListAsync();
        }

        // GET: api/Studenst/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
          if (_context.Students == null)
          {
              return NotFound();
          }
            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }

        // PUT: api/Studenst/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Student student)
        {
            if (id != student.Id)
            {
                return BadRequest();
            }

            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
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

        // POST: api/Studenst
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
          if (_context.Students == null)
          {
              return Problem("Entity set 'UniversityContext.Studenst'  is null.");
          }
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudent", new { id = student.Id }, student);
        }

        // DELETE: api/Studenst/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            if (_context.Students == null)
            {
                return NotFound();
            }
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentExists(int id)
        {
            return (_context.Students?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [Route("older/")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudentsOlder()
        {
          if (_context.Students == null)
          {
              return NotFound();
          }
            return await _context.Students.Select(x => x)
                            .Where(x => DateTime.Now.Year-x.Dob.Year >= 18)
                            .ToListAsync();
        }

        [Route("onemorecourse/")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudentsOneMoreCourse()
        {
          if (_context.Students == null)
          {
              return NotFound();
          }
            return await _context.Students.Select(x => x)
                            .Where(x => x.Courses.Any())
                            .ToListAsync();
        
        }
    }
}
