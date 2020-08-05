using Airplanes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplanes.Business
{
    public class AirlineManager
    {
        // singleton pattern
        private static AirlineManager instance;
        public static AirlineManager Instance
        {
            get 
            {
                if (instance == null)
                    instance = new AirlineManager();

                return instance; 
            }
        }
        private AirlineManager() { }

        /// <summary>
        /// Creates a airline from the model
        /// and saves it to the db
        /// </summary>
        /// <param name="airline"></param>
        public void CreateAirline(Airline airline)
        {
            using (var context = new AirplanesEntities())
            {
                context.Airlines.Add(airline);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// removes an airline from the database
        /// </summary>
        /// <param name="airline"></param>
        public void RemoveAirline(Airline airline)
        {
            using (var context = new AirplanesEntities())
            {
                context.Entry(airline).State = System.Data.Entity.EntityState.Deleted;
                context.Airlines.Remove(airline);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Search airline by a name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Airline SearchAirlineByName(string name)
        {
            Airline airline;

            using (var context = new AirplanesEntities())
            {
                airline = context.Airlines.Where((obj) => obj.Name.Contains(name)).FirstOrDefault();
            }

            return airline;
        }
    }
}
