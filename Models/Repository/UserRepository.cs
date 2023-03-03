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

namespace Frosh.Models.Repository
{
    public class UserRepository: IUserRepo
    {
        public bool SignUp(string name,string email,string password,string accType)
        {
            if (accType == "Teacher")
            {
                Teacher teacher = new Teacher
                {
                    Email = email,
                    Password = password,
                    Name = name,
                    CreationDate = System.DateTime.Now.ToString(),

                };
                froshContext froshContext = new froshContext();
                froshContext.Teacher.Add(teacher);
                froshContext.SaveChanges();
                return true;



            }
            else if(accType=="Student")
            {
                Student student = new Student
                {
                    Email = email,
                    Password = password,
                    Name = name,
                    Creationdate = System.DateTime.Now.ToString(),

                };
                froshContext froshContext = new froshContext();
                froshContext.Student.Add(student);
                froshContext.SaveChanges();
                return true;




            }
            return false;
        }

        public object SignIn(string email, string password)
        {
            froshContext froshContext = new froshContext();

            Teacher t = null;
            try
            {
                t = froshContext.Teacher.Where(teacher => teacher.Email == $"{email}" && teacher.Password == password).First();

                return t;







            }
            catch
            {
                Student s = null;
                try
                {
                    s = froshContext.Student.Where(student => student.Email == $"{email}" && student.Password == password).First();
                   
                    return s;
                }
                catch
                {
                    return null;
                }
            }
        }
        public String ReturnUsersName(string email)
        {
            froshContext froshContext = new froshContext();
            Teacher t = null;
            try
            {
                t = froshContext.Teacher.Where(teacher => teacher.Email == $"{email}").First();

                return t.Name;







            }
            catch
            {
                Student s = null;
                try
                {
                    s = froshContext.Student.Where(student => student.Email == $"{email}").First();

                    return s.Name;
                }
                catch
                {
                    return "";
                }
            }
            

        }
    }
}
