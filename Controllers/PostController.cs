using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frosh.Models.Repository;
using Frosh.Models;
namespace Frosh.Controllers
{
    public class PostController : Controller
    {
        public IActionResult DisplayComments(int id)
        {
             return RedirectToAction("ShowComments", "Classroom", new { postId = id });

        }
        public int InsertComment(string text)
        {
            Comments comments = new Comments
            {
                CommentText = text,
                PersonEmail = Request.Cookies["email"],
                CommentDate = System.DateTime.Now.ToString(),
                PostId = int.Parse(Request.Cookies["postId"]),
            };
            PostRepository postRepository = new PostRepository();
            postRepository.InsertComment(comments);
            int postId = comments.PostId;
            return postId;
           // return RedirectToAction("ShowComments", "Classroom", new { postId = postId });
        }
        public IActionResult InsertPost(string text)
        {
            Post post = new Post
            {
                PostDate = System.DateTime.Now.ToString(),
                PostText = text,
                ClassroomId = int.Parse(Request.Cookies["classId"].ToString()),
                



            };
            Console.WriteLine(text);

            PostRepository postRepository = new PostRepository();
            postRepository.InsertPost(post);
            string cName = Request.Cookies["cName"];
            

            return RedirectToAction("ClassHomePage","Classroom", new { cName = cName });
        }

       

    }
}