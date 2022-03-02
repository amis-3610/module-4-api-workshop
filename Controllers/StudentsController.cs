#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Workshop.Models;

namespace Api.Workshop.Controllers
{
    [ApiController]
    [Route("/students")]
    public class StudentsController : ControllerBase
    {

        private readonly RegistrarContext _context;

        public StudentsController(RegistrarContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Students);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = _context.Students.Find(id);

            if (student == null )
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

            return CreatedAtAction("GetById", new { id = student.Id }, student);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Student student)
        {
            if (id != student.Id)
            { return BadRequest(); }

            _context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Students.Any(x => x.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    // rethrow the error, let middlware handle
                    throw;
                }
            }

            return NoContent();
        }


    }
}