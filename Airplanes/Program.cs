﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplanes
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuManager.Instance.ChangeMenu(new MainMenu());
        }
    }
}
