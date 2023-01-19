﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    internal class ExitCommand : ICommand
    {
        public char Char => 'X';

        public void Run()
        {
            Environment.Exit(0);
        }
    }
}
