using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frosh.Models.Repository;
using Frosh.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Frosh.Controllers
{
    public class ClassroomController : Controller
    {
        private readonly IHostingEnvironment Environment;


        public ClassroomController(IHostingEnvironment environment)
        {
            Environment = environment;

        }
        public IActionResult ClassHomePage(string cName)
        {
            string teacherEmail = Request.Cookies["email"];
           // HttpContext.Response.Cookies.Delete("classId");
            ClassroomRepository classroomRepository = new ClassroomRepository();
            Classroom myClass = classroomRepository.GetClass(teacherEmail, cName);
            HttpContext.Response.Cookies.Append("classId", myClass.Id.ToString(), new Microsoft.AspNetCore.Http.CookieOptions() { SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Lax, IsEssential = true });
            HttpContext.Response.Cookies.Append("cName", myClass.Name.ToString(), new Microsoft.AspNetCore.Http.CookieOptions() { SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Lax, IsEssential = true });

            ClassPageModel classPageModel = new ClassPageModel();
            classPageModel.Classroom = myClass;

            PostRepository postRepository = new PostRepository();
            List<Post> posts = postRepository.GetPosts(myClass.Id);
            posts.Reverse();
            classPageModel.Posts = posts;
            

            return View(model:classPageModel);
        }
        public IActionResult ClassHomePageStudent(int id)
        {
            string studentEmail = Request.Cookies["email"];
            ClassroomRepository classroomRepository = new ClassroomRepository();
            Classroom myClass = classroomRepository.GetClassById(id);

            HttpContext.Response.Cookies.Append("classId", myClass.Id.ToString(), new Microsoft.AspNetCore.Http.CookieOptions() { SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Lax, IsEssential = true });
            HttpContext.Response.Cookies.Append("cName", myClass.Name.ToString(), new Microsoft.AspNetCore.Http.CookieOptions() { SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Lax, IsEssential = true });

            ClassPageModel classPageModel = new ClassPageModel();
            classPageModel.Classroom = myClass;

            PostRepository postRepository = new PostRepository();
            List<Post> posts = postRepository.GetPosts(myClass.Id);
            posts.Reverse();
            classPageModel.Posts = posts;


            return View( "ClassHomePageStudent", model: classPageModel);
        }

        public IActionResult ShowPeople()
        {
            var classId = Request.Cookies["classId"];
            ClassroomRepository classroomRepository = new ClassroomRepository();
            List<String> studentsEmail = classroomRepository.GetStudentsEmail(int.Parse( classId));
            StudentRepository studentRepository = new StudentRepository();
            List<String> studentsName = studentRepository.GetStudentsName(studentsEmail);
            string teacherEmail = classroomRepository.GetTeacherEmail(int.Parse( classId));
            TeacherRepository teacherRepository = new TeacherRepository();
            string teacherName = teacherRepository.GetTeacherName(teacherEmail);
            ViewBag.length = studentsName.Count();
            ViewBag.teacherName = teacherName;
            return View(studentsName);
        }
        public IActionResult ShowComments(int postId)
        {
            CommentsRepository commentsRepository = new CommentsRepository();
            List<Comments> comments = commentsRepository.GetComments(postId);

            UserRepository userRepository = new UserRepository();
            List<String> userNames = new List<String>();

            foreach (var c in comments)
            {
                userNames.Add(userRepository.ReturnUsersName(c.PersonEmail));
            }
            CommentsModel commentsModel = new CommentsModel();
            comments.Reverse();
            userNames.Reverse();
            commentsModel.Comments = comments;
            commentsModel.UsersName = userNames;
            HttpContext.Response.Cookies.Append("postId", postId.ToString(), new Microsoft.AspNetCore.Http.CookieOptions() { SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Lax, IsEssential = true });


            return View("Comments",commentsModel);


        }

        [HttpGet]
        public IActionResult Classwork()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Classwork(List<IFormFile> postedFiles)
        {
            //creating uploads folder if not exist
            string wwwPath = this.Environment.WebRootPath;
            string path = Path.Combine(wwwPath, "Uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            
            foreach (var file in postedFiles)
            {
                var fileName = Path.GetFileName(file.FileName);
                var pathWithFileName = Path.Combine(path, fileName);
                using (FileStream stream = new
                    FileStream(pathWithFileName,
                    FileMode.Create))
                {
                    file.CopyTo(stream);
                    ViewBag.Message = "file uploaded successfully";
                }
                Models.File myFile = new Models.File
                {

                    CreationDate = System.DateTime.Now.ToString(),
                    Path = pathWithFileName,
                    FileName = fileName,
                    ClassroomId = int.Parse( Request.Cookies["classId"]),
                    


                };
                FileRepository fileRepository = new FileRepository();
                fileRepository.InsertFileInDb(myFile);
            }
           
            return View();
        }

        [HttpPost]
        public IActionResult UploadWork(int fileId,List<IFormFile> assignmentFiles)
        {
            //creating uploads folder if not exist
            string wwwPath = this.Environment.WebRootPath;
            string path = Path.Combine(wwwPath, "Uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }


            foreach (var file in assignmentFiles)
            {
                var fileName = Path.GetFileName(file.FileName);
                var pathWithFileName = Path.Combine(path, fileName);
                using (FileStream stream = new
                    FileStream(pathWithFileName,
                    FileMode.Create))
                {
                    file.CopyTo(stream);
                    ViewBag.Message = "file uploaded successfully";
                }
                Models.Work myWork = new Models.Work
                {

                    WorkPath = pathWithFileName,
                    WorkName = fileName,
                    FileId = fileId,
                    StudentEmail=Request.Cookies["email"].ToString(),
                    SubmissionDate = System.DateTime.Now.ToString(),






                };
                WorkRepository workRepository = new WorkRepository();
                workRepository.InsertWorkInDb(myWork);
            }

            return GetStudentFiles();
        }



        public IActionResult GetFiles()
        {
            FileRepository fileRepository = new FileRepository();
            int id =int.Parse( Request.Cookies["classId"]);
            List<Models.File> files = fileRepository.GetFiles(id);
            files.Reverse();
            if (files.Count() == 0)
                ViewBag.data = "no";
            else
                ViewBag.data = "yes";
            return View("Classwork", files);
        }

        public IActionResult GetStudentFiles()
        {
            string email = Request.Cookies["email"];
            int classId = int.Parse(Request.Cookies["classId"]);
            FileRepository fileRepository = new FileRepository();
            List<Models.File> filesOfCurrentClass = fileRepository.GetFiles(classId);
            WorkRepository workRepository = new WorkRepository();
            List<Models.File> filesToSubmit = new List<Models.File>();
            foreach(var f in filesOfCurrentClass)
            {
                if(workRepository.WorkDone(f.Id,email)==false)
                {
                    filesToSubmit.Add(f);

                }
            }
            filesToSubmit.Reverse();
            if (filesToSubmit.Count() == 0)
                ViewBag.data = "no";
            else
                ViewBag.data = "yes";
            return View("ClassworkStudent", filesToSubmit);


        }

       
    }
}