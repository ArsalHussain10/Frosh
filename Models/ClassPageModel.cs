using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frosh.Models
{
    public class ClassPageModel
    {
        public Classroom Classroom { get; set; }
        public List<Post> Posts { get; set; }
    }
}
