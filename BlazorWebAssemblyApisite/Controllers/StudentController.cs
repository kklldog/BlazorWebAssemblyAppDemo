using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using BlazorWebAssemblyApisite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlazorWebAssemblyApisite.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public List<Student> Get()
        {
            return _studentRepository.List();
        }

        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _studentRepository.Get(id);
        }

        [HttpPost]
        public Student Post(Student model)
        {
            _studentRepository.Add(model);

            return model;
        }

        [HttpPut]
        public Student Put(Student model)
        {
            _studentRepository.Update(model);

            return model;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _studentRepository.Delete(id);
        }
    }
}
