using GUI;
using Haevekort2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haevekort2
{
    public class PincodeMenu : Menu
    {
        private ICard CurrentCard { get; set; }

        public PincodeMenu(ICard card)
        {
            CurrentCard = card;
        }

        public override void Run()
        {
            for (int i = 0; i < 3; i++)
            {
                Clear();

                Text($"try:{i}/3");
                Write("Pin-code:");
                string pin = GetUserText();
                if (CurrentCard.Pin == pin)
                {
                    MenuManager.Instance.ChangeMenu(new CreditCardMenu(CurrentCard));
                    break;
                }
            }
        }
    }
}
