using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Emp
    {
        public string eid{ get; set; }
        public string name{ get; set; }
        public double salary{ get; set; }
        public int numberdaywork{ get; set; }

        public double commision
        {
            get {
                if (numberdaywork > 20)
                    return salary * 0.2;
                else
                    return 0;
            }
        }
        public Emp()
        {

        }

        public Emp(string eid, string name, double salary, int numberdaywork)
        {
            this.eid = eid;
            this.name = name;
            this.salary = salary;
            this.numberdaywork = numberdaywork;
        }
    }
}