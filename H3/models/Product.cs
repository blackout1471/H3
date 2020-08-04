using H3.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coctails.models
{
    [Table("Products")]
    public class Product : Entity
    {
        public string Name { get; set; }

        private Product()
        {

        }

        public Product(string name)
        {
            Name = name;
        }
    }
}
