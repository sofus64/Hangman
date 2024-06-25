using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Game
    {
        public Word _word { get; set; }
        private int _attempts;
        private const int MaxAttempts = 10;
        private List<char> _guessedIncorrectLetters = new();

        public bool UsedAllAttempts()
        {
            if (_attempts >= MaxAttempts)
            {
                Console.WriteLine("Du brukte opp alle forsøkene dine!");
                Console.WriteLine($"Ordet var {_word.GetValue()}.");
                return true;
            }
            return false;
        }

        public bool WordIsGuessed()
        {
            if (_word.IsRevealed())
            {
                Console.WriteLine($"Du gjettet ordet på {_attempts} forsøk!");
            }
            return _word.IsRevealed();
        }

        public void SetWord(string difficulty)
        {
            WordList worldList = new();
            _word = new Word(worldList.GetRandomWord(difficulty).ToLower());
        }

        public int GetAttempts()
        {
            return _attempts;
        }

        public void GuessLetter()
        {
            var takingInput = true;
            while (takingInput)
            {
                var character = Console.ReadKey(true).KeyChar;
                var lowerCaseChar = CharToLowercase(character);

                if (char.IsLetter(character) && !_guessedIncorrectLetters.Contains(lowerCaseChar))
                {
                    _word.CheckForLetter(lowerCaseChar);
                    if (!_word.GetValue().Contains(lowerCaseChar))
                    {
                        _guessedIncorrectLetters.Add(lowerCaseChar);
                    }
                    takingInput = false;
                    _attempts = _guessedIncorrectLetters.Count;
                }
            }
        }

        private char CharToLowercase(char character)
        {
            var lowerCaseCharString = character.ToString().ToLower();
            var lowerCaseChar = lowerCaseCharString.ToCharArray()[0];

            return lowerCaseChar;
        }
    }
}
