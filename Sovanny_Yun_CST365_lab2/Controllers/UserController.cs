using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sovanny_Yun_CST356_Lab2.Data;
using Sovanny_Yun_CST356_Lab2.Data.Entities;

namespace Sovanny_Yun_CST356_Lab2.Controllers
{
    public class UserController : Controller
    {
        [HttpGet] // HTTP GET Endpoint Insertion
        public ActionResult Create()   // This is the one that paints the display
        {
            return View();
        }    
        
        [HttpPost]
        public ActionResult Create(User user)
        {
            if(!user.isValid())
            {
                return View(user);
            }

            if (InMemoryDatabase.Users == null)
            {
                InMemoryDatabase.Users = new List<Data.Entities.User>();
            }

            InMemoryDatabase.Users.Add(user);

            return View("Index", InMemoryDatabase.Users);
        } 

        public ActionResult Index()
        {
            if(InMemoryDatabase.Users == null)
            {
                InMemoryDatabase.Users = new List<Data.Entities.User>();
            }
            return View(InMemoryDatabase.Users);
        }
    }
}