using BlazorWebAssemblyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyApp.Data
{
    public class Store
    {
        private  List<Student> _students;

        public  void SetStudents(List<Student> list)
        {
            _students = list;
        }

        public List<Student> GetStudents()
        {
            return _students;
        }

        public  Student GetStudentById(int id)
        {
            var stu = _students?.FirstOrDefault(s => s.Id == id);

            return stu;
        }
    }
}
