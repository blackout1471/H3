using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenProject.Models
{
    public class Person : City
    {
        [Key]
        public int Id { get; set; }

        public override int PostCode { get => postCode; set => postCode = value; }
        public override string CityName { get => cityName; set => cityName = value; }

        public string Name { get; set; }

        private int postCode;
        private string cityName;

        private Person()
        {

        }

        public Person(string name, int postcode, string cityName)
        {
            Name = name;
            PostCode = postcode;
            CityName = cityName;
        }
    }
}
