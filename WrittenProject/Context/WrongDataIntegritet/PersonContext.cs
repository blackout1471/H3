using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrittenProject.Models;

namespace WrittenProject
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("name=DBConnectionString")
        {
            Database.SetInitializer<PersonContext>(new DropCreateDatabaseIfModelChanges<PersonContext>());
        }

        public DbSet<Person> Persons { get; set; }
    }
}
