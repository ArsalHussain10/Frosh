using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frosh.Models.Interface;

namespace Frosh.Models.Repository
{
    public class StudentRepository:IStudentRepo
    {
        public List<int> GetClassIds(string cookieEmail)
        {
            froshContext f2 = new froshContext();

            List<int> classes = f2.Class.Where(c => c.StudentEmail == $"{cookieEmail}" && c.status==true ).Select(c=>c.ClassId).ToList();

            return classes;

        }
        public List<Classroom> GetClassrooms(List<int> classIds)
        {
            froshContext fc = new froshContext();
            List<Classroom> classrooms = new List<Classroom>();
            foreach(var id in classIds)
            {
                Classroom c = fc.Classroom.Where(cl => cl.Id == id).First();
                classrooms.Add(c);

            }
            return classrooms;
        }

        public bool JoinClass(string studentEmail, int classId)
        {
            bool status = true;
            Class myClass= new Class{
                ClassId=classId,
                StudentEmail=studentEmail,
                JoiningDate= System.DateTime.Now.ToString(),
                status =status,


            };
              froshContext fr = new froshContext();

                fr.Class.Add(myClass);
                fr.SaveChanges();
                Classroom myClassroom = new Classroom();
                myClassroom=fr.Classroom.FirstOrDefault(c => c.Id == classId);
                myClassroom.NoOfStudents++;
                fr.SaveChanges();
                return true;
            


        }
        public List<String> GetStudentsName(List<String> studentsEmail)
        {
            froshContext fc = new froshContext();
            List<String> studentsName = new List<string>();
            foreach(var email in studentsEmail)
            {
                string singleName = fc.Student.Where(c => c.Email == email).Select(c => c.Name).FirstOrDefault().ToString();
                studentsName.Add(singleName);
                
            }
            return studentsName;
        }
    }
}
