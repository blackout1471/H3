using GUI;
using Haevekort2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haevekort2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerInfo cus = CreateMockCustomer();
            IAccount acc = CreateMockAccount(cus);
            ICard card = CreateMockCard(acc);

            List<ICard> cards = new List<ICard>();
            cards.Add(card);

            MenuManager.Instance.ChangeMenu(new MainMenu(cards));
        }

        #region Mock Objects
        static ICustomerInfo CreateMockCustomer()
        {
            return new CustomerInfo("Emil", "Andersen", DateTime.Now);
        }

        static IAccount CreateMockAccount(ICustomerInfo cus)
        {
            return new Account(cus, 2000);
        }

        static ICard CreateMockCard(IAccount acc)
        {
            return new Card(acc, "1234");
        }
        #endregion
    }
}
