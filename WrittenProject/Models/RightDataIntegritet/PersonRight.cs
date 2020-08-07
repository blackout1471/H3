using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenProject.Models
{
    public class PersonRight : ICity
    {
        [Key]
        public int Id { get; set; }

        public CityRight City { get; set; }
        public string Name { get; set; }

        private PersonRight()
        {

        }

        public PersonRight(string name, CityRight city)
        {
            Name = name;
            City = city;
        }
    }
}
