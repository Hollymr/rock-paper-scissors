using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RandomAI : IPlayer
    {
        Random random = new Random(); //outside to only generate one random generator, otherwise will keep creating

        public int NextMove()
        {
            // 0: Rock, 1: Paper, 2: Scissors 
            return random.Next(0, 3);
        }

        public void SaveResult(int myMove, int otherMove)
        {
            // do nothing method
            // going to choose random move so doesn't need to remember pervious move
        }
    }
}
