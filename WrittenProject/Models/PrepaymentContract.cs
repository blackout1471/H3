using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenProject.Models
{
    public class PrepaymentContract : Contract
    {
        public float PrepaymentAmount { get; set; }

        public string PrepaymentPeriod { get; set; }
    }
}
