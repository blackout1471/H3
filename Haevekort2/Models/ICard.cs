using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haevekort2.Models
{
    public interface ICard
    {
        IAccount Account { get; }

        string Pin { get; }
    }
}
