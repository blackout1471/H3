using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplanes
{
    public class MainMenu : BulletMenu
    {
        public override string[] Options
        {
            get => options;
            protected set => options = value;
        }

        public override Action[] OptionActions
        {
            get => optionActions;
            protected set => optionActions = value;
        }

        private string[] options;
        private Action[] optionActions;

        public MainMenu()
        {
            options = new string[]
            {
                "Airport Menu",
                "Airline Menu",
                "Airplane Menu"
                
            };

            optionActions = new Action[]
            {
                
            };
        }
    }
}
