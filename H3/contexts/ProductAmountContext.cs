using H3.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3.contexts
{
    public class ProductAmountContext : DbContext
    {
        public ProductAmountContext() : base("name=DBConnectionString")
        {
            Database.SetInitializer<ProductAmountContext>(new DropCreateDatabaseIfModelChanges<ProductAmountContext>());
        }

        public DbSet<ProductAmount> ProductAmounts { get; set; }
    }
}
