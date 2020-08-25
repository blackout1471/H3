using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public abstract class Menu
    {
        public abstract void Run();

        /// <summary>
        /// Clears the screen
        /// </summary>
        public void Clear()
        {
            Console.Clear();
        }

        /// <summary>
        /// Writes to the screen
        /// </summary>
        /// <param name="text"></param>
        public void Text(string text)
        {
            Console.WriteLine(text);
        }

        /// <summary>
        /// Writes text without newline
        /// </summary>
        /// <param name="text"></param>
        public void Write(string text)
        {
            Console.Write(text);
        }

        /// <summary>
        /// Will keep asking for input until valid number
        /// </summary>
        /// <returns></returns>
        public int GetUserInputAsNumber()
        {
            bool valid = false;
            int number = 0;

            while (!valid)
                valid = Int32.TryParse(Console.ReadLine(), out number);

            return number;
        }

        /// <summary>
        /// Gets the user keys
        /// </summary>
        /// <returns></returns>
        public char GetKey()
        {
            return Console.ReadKey().KeyChar;
        }

        /// <summary>
        /// Gets the input from the user
        /// </summary>
        /// <returns></returns>
        public string GetUserText()
        {
            return Console.ReadLine();
        }
    }
}
