using GUI;
using Haevekort2.Models;

namespace Haevekort2
{
    public class DepositMenu : Menu
    {
        private ICard CurrentCard;

        public DepositMenu(ICard currentCard)
        {
            CurrentCard = currentCard;
        }

        public override void Run()
        {
            Text("Deposit money");
            Clear();
            Text($"In account: {CurrentCard.Account.Money}");
            Write("Amount to deposit:");

            float requestedAmount = GetUserInputAsNumber();
            try
            {
                CurrentCard.Account.Deposit(requestedAmount);
            }
            catch (System.Exception e)
            {
                Text(e.Message);
            }
            Text($"{requestedAmount} was deposited!");

            GetUserText();
        }
    }
}