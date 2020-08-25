using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haevekort2.Models
{
    public class CustomerInfo : ICustomerInfo
    {
        public string FirstName
        {
            get;
            private set;
        }

        public string LastName
        {
            get;
            private set;
        }

        public DateTime BirthDay
        {
            get;
            private set;
        }


        public CustomerInfo(string firstname, string lastname, DateTime birthday)
        {
            FirstName = firstname;
            LastName = lastname;
            BirthDay = birthday;
        }
    }
}
