using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Man
    {
        private List<string> man = new()
        {
            "|",
            "|",
            "O",
            "|",
            "-",
            "-",
            "-",
            "-",
            "-",
            "|",
            "/", 
            @"\",
        };

        public void draw(int mistakes)
        {
            List<string> currentMan = new List<string>();

            for (int i = 0; i < man.Count; i++)
            {
                if(i < mistakes) currentMan.Add(man[i]);
                else currentMan.Add("");
            }
            Console.SetCursorPosition(3, 5);
            Console.Write($@"
        {currentMan[0]}
        {currentMan[1]}
        {currentMan[2]}
        {currentMan[3]}
      {currentMan[4]}{currentMan[5]}{currentMan[6]}{currentMan[7]}{currentMan[8]}
        {currentMan[9]}
       {currentMan[10]} {currentMan[11]}
");
        }

    }
}
