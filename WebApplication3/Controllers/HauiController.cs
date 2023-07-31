using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HauiController : Controller
    {
        // GET: Haui
        public ActionResult Index()
        {
            return View();
        }
        public  ActionResult Course()
        {
            Course c = new Course();
            c.cname = "LT Web bang ASP.NET MVC";
            c.hours = 60;
            List<Student> li = new List<Student>();
            li.Add(new Student("Huong", 20, 9));
            li.Add(new Student("Lan", 25, 3));
            li.Add(new Student("Tuan", 23, 2));
            li.Add(new Student("Hai", 21, 8));
            li.Add(new Student("Hang", 26, 4));
            li.Add(new Student("Long", 25, 3));

            c.liStudent = li;
            return View(c);
        }
        public ActionResult ListStudent()
        {
            List<Student> li = new List<Student>();
            li.Add(new Student("Huong",20,9));
            li.Add(new Student("Lan",25,3));
            li.Add(new Student("Tuan",23,2));
            li.Add(new Student("Hai",21,8));
            li.Add(new Student("Hang",26,4));
            li.Add(new Student("Long",25,3));
            li.Add(new Student("Hoang",21,8));
            li.Add(new Student("Hieu",29,9));
            li.Add(new Student("Hong",21,2));

            List<Student> li1=new List<Student>();
            List<Student> li2=new List<Student>();
            foreach (var item in li)
            {
                if (item.mark >= 5)
                {
                    li1.Add(item);
                }
            }
            foreach (var item in li)
            {
                if (item.mark < 5)
                {
                    li2.Add(item);
                }
            }
            ViewBag.li1 = li1;
            ViewBag.li2 = li2;
            return View(li);
        }
        [HttpGet]
        public ActionResult Input()
        {
            return View();
        }

        public ActionResult Output2(Student s)
        {
            return View(s);
        } 
        public ActionResult Output4(string name,int  age,int mark)
        {
            Student s = new Student(name, age, mark);
            return View("Output2",s);
        } 
        public ActionResult Output3(FormCollection f)
        {
            string n = f["name"];
            int a = int.Parse(f["age"]);
            int m = int.Parse(f["mark"]);

            Student s = new Student(n, a, m);
            return View("Output2",s);
        }


        [HttpPost]
        public ActionResult Output()
        {
            string n = Request["name"];
            int a = int.Parse(Request["age"]);
            int m = int.Parse(Request["mark"]);

            Student s = new Student(n, a, m);
            ViewBag.std = s;

            //ViewBag.name = n; 
            //ViewBag.age = a; 
            //ViewBag.mark = m;

            //string g;
            //if (m >= 8)
            //    g = "distinct";
            //else if (m >= 7)
            //    g = "credit";
            //else if (m >= 5)
            //    g = "pass";
            //else
            //    g = "false";

            //ViewBag.grade = g;
            return View();
        }

    }
}