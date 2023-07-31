using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Sanpham
    {
        public string masp{ get; set; }
        public string tensp{ get; set; }
        public int soluong{ get; set; }
        public Sanpham()
        {

        }
        public Sanpham(string a, string b, int c)
        {
            masp = a;  
            tensp = b;
            soluong = c; 
        }
    }
}