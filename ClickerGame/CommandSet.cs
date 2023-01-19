using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    internal class CommandSet
    {
        private ICommand[] Commands;
        
        public CommandSet(ClickerGame game)
        {
            Commands = new ICommand[4]
            {
                new CLickCommand(game),
                new BuyUpgrade(game),
                new BuySuperUpgrade(game),
                new ExitCommand()
            };
        }

        public void RunCommand(char _char)
        {
            foreach (var command in Commands)
            {
                if (command.Char == _char) command.Run();
            }
        }
    }
}
