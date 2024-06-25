using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Word
    {
        protected string _value;
        protected Letter[] _letters;
        protected bool _isHidden = true;

        public Word(string value)
        {
            _value = value;
            _letters = CreateLetterList(value, _isHidden);
        }
        protected Letter[] CreateLetterList(string word, bool isHidden)
        {
            var letterList = new Letter[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                letterList[i] = new Letter(word[i], isHidden);
            }
            return letterList;
        }

        public string TypeWord()
        {
            string wordString = string.Empty;
            foreach (var letter in _letters)
            {
                if (!letter.IsHidden())
                {
                    wordString += letter.GetLetter();
                }
                else if (letter.IsHidden())
                {
                    wordString += '_';
                }
            }
            return wordString;
        }
        public bool IsRevealed()
        {
            var allLettersRevealed = _letters.All(letter => !letter.IsHidden());
            return allLettersRevealed;
        }

        public void CheckForLetter(char character)
        {
            foreach (var letter in _letters)
            {
                if (letter.GetLetter() == character)
                {
                    letter.RevealLetter();
                }
            }
        }

        public string GetValue()
        {
            return _value;
        }
    }

}
