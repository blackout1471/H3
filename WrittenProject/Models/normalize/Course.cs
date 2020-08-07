using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenProject.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public Instructor Instructor { get; set; }

        public List<Student> Students { get; set; }
    }
}
