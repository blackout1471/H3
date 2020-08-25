using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haevekort2.Models
{
    public class Account : IAccount
    {
        public ICustomerInfo CustomerInfo
        {
            get;
            private set;

        }

        public float Money
        {
            get;
            private set;
        }

        public Account(ICustomerInfo customerInfo, float money)
        {
            CustomerInfo = customerInfo;
            Money = money;
        }

        public float WithDraw(float amount)
        {
            if (!CanTakeMoney(amount))
                throw new ArgumentException("Could not withdraw money!");

            Money -= amount;

            return amount;
        }

        public void Deposit(float amount)
        {
            Money += amount;
        }

        private bool CanTakeMoney(float amount)
        {
            if (amount > Money)
                return false;

            return true;
        }
    }
}
