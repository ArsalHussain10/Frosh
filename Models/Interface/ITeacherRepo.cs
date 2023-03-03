using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frosh.Models.Interface
{
    public interface ITeacherRepo
    {
        List<Classroom> GetClassrooms(string cookieEmail);
        string GetTeacherName(string teacherEmail);
        void AddClassroom(string cName, string section, string description, string teacherEmail);




    }
}
