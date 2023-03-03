using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frosh.Models;
using Newtonsoft.Json;
using System.Web;
using Frosh.Models.Repository;
using Frosh.Models.Interface;

namespace Frosh.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepo userRepository;
        public UserController(IUserRepo repo)
        {
            userRepository = repo;  //dependancy injection
        }
        [HttpGet]
        public ViewResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SignUp(string email, string name, string password, string accType)
        {
           // UserRepository userRepository = new UserRepository();
            if(userRepository.SignUp(name, email, password, accType))
            {
                return View("SignIn");
            }
            else
            {
                return View("SignUp");
            }

           

        }

        [HttpGet]
        public ViewResult SignIn()
        {

            return View();

        }

        
        public IActionResult Logout()
        {
            foreach (var cookie in HttpContext.Request.Cookies.Keys)
            {
                HttpContext.Response.Cookies.Delete(cookie);
            }

            return View("SignIn");

        }

        [HttpPost]
        public IActionResult SignIn(string email, string password)
        {
           // UserRepository userRepository = new UserRepository();
            object accountType = userRepository.SignIn(email, password);
            if(accountType is Teacher)
            {
                Teacher t = accountType as Teacher;  //converting object into Teacher Type(if teacher has logged in)
                ViewBag.name = t.Name.ToString();
                ViewBag.email = email.ToString();
                TempData["name"] = t.Name.ToString();
                TempData["email"] = t.Email.ToString();



                //setting cookies
                HttpContext.Response.Cookies.Append("name", t.Name, new Microsoft.AspNetCore.Http.CookieOptions() { SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Lax, IsEssential = true });
                HttpContext.Response.Cookies.Append("classrooms_created", t.ClassroomsCreated.ToString(), new Microsoft.AspNetCore.Http.CookieOptions() { SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Lax, IsEssential = true });
                HttpContext.Response.Cookies.Append("email", t.Email.ToString(), new Microsoft.AspNetCore.Http.CookieOptions() { SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Lax, IsEssential = true });
                return RedirectToAction("HomePage", "Teacher");

            }
            else if(accountType is Student )
            {
                Student s = accountType as Student;
                ViewBag.name = s.Name.ToString();
                HttpContext.Response.Cookies.Append("name", s.Name, new Microsoft.AspNetCore.Http.CookieOptions() { SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Lax, IsEssential = true });
                HttpContext.Response.Cookies.Append("classrooms_joined", s.ClassroomsJoined.ToString(), new Microsoft.AspNetCore.Http.CookieOptions() { SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Lax, IsEssential = true });
                HttpContext.Response.Cookies.Append("email", s.Email.ToString(), new Microsoft.AspNetCore.Http.CookieOptions() { SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Lax, IsEssential = true });
                return RedirectToAction("HomePage", "Student");

            }
            else
            {
                return View();
            }
           
        }
    }
}