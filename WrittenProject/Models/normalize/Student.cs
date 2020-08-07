using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenProject.Models
{
    public class Student : Person2
    {
        public DateTime EnrollmentDate { get; set; }

        public List<Course> Courses { get; set; }
    }
}
