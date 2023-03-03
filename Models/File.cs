using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Frosh.Models
{
    public class File
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Path { get; set; }

        public string FileName { get; set; }

        public string CreationDate { get; set; }

        public int ClassroomId { get; set; }
        [ForeignKey("ClassroomId")]
        public virtual Classroom Classroom { get; set; }

        public virtual List<Work> Works { get; set; }
    }
}
