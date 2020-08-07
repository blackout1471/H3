using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrittenProject.Models;

namespace WrittenProject
{
    public class CourseContext : DbContext
    {
        public CourseContext() : base("name=DBConnectionString")
        {
            Database.SetInitializer<CourseContext>(new DropCreateDatabaseIfModelChanges<CourseContext>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
