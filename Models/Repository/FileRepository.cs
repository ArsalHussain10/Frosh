using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frosh.Models;

namespace Frosh.Models.Repository
{
    public class FileRepository
    {
        public void InsertFileInDb(File file)
        {
            froshContext fc = new froshContext();
            fc.File.Add(file);
            fc.SaveChanges();
        }
        public List<File> GetFiles(int id)
        {
            froshContext fc = new froshContext();
            return fc.File.Where(f => f.ClassroomId == id).ToList();
        }
    }
}
