using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    /// <summary>
    /// manager for managing the menus
    /// </summary>
    public class MenuManager
    {
        // Singleton manager
        private static MenuManager instance;
        public static MenuManager Instance
        {
            get 
            {
                if (instance == null)
                    instance = new MenuManager();

                return instance; 
            }
        }
        private MenuManager() { }

        /// <summary>
        /// Changes the menu
        /// </summary>
        /// <param name="menu"></param>
        public void ChangeMenu(Menu menu)
        {
            menu.Run();
        }
    }
}
