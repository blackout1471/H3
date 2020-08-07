using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrittenProject.Models;

namespace WrittenProject
{
    public class MultiInterfaceContext : DbContext
    {
        public MultiInterfaceContext() : base("name=DBConnectionString")
        {
            Database.SetInitializer<MultiInterfaceContext>(new DropCreateDatabaseIfModelChanges<MultiInterfaceContext>());
        }

        public DbSet<MultiInterfaceModel1> MultiInterfaceModels1 { get; set; }
        public DbSet<MultiInterfaceModel2> MultiInterfaceModels2 { get; set; }
    }
}
