using System;
using System.Collections.Generic;

namespace Frosh
{
    [Serializable]

    public partial class Teacher
    {
        public Teacher()
        {
            Classroom = new HashSet<Classroom>();
        }

        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int ClassroomsCreated { get; set; }
        public string CreationDate { get; set; }

        public ICollection<Classroom> Classroom { get; set; }
    }
}
