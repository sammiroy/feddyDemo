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
        // ROBOT AI NOTES
        /* The mechanics of how a robot's difficulty is used works like this: 
        The system will generate a random integer between 1 and 20, if the robot's
        difficulty setting is >= the system integer they are allowed to move
        otherwise they simply sit in place */

        #region Fields & Constructors
        // Feilds
        private string botName;
        private int botOrigin;
        private int botPos;
        private int botDifficulty;

        // Parameter Constructor
        public Robot(string BotName, int BotOrigin, int BotPos, int BotDifficulty)
        {
            botName = BotName;
            botOrigin = BotOrigin;
            botPos = BotPos;
            botDifficulty = BotDifficulty;
        }
        #endregion

        // Methods

        #region Return & Display
        // Show all of a given objects field stats
        public void showStats()
        {
            Console.WriteLine(this.botPos);
            Console.WriteLine(this.botDifficulty);
        }

        // Return the bot's current position
        public int returnBotPos()
        {
            return this.botPos;
        }
        #endregion

        #region Movement
        // If the bot's difficulty doesn't meet *or* exceed the challenge, they will not move
        public bool moveOpportunity(int challenge)
        {
            if (this.botDifficulty < challenge)
            {
                Console.WriteLine("move attempt failed...");
                return false;
            } else
            {
                Console.WriteLine("move attempt succeeded!");
                return true;
            }
        }

        // Shift the bot's position on the array
        public void moveBot(bool leftStat, bool rightStat)
        {
            if(botPos > 2)
            {
                // move closer to player or teleport to a random room
                Console.WriteLine("moved");

                this.botPos = this.botPos - 2;
            } else
            {
                // attack!
                Console.WriteLine("attacking...");
                this.attemptAttack(leftStat, rightStat);
            }
        }

        /* move the bot into the office if the door on their respective side of the
        map is open */
        public void attemptAttack(bool isLeftDoorClosed, bool isRightDoorClosed)
        {
            if ((botPos == 1) && (!isLeftDoorClosed))
            {
                // attack from left is successful
                Console.WriteLine("attacked from right!");
                this.botPos = 0;
            } else if ((botPos == 2) && (!isRightDoorClosed))
            {
                // attack from right is successful
                Console.WriteLine("attacked from left!");
                this.botPos = 0;
            } else
            {
                // neither attack is successful
                Console.WriteLine("attack failed...");
                this.botPos = this.botOrigin;
            }
        }
        #endregion
    }
}
