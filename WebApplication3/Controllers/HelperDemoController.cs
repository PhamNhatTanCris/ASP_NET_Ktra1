using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HelperDemoController : Controller
    {
        // GET: HelperDemo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Display(string name, string age)
        {
            ViewBag.name = name;
            ViewBag.age = age;
            return View();
        }
        public ActionResult InputEmp()
        {
            return View();
        }
        public ActionResult OutputEmp(Emp e)
        {
            return View(e);
        }
         public ActionResult ListEmp()
        {
            List<Emp> li = new List<Emp>();
            li.Add(new Emp("e01", "Lan", 5000, 20));
            li.Add(new Emp("e02", "Tuan", 5000, 29));
            li.Add(new Emp("e03", "Van", 5000, 23));
            return View(li);
        }

    }
}