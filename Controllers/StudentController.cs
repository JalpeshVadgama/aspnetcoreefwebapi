using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using CoolApi.Models;

namespace CoolApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private StudentContext _studentContext;

        public StudentController(StudentContext context)
        {
            _studentContext = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return _studentContext.Students.ToList();
        }

        ~StudentController()
        {
            _studentContext.Dispose();
        }
    }
}