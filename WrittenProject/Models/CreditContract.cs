using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenProject.Models
{
    public class CreditContract : Contract
    {
        public float CreditLimit { get; set; }

        public string CreditLimitCurrency { get; set; }
    }
}
