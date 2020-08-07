using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrittenProject.Models;

namespace WrittenProject
{
    public class SingleInterfaceContext : DbContext
    {
        public SingleInterfaceContext() : base("name=DBConnectionString")
        {
            Database.SetInitializer<SingleInterfaceContext>(new DropCreateDatabaseIfModelChanges<SingleInterfaceContext>());
        }

        public DbSet<SingleInterfaceModel> SingleInterfaceModels { get; set; }
    }
}
