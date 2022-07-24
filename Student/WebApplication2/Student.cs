using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
   
        public class Student
        {
            //Field of Student Class
            public string FirstName { set; get; }
            public string LastName { set; get; }
            public string City { set; get; }
            public int Id { set; get; }

            //Constructor of the class
        public Student(string firstName, string lastName, string city,int id)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.City = city;
                this.Id = id;
            }

        }
  
}