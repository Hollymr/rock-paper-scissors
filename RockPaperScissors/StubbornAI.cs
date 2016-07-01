using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StubbornAI : IPlayer
    {

        /// <summary>
        /// The StubbornAI class is meant to pick a favorite move, and always play that move. 
        /// You will need to write a constructor for it to specify which move it should always play, 
        /// then the NextMove method should always return that move. 
        /// SaveResult can be blank for this class.
        /// </summary>
        /// <returns></returns>
        public int Move { get; set; }
      
        public StubbornAI(int favoriteMove)
        {
            favoriteMove = 2;
            Move = favoriteMove;
        }

        public int NextMove()
        {
            return Move;
        }

        public void SaveResult(int myMove, int otherMove)
        {
            //do nothing
        }
    }
}
