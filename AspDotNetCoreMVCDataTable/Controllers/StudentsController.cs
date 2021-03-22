using AspDotNetCoreMVCDataTable.IService;
using AspDotNetCoreMVCDataTable.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspDotNetCoreMVCDataTable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        IStudentService _studentService = null;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }



        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return _studentService.GetStudents();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _studentService.GetById(id);
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void SaveOrUpdate([FromForm] Student student)
        {
            if (student.Id == 0) _studentService.Save(student);
            else _studentService.Update(student);
        }

       

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return _studentService.Delete(id);
        }
    }
}
