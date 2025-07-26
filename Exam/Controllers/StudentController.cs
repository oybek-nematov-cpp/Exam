using Exam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Exam.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private static List<Students> student = new List<Students>
        {
            new Students
            {
                Id = 1,
                FullName = "Oybek",
                BirthDate = 1,

            },
           

        };

        public static List<Students> Student { get => student; set => student = value; }

        [HttpPost] 
        public ActionResult<List<Students>> PostStudnets([FromBody] Students student)
        {
            
            Students? students = student;

            if (student is not null)
            {
                return Conflict();
            }

         //   Students.Add(student);
            return StatusCode(201, students);
        }

        [HttpGet] 
        public ActionResult<List<Students>> GetStudent([FromQuery] int minId = 1)
        {
            return Ok(Student.FindAll(c => c.Id >= 2));
        }

        [HttpGet("{id}")] 
        public ActionResult<List<Students>> GetStudentById(int id)
        {
         
           
            Students students = student.FirstOrDefault(s => s.Id == id);


            if (student is null)
            {
                return NotFound();
            }

            return Ok(students);
        }

        [HttpPut]
        public ActionResult<Students> PutStudent([FromBody] Students  student)
        {
            Students students = student; 

            if (student is null)
            {
                return NotFound();
            }

            students.FullName=student.FullName;
            students.BirthDate=student.BirthDate;
            students.Id=student.Id;

          
            return Ok(students);
        }

        [HttpDelete("{id}")] 
        public ActionResult<Students> DeleteById(int id)
        {
            Students? students = student.FirstOrDefault(c => c.Id == id);

            if (students is null)
            {
                return NotFound();
            }

          //  Students.Remove(students);
            return Ok(students);
        }

    }
}
