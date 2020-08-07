using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrittenProject.Models;

namespace WrittenProject
{
    public class PersonRightContext : DbContext
    {
        public PersonRightContext() : base("name=DBConnectionString")
        {
            Database.SetInitializer<PersonRightContext>(new DropCreateDatabaseIfModelChanges<PersonRightContext>());
        }

        public DbSet<PersonRight> Persons { get; set; }
    }
}
