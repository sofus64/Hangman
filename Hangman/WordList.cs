using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class WordList
    {
        private readonly List<string> _easyWords =
        [
            "Apple",
            "Bread",
            "House",
            "Chair",
            "Beach",
            "Table",
            "Money",
            "Heart",
            "Smile",
            "River"
        ];
        private readonly List<string> _mediumWords =
        [
            "Library",
            "Journey",
            "Mountain",
            "Picture",
            "Diamond",
            "Fantasy",
            "Monster",
            "Mystery",
            "Courage",
            "Thunder"
        ];
        private readonly List<string> _hardWords =
        [
            "Algorithm",
            "Archaeology",
            "Eccentric",
            "Hypothesis",
            "Kaleidoscope",
            "Labyrinth",
            "Quarantine",
            "Synchronous",
            "Zephyr",
            "Phenomenon"
        ];
        private readonly Random _random = new();

        public string GetRandomWord(string difficulty)
        {
            var randomWord = difficulty switch
            {
                "easy" => _easyWords[_random.Next(0, 10)],
                "medium" => _mediumWords[_random.Next(0, 10)],
                "hard" => _hardWords[_random.Next(0, 10)],
                _ => string.Empty
            };
            return randomWord;
        }
    }
}
