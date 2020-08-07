using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenProject.Models
{
    public class SingleInterfaceModel : ISingleInterface
    {
        [Key]
        public int Id { get; set; }

        public int InterfaceValue { get => interfaceValue; set => interfaceValue = value; }
        private int interfaceValue;
    }
}
