using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frosh.Models.Interface;

namespace Frosh.Models.Repository
{
    public class TeacherRepository:ITeacherRepo
    {
        public List<Classroom> GetClassrooms(string cookieEmail)
        {
            froshContext f2 = new froshContext();

            List<Classroom> classes = f2.Classroom.Where(c => c.TeacherEmail == $"{cookieEmail}").ToList();

            return classes;

        }
        public string GetTeacherName(string teacherEmail)
        {
            froshContext fc = new froshContext();
            return fc.Teacher.Where(t => t.Email == teacherEmail).Select(t => t.Name).FirstOrDefault();
        }
        public void AddClassroom(string cName, string section, string description,string teacherEmail)
        {

            Classroom classroom = new Classroom
            {
                Name = cName,
                Section = section,
                Description = description,
                CreationDate = System.DateTime.Now.ToString(),
                NoOfStudents = 0,
                TeacherEmail = teacherEmail

            };

            froshContext froshContext = new froshContext();
            froshContext.Classroom.Add(classroom);
            froshContext.SaveChanges();
        }
    }
}
