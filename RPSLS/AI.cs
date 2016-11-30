using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI: Player
    {

        Random choice = new Random();
        public override void MakeChoice()
        {            
            playerChoice = gestures[choice.Next(0,5)];            
        }
    }
}
