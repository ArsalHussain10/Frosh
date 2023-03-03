using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frosh.Models.Repository
{
    public class WorkRepository
    {
        public bool WorkDone(int FileId, string studentEmail)
        {
            froshContext fc = new froshContext();
            return  fc.Works.Any(w => w.FileId == FileId && w.StudentEmail == studentEmail);
            
        }
        public void InsertWorkInDb(Work work)
        {
            froshContext fc = new froshContext();
            fc.Works.Add(work);
            fc.SaveChanges();
        }

    }
}
