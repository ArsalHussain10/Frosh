using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frosh.Models
{
    [Serializable]
    public class MyModel
    {
        public string Message { get; set; }
        public List<Classroom> Classrooms { get; set; }


    }
}
