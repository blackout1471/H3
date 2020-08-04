using Coctails.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3.models
{
    [Table("ProductAmounts")]
    public class ProductAmount : Entity
    {
        public Product Product { get; set; }

        public float Amount { get; set; }

        public ProductScale Scale { get; set; }

        private ProductAmount()
        {

        }

        public ProductAmount(Product product, int amount, ProductScale scale)
        {
            Product = product;
            Amount = amount;
            Scale = scale;
        }
    }
}
