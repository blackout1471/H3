using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrittenProject.Models;

namespace WrittenProject
{
    class ContractContext : DbContext
    {
        public ContractContext() : base("name=DBConnectionString")
        {
            Database.SetInitializer<ContractContext>(new DropCreateDatabaseIfModelChanges<ContractContext>());
        }

        public DbSet<Contract> Contracts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CreditContract>().Map(m =>
            {
                m.ToTable("CreditContract");
            });

            modelBuilder.Entity<PrepaymentContract>().Map(m =>
            {
                m.ToTable("PrepaymentContract");
            });

            base.OnModelCreating(modelBuilder);
        }
    }

}
