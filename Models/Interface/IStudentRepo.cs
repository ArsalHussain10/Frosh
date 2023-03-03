using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frosh.Models.Interface
{
    public interface IStudentRepo
    {
         List<int> GetClassIds(string cookieEmail);
        List<Classroom> GetClassrooms(List<int> classIds);
         bool JoinClass(string studentEmail, int classId);
        List<String> GetStudentsName(List<String> studentsEmail);





    }
}
