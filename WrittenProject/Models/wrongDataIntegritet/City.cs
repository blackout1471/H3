using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenProject.Models
{
    public abstract class City
    {
        public abstract int PostCode { get; set; }

        public abstract string CityName { get; set; }
    }
}
