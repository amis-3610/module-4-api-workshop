using Microsoft.AspNetCore.Mvc;
using Api.Workshop.Models;

namespace Api.Workshop.Controllers
{
    [ApiController]
    [Route("/students")]
    public class StudentsController : ControllerBase
    {
        // create a simple hard-coded array of students
        private List<Student> students = new List<Student>()
            {
                new Student{Id = 1, Name = "Tony Stark"},
                new Student{Id = 2, Name = "Bruce Banner"},
                new Student{Id = 3, Name = "Natasha Romanoff"}
            };         
            
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = students.FirstOrDefault(x => x.Id == id);

            if (student == null )
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            if (student == null)
            {
                return BadRequest();
            }

            // create the id
            var id = students.Max(x => x.Id) + 1;
            student.Id = id;
            students.Add(student);

            return Ok(student);

        }

    }
}