using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Course
    {
        public string cname { get; set; }
        public int hours { get; set; }
        public List<Student> liStudent{ get; set; }

        public Course()
        {
            liStudent = new List<Student>();
        }
    }
}