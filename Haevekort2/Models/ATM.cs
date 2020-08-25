using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haevekort2.Models
{
    public class ATM
    {
        public ICard CurrentCard { get; private set; }

        public ATM()
        {

        }

        public void InsertCard(ICard card) 
        {
            CurrentCard = card;
        }

        public void RemoveCard() 
        {
            CurrentCard = null;
        }

        public float WithDrawMoneyFromCurrentCard(float amount) 
        {
            return CurrentCard.Account.WithDraw(amount);
        }

        public bool CheckPinForCurrentCard(string pin) 
        {
            if (CurrentCard.Pin == pin)
                return true;

            return false;
        }
    }
}
