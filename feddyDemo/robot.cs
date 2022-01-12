using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace feddyDemo
{
    public class Robot
    {
        // Feilds
        private string botName;
        private int botId;
        private int botPos;
        private int botDifficulty;
        private int botRandInt;

        // Parameter Constructor
        public Robot(string BotName, int BotId, int BotPos, int BotDifficulty)
        {
            botName = BotName;
            botId = BotId;
            botPos = BotPos;
            botDifficulty = BotDifficulty;
            botRandInt = 0;
        }

        // Methods
        public void showBotPos()
        {
            Console.WriteLine($"{this.botName} is on camera number {this.botPos}.");
        }

    }
}
