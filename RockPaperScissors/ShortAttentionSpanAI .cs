using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ShortAttentionSpanAI : IPlayer
    {

        /// <summary>
        /// The ShortAttentionSpanAI class will need to do something in SaveResult to keep track of moves as it sees them.
        /// Once it has seen a move, it assumes that a player will play the same move again, 
        /// and for its next move picks the move that will beat that move. 
        /// For example, if it sees Rock, it picks Paper as its next move (because Paper beats Rock).
        /// </summary>
        /// <returns></returns>
        
        int savedPlay;        

        public int NextMove()
        {

                if (savedPlay == 0)
                {
                    return 1;
                }
                if (savedPlay == 1)
                {
                    return 2;
                }
                else return 0;

        }

        public void SaveResult(int myMove, int otherMove)
        {           
            savedPlay = otherMove;
        }
    }
}
