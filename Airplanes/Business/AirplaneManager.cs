using Airplanes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplanes.Business
{
    public class AirplaneManager
    {
        // singleton pattern
        private static AirplaneManager instance;
        public static AirplaneManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new AirplaneManager();

                return instance;
            }
        }
        private AirplaneManager() { }

        /// <summary>
        /// Adds a new airplane to the context and saves it to the db
        /// </summary>
        /// <param name="airplane"></param>
        public void CreateAirplane(Airplane airplane)
        {
            using (var context = new AirplanesEntities())
            {
                context.Airplanes.Add(airplane);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// removes an airplane by the model
        /// and saves the changes to the db
        /// </summary>
        /// <param name="airplane"></param>
        public void RemoveAirplane(Airplane airplane)
        {
            using (var context = new AirplanesEntities())
            {
                context.Entry(airplane).State = System.Data.Entity.EntityState.Deleted;
                context.Airplanes.Remove(airplane);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Searches an airplane by the current airport and the next
        /// </summary>
        /// <param name="currentPos"></param>
        /// <param name="nextPos"></param>
        /// <returns></returns>
        public Airplane SearchAirplaneByCurrentAndDestination(Airport currentPos, Airport nextPos)
        {
            Airplane airplane;

            using (var context = new AirplanesEntities())
            {
                airplane = context.Airplanes.Where((obj) => obj.Airport == currentPos && obj.Airport1 == nextPos).FirstOrDefault();
            }

            return airplane;
        }
    }
}
