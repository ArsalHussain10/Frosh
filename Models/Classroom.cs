using System;
using System.Collections.Generic;
using Frosh.Models;

namespace Frosh
{
    public partial class Classroom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TeacherEmail { get; set; }
        public int NoOfStudents { get; set; }
        public string CreationDate { get; set; }
        public string Section { get; set; }
        public string Description { get; set; }
        public virtual List<Post> Post { get; set; }

        public List<File> File { get; set; }


        public Teacher TeacherEmailNavigation { get; set; }
        public IEnumerable<Class> Class { get; internal set; }
    }
}
