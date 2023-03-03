using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Frosh.Models
{
    public class Comments
    {
        [Key]

        public int Id { get; set; }
        [Required]
        public string CommentText { get; set; }

        public string CommentDate { get; set; }

        [Required]
         public string PersonEmail { get; set; }
        public int PostId { get; set; }
        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }


    }
}
