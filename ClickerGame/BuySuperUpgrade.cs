using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    internal class BuySuperUpgrade : ICommand
    {
        private ClickerGame _game;
        public char Char { get; } = 'S';
        public BuySuperUpgrade(ClickerGame game)
        {
            _game = game;
        }
        public void Run()
        {
            _game.BuySuperUpgrade();
        }
    }
}
