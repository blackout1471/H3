using Coctails.models;
using H3.contexts;
using H3.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3.business
{
    public class DrinkManager
    {
        /// <summary>
        /// Singleton instance
        /// </summary>
        public static DrinkManager Instance 
        { 
            get {
                if (instance == null)
                    instance = new DrinkManager();

                return instance;
                } 
        }
        private static DrinkManager instance;

        private DrinkManager() { }

        /// <summary>
        /// Method for creating a drink and saving it to the db
        /// </summary>
        /// <param name="drink"></param>
        public void CreateDrink(Drink drink)
        {
            using (var context = new DrinkContext())
            {
                context.Drinks.Add(drink);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Method to retrieve all the unique drinks in the db
        /// </summary>
        /// <returns></returns>
        public List<Drink> GetUniqueDrinks()
        {
            List<Drink> drinks;

            using (var context = new DrinkContext())
            {
                drinks = context.Drinks.Distinct().ToList();
            }

            return drinks;
        }

        /// <summary>
        /// Method to search for a drink in the db by a name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Drink> SearchDrink(string name)
        {
            List<Drink> drinks;

            using (var context = new DrinkContext())
            {
                drinks = context.Drinks
                    .Include((drink) => drink.Products.Select((product) => product.Product))
                    .Where((drink) => drink.Name == name).ToList();
            }

            return drinks;
        }

        /// <summary>
        /// Method to search for a drink by a drink objects name
        /// </summary>
        /// <param name="drink"></param>
        /// <returns></returns>
        public List<Drink> SearchDrink(Drink drink)
        {
            return SearchDrink(drink.Name);
        }

        /// <summary>
        /// Method to remove a drink object that has been retrieved from the db
        /// and deleting it
        /// </summary>
        /// <param name="drink"></param>
        public void RemoveDrink(Drink drink)
        {
            using (var context = new DrinkContext())
            {
                context.Entry(drink).State = EntityState.Deleted;
                context.Drinks.Remove(drink);
                context.SaveChanges();
            }
        }
    }
}