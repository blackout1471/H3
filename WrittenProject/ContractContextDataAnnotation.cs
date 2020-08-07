using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenProject
{
    public class ContractContextDataAnnotation : DbContext
    {
        public ContractContextDataAnnotation() : base("name=DBConnectionString")
        {
            Database.SetInitializer<ContractContextDataAnnotation>(new DropCreateDatabaseIfModelChanges<ContractContextDataAnnotation>());
        }

        public DbSet<Contract2> Contracts { get; set; }

        public DbSet<CreditContract2> CreditContracts { get; set; }

        public DbSet<PrepaymentContract2> PrepaymentContracts { get; set; }
    }
}
