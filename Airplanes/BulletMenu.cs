using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplanes
{
    public abstract class BulletMenu : Menu
    {
        /// <summary>
        /// The options which will be listed for the user
        /// </summary>
        public abstract string[] Options { get; protected set; }

        /// <summary>
        /// Action item for the item
        /// </summary>
        public abstract Action[] OptionActions { get; protected set; }

        /// <summary>
        /// The method called when running the menu
        /// </summary>
        public override void Run()
        {
            Clear();

            for (int i = 0; i < Options.Length; i++)
                Text($"{i}. {Options[i]}");

            Text($"{Options.Length}. Back");

            bool valid = false;
            while (!valid)
            {
                Write(":");
                int number = GetUserInputAsNumber();

                if (ValidateOption(number))
                {
                    valid = true;
                    OptionActions[number]?.Invoke();
                }

                if (number == OptionActions.Length)
                    valid = true;
            }
        }

        /// <summary>
        /// Returns whether the number is between the options available
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private bool ValidateOption(int number)
        {
            return (number >= 0 && number < Options.Length);
        }
    }
}
