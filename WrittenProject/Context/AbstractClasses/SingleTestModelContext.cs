using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrittenProject.Models;

namespace WrittenProject
{
    public class SingleTestModelContext : DbContext
    {
        public SingleTestModelContext() : base("name=DBConnectionString")
        {
            Database.SetInitializer<SingleTestModelContext>(new DropCreateDatabaseIfModelChanges<SingleTestModelContext>());
        }

        public DbSet<SingleTestModel> SingleTestModel { get; set; }
    }
}
