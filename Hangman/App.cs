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
            var man = new Man();
            game.SetWord(myConsole.ChooseDifficulty());
            while (!game.UsedAllAttempts() && !game.WordIsGuessed())
            {
                Console.WriteLine($"forsøk brukt: {game.GetAttempts()}");
                Console.WriteLine($"ord: {game._word.TypeWord()}");
                Console.WriteLine($"feil: {game.getIncorrectAttempts()} av {game.MaxAttempts}");
                Console.WriteLine("gjettede ord: " + string.Join(", ", game._guessedLetters));
                man.draw(game._guessedIncorrectLetters.Count);
                game.GuessLetter();
                Console.Clear();
            }
        }
    }
}
