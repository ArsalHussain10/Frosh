using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Frosh.Models
{
    public class Post
    {
        [Key]
        
        public int Id { get; set; }
        [Required]
        public string PostText { get; set; }

        public string PostDate { get; set; }

        public int ClassroomId { get; set; }

        [ForeignKey("ClassroomId")]
        public virtual Classroom Classroom { get; set; }

        public virtual List<Comments> Comments { get; set; }


    }
}
