using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frosh.Models.Repository
{
    public class PostRepository
    {
        public void InsertPost(Post post)
        {
            froshContext fc = new froshContext();
            fc.Post.Add(post);
            fc.SaveChanges();

        }
        public void InsertComment(Comments comments)
        {
            froshContext fc = new froshContext();
            fc.Comments.Add(comments);
            fc.SaveChanges();

        }
        public List<Post>GetPosts(int classId)
        {
            froshContext fc = new froshContext();
           return fc.Post.Where(p => p.ClassroomId == classId).ToList();
           
        }

    }
}
