using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationApp.Models;

namespace RegistrationApp.Controllers
{
    public class HomeController : Controller
    {
        UserContext uc = new UserContext();
        // GET: Home
        public ActionResult Index()
        {
            //User u = new User() { UserId = 1, UserName = "Shay", FullName = "John Macclane", EmailId = "jm@gmail.com", ContactNo = "98898877", Address = "Aus", Gender = "Male" };
            //uc.User.Add(u);
            //uc.SaveChanges();
            return View();
        }
        [HttpPost]
        public ActionResult Index(User u)
        {
            if (ModelState.IsValid)
            {
                uc.User.Add(u);
                uc.SaveChanges();
                return View();
            }
            
            return View();
        }
    }
}