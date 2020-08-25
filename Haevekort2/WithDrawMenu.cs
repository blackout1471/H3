using GUI;
using Haevekort2.Models;

namespace Haevekort2
{
    public class WithDrawMenu : Menu
    {
        private ICard CurrentCard;

        public WithDrawMenu(ICard currentCard)
        {
            CurrentCard = currentCard;
        }

        public override void Run()
        {
            Text("Withdraw money");
            Clear();
            Text($"In account: {CurrentCard.Account.Money}");
            Write("Amount to withdraw:");

            float requestedAmount = GetUserInputAsNumber();
            float amount = 0;
            try
            {
                amount = CurrentCard.Account.WithDraw(requestedAmount);
            }
            catch (System.Exception e)
            {
                Text(e.Message);
            }
            Text($"{amount} was withdrawn!");

            GetUserText();
        }
    }
}