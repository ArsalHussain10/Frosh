using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frosh.Models;
using Newtonsoft.Json;
using Frosh.Models.Repository;
using Frosh.Models.Interface;

namespace Frosh.Controllers
{
    [Serializable]
    public class TeacherController : Controller
    {
        private readonly ITeacherRepo teacherRepository;
        public TeacherController(ITeacherRepo repo)
        {
            teacherRepository = repo;  //dependacy injection
        }
        [HttpGet]
        public IActionResult HomePage()
        {
            
            if (Request.Cookies["name"]!=null)   //checking if user has loggedin or not
            {
                var cookieName = "";
                cookieName = Request.Cookies["name"];
                var cookieEmail = Request.Cookies["email"];

                //TeacherRepository teacherRepository = new TeacherRepository();
                ViewBag.myName = Request.Cookies["name"];
                List<Classroom> classes = teacherRepository.GetClassrooms(cookieEmail);
                    
                if (classes.Count() == 0)  
                    return View();

                
                return View(classes);
            }
            else
            {
                return RedirectToAction("SignIn", "User");
            }

            


        }
        [HttpGet]
        public IActionResult AddClassroom()
        {
            return RedirectToAction("SignIn", "User");
        }
        [HttpPost]
        public IActionResult AddClassroom(string cName, string section, string description)
        {
            //TeacherRepository teacherRepository = new TeacherRepository();
            teacherRepository.AddClassroom(cName, section, description, Request.Cookies["email"]);
            
            ViewBag.name = Request.Cookies["name"];
            TempData["name"] = Request.Cookies["name"].ToString();
            return RedirectToAction("HomePage","Teacher");

        }

    
    }
}