using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class MyConsole
    {
        public string ChooseDifficulty()
        {
            var difficulty = string.Empty;
            Console.WriteLine("Velg vanskelighetsgrad:");
            Console.WriteLine("1. Lett");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Vanskelig");


            while (difficulty == string.Empty)
            {
                var userInput = Console.ReadLine();
                var userInputNum = Convert.ToInt32(userInput);

                switch (userInputNum)
                {
                    case 1:
                        difficulty = "easy";
                        break;
                    case 2:
                        difficulty = "medium";
                        break;
                    case 3:
                        difficulty = "hard";
                        break;
                }
            }
            Console.Clear();
            return difficulty;
        }


    }
}
