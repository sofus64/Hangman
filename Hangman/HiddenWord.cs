using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class HiddenWord : Word
    {
        public HiddenWord(string value) : base(value)
        {
            _isHidden = true;
            _value = value;
            _letters = CreateLetterList(value, _isHidden);
        }

        public bool IsRevealed()
        {
            bool allRevealed = _letters.All(letter => !letter.IsHidden());
            return allRevealed;
        }
    }
}
