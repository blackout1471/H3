using Airplanes.Business;
using Airplanes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplanes.GUI
{
    public class AirportMenu : BulletMenu
    {
        public override string[] Options { get => options; protected set => options = value; }
        public override Action[] OptionActions { get => optionActions; protected set => optionActions = value; }
        public override string Title { get => title; protected set => title = value; }

        private string[] options;
        private Action[] optionActions;
        private string title;

        public AirportMenu()
        {
            Title = "Airport Menu";

            Options = new string[]
            {
                "Create new Airport",
                "See all airports",
                "Remove airport"
            };

            OptionActions = new Action[]
            {
                () => CreateNewAirport(),
                () => SeeAllAirports(),
                () => RemoveAirport()
            };
        }

        /// <summary>
        /// Creates gui for creating a new airport
        /// </summary>
        private void CreateNewAirport()
        {
            Clear();

            Text("Write name for airport");
            Write(":");
            string name = GetUserText();

            List<Country> countries = AirportManager.Instance.GetAllCountries();
            for (int i = 0; i < countries.Count; i++)
                Text($"{i}. {countries[i].Name}");

            Text("Select country");
            Write(":");
            int countryN = GetUserInputAsNumber();
            Country curCountry = countries[countryN];

            Text("Write IATA Code");
            Write(":");
            string iata = GetUserText();

            Airport cur = new Airport() { Name = name, IATA = iata, Country = curCountry };
            AirportManager.Instance.CreateAirport(cur);
            Text("Airport has been created.");
            Text("Click any key to move forward");
            
            GetKey();

        }

        /// <summary>
        /// Creates gui for seeing all the airports
        /// </summary>
        private void SeeAllAirports()
        {
            Clear();

            List<Airport> airports = AirportManager.Instance.GetAllAirports();

            for (int i = 0; i < airports.Count; i++)
                Text($"{i}. {airports[i].Name} {airports[i].IATA}");

            GetKey();
                
        }

        /// <summary>
        /// Creates gui for removing an airport
        /// </summary>
        private void RemoveAirport()
        {
            Clear();

            List<Airport> airports = AirportManager.Instance.GetAllAirports();

            for (int i = 0; i < airports.Count; i++)
                Text($"{i}. {airports[i].Name} {airports[i].IATA}");

            Text("Select one to delete");
            Write(":");

            int n = GetUserInputAsNumber();
            AirportManager.Instance.RemoveAirport(airports[n]);

            Text("It has been removed");
            GetKey();
        }
    }
}
