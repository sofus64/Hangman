using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Letter
    {
        private char _value;
        public bool _isHidden { get; set; }

        public Letter(char value, bool isHidden)
        {
            _value = value;
            _isHidden = isHidden;
        }

        public void RevealLetter()
        {
            _isHidden = false;
        }

        public char GetLetter()
        {
            return _value;
        }

        public bool IsHidden()
        {
            return _isHidden;
        }
    }
}
