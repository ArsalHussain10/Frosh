using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frosh.Models.Repository
{
    public class ClassroomRepository
    {
        public bool checkIfClassExist(int classId)
        {
            froshContext fc = new froshContext();
           var myClass= fc.Classroom.Where(c => c.Id == classId);
            if (myClass.Count() == 0)
                return false;
            return true;


        }
        public bool checkIfStudentAlreadyEnrolled(string sEmail, int classId)
        {
            froshContext fc = new froshContext();
            var myClass = fc.Class.Where(c => c.ClassId == classId && c.StudentEmail==sEmail);
            if (myClass.Count() == 0)
                return true;
            return false;
        }

       public Classroom GetClass(string teacherEmail, string cName)
        {
            froshContext fc = new froshContext();
            Classroom classroom = new Classroom();
             classroom=fc.Classroom.Where(c => c.TeacherEmail == teacherEmail && c.Name == cName).FirstOrDefault();

            return classroom;

        }
        public Classroom GetClassById(int classId) //classid is given and class object is returned
        {
            froshContext fc = new froshContext();
            Classroom classroom = new Classroom();
            classroom = fc.Classroom.Where(c => c.Id==classId).FirstOrDefault();

            return classroom;


        }
      
        public string GetTeacherEmail(int classId)
        {
            using (froshContext fc = new froshContext())
            {
                string e = fc.Classroom
                            .Where(c => c.Id == classId)
                            .Select(c => c.TeacherEmail)
                            .FirstOrDefault();
                return e != null ? e.ToString() : null;
            }
        }
        public List<String> GetStudentsEmail(int classId)
        {
            List<String> myStudents = new List<string>();
            froshContext fc = new froshContext();
            myStudents= fc.Class.Where(c => c.ClassId == classId).Select(c => c.StudentEmail).ToList<String>();
            return myStudents;

        }
    }
}
