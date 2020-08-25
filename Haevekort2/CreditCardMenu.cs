using GUI;
using Haevekort2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haevekort2
{
    public class CreditCardMenu : BulletMenu
    {
        public override string[] Options
        {
            get;

            protected set;
        }

        public override Action[] OptionActions
        {
            get;

            protected set;
        }

        public override string Title
        {
            get;

            protected set;
        }

        private ICard CurrentCard { get; set; }

        public CreditCardMenu(ICard card)
        {
            CurrentCard = card;

            Title = "Credit card menu";

            Options = new string[] {
                "Withdraw",
                "Deposit"
            };

            OptionActions = new Action[]
            {
                () => MenuManager.Instance.ChangeMenu(new WithDrawMenu(CurrentCard)),
                () => MenuManager.Instance.ChangeMenu(new DepositMenu(CurrentCard))
            };
        }
    }
}
