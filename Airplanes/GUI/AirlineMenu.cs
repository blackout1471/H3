using Airplanes.Business;
using Airplanes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplanes.GUI
{
    public class AirlineMenu : BulletMenu
    {
        public override string[] Options { get => options; protected set => options = value; }
        public override Action[] OptionActions { get => optionActions; protected set => optionActions = value; }
        public override string Title { get => title; protected set => title = value; }

        private string[] options;
        private Action[] optionActions;
        private string title;

        public AirlineMenu()
        {
            Title = "Airline Menu";

            Options = new string[]
            {
                "Create Airline",
                "See all airlines",
                "Remove airline"
            };

            OptionActions = new Action[]
            {
                () => CreateAirline(),
                () => SeeAirlines(),
                () => RemoveAirline()
            };
        }

        /// <summary>
        /// creates gui for creating a airline
        /// </summary>
        private void CreateAirline()
        {
            Clear();

            Text("Write a name for the airline");
            Write(":");
            string name = GetUserText();

            Airline cur = new Airline() { Name = name };
            AirlineManager.Instance.CreateAirline(cur);

            Text("Airline has been Created");
            GetKey();
        }

        /// <summary>
        /// Creates gui for seeing all the airlines
        /// </summary>
        private void SeeAirlines()
        {
            Clear();

            List<Airline> airlines = AirlineManager.Instance.GetAirlines();

            for (int i = 0; i < airlines.Count; i++)
                Text($"{i}. {airlines[i].Name}");

            GetKey();
        }

        /// <summary>
        /// Creates gui for removing an airline
        /// </summary>
        private void RemoveAirline()
        {
            Clear();

            List<Airline> airlines = AirlineManager.Instance.GetAirlines();

            for (int i = 0; i < airlines.Count; i++)
                Text($"{i}. {airlines[i].Name}");

            Text("Choose airline to remove");
            Write(":");

            int n = GetUserInputAsNumber();
            AirlineManager.Instance.RemoveAirline(airlines[n]);

            Text("Airline has been removed");

            GetKey();
        }
    }
}
