using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haevekort2.Models
{
    public class Card : ICard
    {
        public IAccount Account
        {
            get;
            private set;
        }

        public string Pin
        {
            get;
            private set;
        }

        public Card(IAccount account, string pin)
        {
            Account = account;
            Pin = pin;
        }
    }
}
