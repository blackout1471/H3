using H3.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3.contexts
{
    public class DrinkContext : DbContext
    {
        public DrinkContext() : base("name=DBConnectionString")
        {
            Database.SetInitializer<DrinkContext>(new DropCreateDatabaseIfModelChanges<DrinkContext>());
        }

        public DbSet<Drink> Drinks { get; set; }
    }
}
