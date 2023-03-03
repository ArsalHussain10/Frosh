using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frosh.Models.Repository
{
    public class CommentsRepository
    {
        public List<Comments> GetComments(int postId)
        {
            froshContext fc = new froshContext();
            return fc.Comments.Where(c => c.PostId == postId).ToList();
        }
    }
}
