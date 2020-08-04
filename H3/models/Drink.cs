using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3.models
{
    [Table("Drinks")]
    public class Drink : Entity
    {
        public string Name { get; set; }

        public List<ProductAmount> Products { get; set; }

        private Drink()
        {

        }

        public Drink(string name, List<ProductAmount> products)
        {
            Name = name;
            Products = products;
        }
    }
}
