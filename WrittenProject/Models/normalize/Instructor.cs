using System;
using System.Collections.Generic;

namespace WrittenProject.Models
{
    public class Instructor : Person2
    {
        public List<Course> Courses { get; set; }

        public DateTime HireDate { get; set; }
    }
}