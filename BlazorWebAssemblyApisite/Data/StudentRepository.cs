using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyApisite.Data
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> Students = new List<Student> {
                new Student{ Id=1, Name="小红", Age=10, Class="1班", Sex="女"},
                new Student{ Id=2, Name="小明", Age=11, Class="2班", Sex="男"},
                new Student{ Id=3, Name="小强", Age=12, Class="3班", Sex="男"}
        };

        public bool Add(Student student)
        {
            Students.Add(student);

            return true;
        }

        public bool Delete(int id)
        {
            var stu = Students.FirstOrDefault(s => s.Id == id);
            if (stu != null)
            {
                Students.Remove(stu);
            }

            return true;
        }

        public Student Get(int id)
        {
            return Students.FirstOrDefault(s => s.Id == id);
        }

        public List<Student> List()
        {
            return Students;
        }

        public bool Update(Student student)
        {
            var stu = Students.FirstOrDefault(s => s.Id == student.Id);
            if (stu != null)
            {
                Students.Remove(stu);
            }

            Students.Add(student);
            return true;
        }
    }
}
