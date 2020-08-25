using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haevekort2.Models
{
    public interface ICustomerInfo
    {
        string FirstName { get; }
        string LastName { get; }
        DateTime BirthDay { get; }
    }
}
