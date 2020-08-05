using Airplanes.Business;
using Airplanes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplanes.GUI
{
    public class AirplaneMenu : BulletMenu
    {
        public override string[] Options { get => options; protected set => options = value; }
        public override Action[] OptionActions { get => optionActions; protected set => optionActions = value; }
        public override string Title { get => title; protected set => title = value; }

        private string[] options;
        private Action[] optionActions;
        private string title;

        public AirplaneMenu()
        {
            Title = "Airplane Menu";

            Options = new string[]
            {
                "Create new airplane",
                "See all airplanes",
                "Remove airplane"
            };

            optionActions = new Action[]
            {
                () => CreateAirplane(),
                () => SeeAllAirplanes(),
                () => RemoveAirplane()
            };
        }

        /// <summary>
        /// Creates gui for creating an airplane
        /// </summary>
        private void CreateAirplane()
        {
            Clear();

            List<Airline> airlines = AirlineManager.Instance.GetAirlines();

            for (int i = 0; i < airlines.Count; i++)
                Text($"{i}. {airlines[i].Name}");

            Text("Choose airline the airplane belongs to");
            Write(":");
            int airlineNumber = GetUserInputAsNumber();

            List<Airport> airports = AirportManager.Instance.GetAllAirports();

            for (int i = 0; i < airports.Count; i++)
                Text($"{i}. {airports[i].Name} {airports[i].IATA}");

            Text("Choose current position for plane");
            Write(":");
            int airCurPos = GetUserInputAsNumber();

            Text("Choose next position for plane");
            Write(":");
            int airNextPos = GetUserInputAsNumber();

            AirplaneManager.Instance.CreateAirplane(new Airplane() { Airline = airlines[airlineNumber], Airport = airports[airCurPos], Airport1 = airports[airNextPos] });
            Text("Airplane has been created");

            GetKey();
        }

        /// <summary>
        /// Creates gui for seeing all the airplanes
        /// </summary>
        private void SeeAllAirplanes()
        {
            Clear();

            List<Airplane> airplanes = AirplaneManager.Instance.GetAirplanes();

            for (int i = 0; i < airplanes.Count; i++)
                Text($"{i}. {airplanes[i].Airline.Name} {airplanes[i].Airport.IATA} {airplanes[i].Airport1.IATA}");

            GetKey();
        }

        /// <summary>
        /// Creates gui for removing an airplane
        /// </summary>
        private void RemoveAirplane()
        {
            Clear();

            List<Airplane> airplanes = AirplaneManager.Instance.GetAirplanes();

            for (int i = 0; i < airplanes.Count; i++)
                Text($"{i}. {airplanes[i].Airline.Name} {airplanes[i].Airport.IATA} {airplanes[i].Airport1.IATA}");

            Text("Choose an airplane to remove");
            Write(":");

            int n = GetUserInputAsNumber();
            AirplaneManager.Instance.RemoveAirplane(airplanes[n]);

            Text("Airplane has been removed");

            GetKey();
        }
    }
}
