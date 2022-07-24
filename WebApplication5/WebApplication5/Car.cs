using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5
{   
    public class Car
    {   // Fields for the Car Class
        public string Name { set; get; }
        // Constructor to access name of the class
        public Car (string name)
        {
            this.Name = name;
        }

    }
}