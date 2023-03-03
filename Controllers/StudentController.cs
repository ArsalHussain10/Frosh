using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frosh.Models.Repository;
using Frosh.Models.Interface;
namespace Frosh.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepo studentRepository;

        public StudentController(IStudentRepo repo)
        {
            studentRepository = repo;
        }
        


      
        [HttpGet]
        public IActionResult HomePage()
        {
            if (Request.Cookies["name"] != null)   //checking if user has loggedin or not
            {
                var cookieName = "";
                cookieName = Request.Cookies["name"];
                var cookieEmail = Request.Cookies["email"];

               // StudentRepository studentRepository = new StudentRepository();

                List<int> classIds = studentRepository.GetClassIds(cookieEmail);
                List<Classroom> classes = studentRepository.GetClassrooms(classIds);
                ViewBag.name = cookieName;

                if (classes.Count() == 0)
                    return View();


                return View(classes);
            }
            return RedirectToAction("SignIn", "User");

        }

        [HttpPost]
        public IActionResult JoinClass(string cId)
        {
            string studentEmail = Request.Cookies["email"];
            //StudentRepository studentRepository = new StudentRepository();
            ClassroomRepository classroomRepository = new ClassroomRepository();
            if(classroomRepository.checkIfClassExist(int.Parse(cId)))
            {
                if(classroomRepository.checkIfStudentAlreadyEnrolled(studentEmail, int.Parse(cId)))
                {
                    studentRepository.JoinClass(studentEmail, int.Parse(cId));
                }

            }
           
            return RedirectToAction("HomePage", "Student");

        }
    }
}