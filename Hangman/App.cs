using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class App
    {
        public void Run()
        {
            var myConsole = new MyConsole();
            Game game = new();

            game.SetWord(myConsole.ChooseDifficulty());
            while (!game.UsedAllAttempts() && !game.WordIsGuessed())
            {
                Console.WriteLine($"forsøk brukt: {game.GetAttempts()}");
                Console.WriteLine($"ord: {game._word.TypeWord()}");
                game.GuessLetter();
                Console.Clear();
            }
        }
    }
}
