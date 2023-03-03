using System;
using System.Collections.Generic;
using Frosh.Models;
namespace Frosh
{
    public partial class Student
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Creationdate { get; set; }
        public int ClassroomsJoined { get; set; }
        public virtual ICollection<Class> Class { get; set; }

        public virtual List<Work> Works { get; set; }


    }
}
