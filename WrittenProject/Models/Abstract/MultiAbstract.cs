using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenProject.Models
{
    public abstract class MultiAbstract
    {
        /// <summary>
        /// normal værdi som bliver arvet ned
        /// </summary>
        public int NormalValue { get; set; }

        /// <summary>
        /// Abstrakt værdi
        /// </summary>
        public abstract int AbstractValue { get; set; }
    }
}
