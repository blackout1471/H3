using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenProject.Models
{
    public class CityRight
    {
        [Key]
        public int PostCode { get; set; }

        public string Name { get; set; }

        private CityRight()
        {

        }

        public CityRight(int postcode, string name)
        {
            Name = name;
            PostCode = postcode;
        }
    }
}
