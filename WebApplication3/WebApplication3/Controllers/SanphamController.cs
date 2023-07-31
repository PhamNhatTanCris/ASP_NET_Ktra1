using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class SanphamController : Controller
    {
        // GET: Sanpham
        List<Sanpham> li = new List<Sanpham>();
        public ActionResult Index()
        {
            li = new List<Sanpham>();
            li.Add(new Sanpham("s1", "hang 1", 10));
            li.Add(new Sanpham("s2", "hang 2", 8));
            TempData["li"] = li;
            TempData["msg"] = 1;
            return View(li);
        }

        public ActionResult FormAdd()
        {
            ViewBag.li = TempData["li"];
            List<Sanpham> ds = (List<Sanpham>)TempData["li"];
            if (ds == null)
            {
                ds = new List<Sanpham>();
            }
            ds.Add(new Sanpham("s03", "sp moi", 15));
            TempData["li"] = ds;

            //==============================================================
            // int i = Convert.ToInt16(TempData["msg"]);
            //  TempData["msg"] = i + 1;

            return View();
        }
        public ActionResult Add(Sanpham s)
        {
            List<Sanpham> ds = (List<Sanpham>)TempData["li"];
            if (ds == null)
            {
                ds = new List<Sanpham>();
            }
            ds.Add(s);
            TempData["li"] = ds;

            int i = Convert.ToInt16(TempData["msg"]);
            TempData["msg"] = i + 1;

            return View("index",ds);
            
        }

    }
}