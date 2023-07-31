using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public int mark { get; set; }
        
        public string grade { 
            get
            {
                if (mark >= 8)
                    return "distinct";
                else if (mark >= 7)
                    return  "credit";
                else if (mark >= 5)
                    return  "pass";
                else
                    return "fail";
            }}

        public Student()
        {

        }

        public Student(string name, int age, int mark)
        {
            this.name = name;
            this.age = age;
            this.mark = mark;
        }
    }
}