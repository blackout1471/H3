using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenProject.Models
{
    public class MultiTestModel1 : MultiAbstract
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Implementering af abstrakt klasses property
        /// </summary>
        public override int AbstractValue { get => abstractValue; set => abstractValue = value; }
        private int abstractValue;
    }
}
