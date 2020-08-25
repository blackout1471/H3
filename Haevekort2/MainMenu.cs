using GUI;
using Haevekort2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Haevekort2
{
    public class MainMenu : BulletMenu
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

        public MainMenu(List<ICard> cards)
        {
            Title = "Main Menu - Insert Card";
            Options = cards.Select((x) => $"{x.Account.CustomerInfo.FirstName}'s card").ToArray();
            List<Action> actions = new List<Action>();
            foreach (var item in cards)
            {
                actions.Add(() => MenuManager.Instance.ChangeMenu(new PincodeMenu(item)));
            }
            OptionActions = actions.ToArray();

        }


    }
}
