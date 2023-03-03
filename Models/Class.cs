using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frosh.Models;

namespace Frosh
{
    public partial class Class
    {
        public int ClassId { get; set; }
        public int SrNo { get; set; }
        public string StudentEmail { get; set; }
        public bool status { get; set; }
        public string JoiningDate { get; set; }
        public virtual Student Student { get; set; }
        public virtual Classroom Classroom { get; set; }




    }
}
