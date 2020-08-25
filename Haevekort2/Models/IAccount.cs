using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haevekort2.Models
{
    public interface IAccount
    {
        ICustomerInfo CustomerInfo { get; }
        float Money { get; }

        float WithDraw(float amount);
        void Deposit(float amount);
    }
}
