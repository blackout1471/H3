using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrittenProject.Models;

namespace WrittenProject
{
    public class MultiTestModelContext : DbContext
    {
        public MultiTestModelContext() : base("name=DBConnectionString")
        {
            Database.SetInitializer<MultiTestModelContext>(new DropCreateDatabaseIfModelChanges<MultiTestModelContext>());
        }

        public DbSet<MultiTestModel1> MultiTestModel1 { get; set; }

        public DbSet<MultiTestModel2> MultiTestModel2 { get; set; }
    }
}
