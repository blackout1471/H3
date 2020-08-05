using Airplanes.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplanes
{
    public class MainMenu : BulletMenu
    {
        public override string[] Options
        {
            get => options;
            protected set => options = value;
        }

        public override Action[] OptionActions
        {
            get => optionActions;
            protected set => optionActions = value;
        }

        public override string Title { get => title; protected set => title = value; }

        private string[] options;
        private Action[] optionActions;
        private string title;

        public MainMenu()
        {
            Title = "Main Menu";

            options = new string[]
            {
                "Airport Menu",
                "Airline Menu",
                "Airplane Menu"
                
            };

            optionActions = new Action[]
            {
                () => GoToAirportMenu(),
                () => GoToAirlineMenu(),
                () => GoToAirplaneMenu()
            };
        }

        /// <summary>
        /// Changes the menu to the airport menu
        /// </summary>
        private void GoToAirportMenu()
        {
            MenuManager.Instance.ChangeMenu(new AirportMenu());
        }

        /// <summary>
        /// Changes the menu to the airline menu
        /// </summary>
        private void GoToAirlineMenu()
        {
            MenuManager.Instance.ChangeMenu(new AirlineMenu());
        }

        /// <summary>
        /// Changes the menu to airplane menu
        /// </summary>
        private void GoToAirplaneMenu()
        {
            MenuManager.Instance.ChangeMenu(new AirplaneMenu());
        }
    }
}
