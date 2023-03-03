using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Frosh.Models
{
    public class Work
    {
        [Key]
        public int Id { get; set; }

        public string StudentEmail { get; set; }
        [ForeignKey("StudentEmail")]
        public virtual Student Student { get; set; }


        
        public int FileId { get; set; }

        [ForeignKey("FileId")]

        public virtual File File { get; set; }

        public string SubmissionDate { get; set; }

        public string WorkPath { get; set; }

        public string WorkName { get; set; }

    }
}
