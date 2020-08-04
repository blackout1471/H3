using Coctails.models;
using H3.business;
using H3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coctails
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main Menu
            CreateMenu(new string[]
            {
                "Create Drink",
                "See Unique Drinks",
                "Search Drinks",
                "Remove Drink",
            },
            new Action[] {
                () => CreateDrinkMenu(),
                () => SeeAllUniqueDrinksMenu(),
                () => SearchDrinkMenu(),
                () => RemoveDrinkMenu()
            });
        }

        /// <summary>
        /// The menu for removing a drink
        /// </summary>
        static void RemoveDrinkMenu()
        {
            Console.WriteLine("Search for drink to remove");
            string name = Console.ReadLine();

            List<Drink> drinks = DrinkManager.Instance.SearchDrink(name);

            Console.WriteLine($"{drinks.Count} was found");
            for (int i = 0; i < drinks.Count; i++)
            {
                Console.WriteLine($"{i}. {drinks[i].Name}");
            }

            Console.WriteLine("Write the number to remove");
            int number = GetUserInputAsNumber();

            DrinkManager.Instance.RemoveDrink(drinks[number]);
            Console.WriteLine("The drink has been removed");

            Console.ReadKey();
        }

        /// <summary>
        /// The menu for searching for a drink
        /// </summary>
        static void SearchDrinkMenu()
        {
            Console.WriteLine("Enter name of drink");
            string name = Console.ReadLine();

            List<Drink> drinks = DrinkManager.Instance.SearchDrink(name);

            Console.WriteLine($"{drinks.Count} was found");
            for (int i = 0; i < drinks.Count; i++)
            {
                Console.WriteLine($"{i}. {drinks[i].Name}");
                for (int k = 0; k < drinks[i].Products.Count; k++)
                    Console.WriteLine($"\t{drinks[i].Products[k].Product.Name} {drinks[i].Products[k].Amount} {drinks[i].Products[k].Scale.ToString()}");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Menu for creating a product locally
        /// </summary>
        /// <returns></returns>
        static Product CreateProductMenu()
        {
            Console.WriteLine("Name for product");
            string name = Console.ReadLine();

            return new Product(name);
        }

        /// <summary>
        /// Creates a menu for creating a productAmount locally
        /// </summary>
        /// <returns></returns>
        static ProductAmount CreateProductAmountMenu()
        {
            Product product = CreateProductMenu();

            Console.WriteLine("Enter amount");
            int amount = GetUserInputAsNumber();

            Console.WriteLine("Choose scale");
            string[] enumArr = Enum.GetNames(typeof(ProductScale));
            for (int i = 0; i < enumArr.Length; i++)
                Console.WriteLine($"{i}. {enumArr[i]}");

            int enumChoosen = GetUserInputAsNumber();

            return new ProductAmount(product, amount, (ProductScale)enumChoosen);
        }

        /// <summary>
        /// The menu for creating a drink and saving it to the database
        /// </summary>
        static void CreateDrinkMenu()
        {
            List<ProductAmount> ingredients = new List<ProductAmount>();

            Console.WriteLine("Name of drink");
            string name = Console.ReadLine();

            Console.WriteLine("How many ingredients");
            int count = GetUserInputAsNumber();

            for (int i = 0; i < count; i++)
                ingredients.Add(CreateProductAmountMenu());

            Drink drink = new Drink(name, ingredients);
            DrinkManager.Instance.CreateDrink(drink);
            Console.WriteLine("Drink has been created.");
            Console.ReadKey();
        }

        /// <summary>
        /// Menu for seeing all the uniques drinks available
        /// </summary>
        static void SeeAllUniqueDrinksMenu()
        {
            List<Drink> drinks = DrinkManager.Instance.GetUniqueDrinks();

            for (int i = 0; i < drinks.Count; i++)
            {
                Console.WriteLine($"{i}. {drinks[i].Name}");
            }

            Console.WriteLine("Click any key to go back.");
            Console.ReadKey();
        }

        /// <summary>
        /// Method to create a menu where the user can choose the next menu
        /// </summary>
        /// <param name="options"></param>
        /// <param name="actions"></param>
        static void CreateMenu(string[] options, Action[] actions)
        {

            bool exit = false;
            while(!exit)
            {
                Console.Clear();
                Console.WriteLine("Choose Option");
                for (int i = 0; i < options.Length; i++)
                    Console.WriteLine($"{i+1}. {options[i]}");

                Console.WriteLine("0. Back");

                int number = GetUserInputAsNumber();

                if (number == 0)
                    return;

                actions[number - 1].Invoke();
            }

        }

        /// <summary>
        /// Function for waiting for the user to input a valid number in the console
        /// </summary>
        /// <returns></returns>
        static int GetUserInputAsNumber()
        {
            bool valid = false;
            int number = 0;

            while(!valid)
                valid = Int32.TryParse(Console.ReadLine(), out number);

            return number;
        }
    }
}
