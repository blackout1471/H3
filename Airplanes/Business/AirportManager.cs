using Airplanes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplanes.Business
{
    public class AirportManager
    {
        // singleton pattern
        private static AirportManager instance;
        public static AirportManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new AirportManager();

                return instance;
            }
        }
        private AirportManager() { }

        /// <summary>
        /// Creates a country from a country object
        /// </summary>
        /// <param name="name"></param>
        public void CreateCountry(Country country)
        {
            using (var context = new AirplanesEntities())
            {
                context.Countrys.Add(country);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Removes a country by name
        /// </summary>
        /// <param name="name"></param>
        public void RemoveCountry(Country country)
        {
            using (var context = new AirplanesEntities())
            {
                context.Entry(country).State = System.Data.Entity.EntityState.Deleted;
                context.Countrys.Remove(country);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Get all the countries
        /// </summary>
        /// <returns></returns>
        public List<Country> GetAllCountries()
        {
            List<Country> countries = new List<Country>();

            using (var context = new AirplanesEntities())
            {
                countries = context.Countrys.ToList();
            }

            return countries;
        }

        /// <summary>
        /// Creates a airport from the airport object
        /// </summary>
        /// <param name="airport"></param>
        public void CreateAirport(Airport airport)
        {
            using (var context = new AirplanesEntities())
            {
                context.Airports.Add(airport);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Removes a airport by the object
        /// </summary>
        /// <param name="airport"></param>
        public void RemoveAirport(Airport airport)
        {
            using (var context = new AirplanesEntities())
            {
                context.Entry(airport).State = System.Data.Entity.EntityState.Deleted;
                context.Airports.Remove(airport);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Get all the airports
        /// </summary>
        /// <returns></returns>
        public List<Airport> GetAllAirports()
        {
            List<Airport> airports = new List<Airport>();

            using (var context = new AirplanesEntities())
            {
                airports = context.Airports.ToList();
            }

            return airports;
        }

        /// <summary>
        /// Search an airport by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Airport SearchAirportByName(string name)
        {
            Airport airport;

            using (var context = new AirplanesEntities())
            {
                airport = context.Airports.Where((obj) => obj.Name.Contains(name)).FirstOrDefault();
            }

            return airport;
        }

        /// <summary>
        /// Search multiple airports by country
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public List<Airport> SearchAirportsByCountry(Country country)
        {
            List<Airport> airports = new List<Airport>();

            using (var context = new AirplanesEntities())
            {
                airports = context.Airports.Where((obj) => obj.Country == country).ToList();
            }

            return airports;
        }


    }
}
