using System;
using System.Runtime;
using System.Diagnostics;

namespace feddyDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Initiation
            // Welcome Notice
            Console.WriteLine("feddyDemo version 0.0.1");
            Console.WriteLine("By Samantha Roy");

            // Init variables
            RNG systemRoll = new RNG();
            bool loop = true;
            int ponContain = 9;
            int[] roomArr = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int nt = PlayerChoice();
            Console.WriteLine(nt);

            // Init objects
            Robot freddy = new Robot("Freddy", roomArr[10], roomArr[0], 10); // Origin, Position, Agression

            #endregion


            #region Game Loop
            // Menu Loop
            while (loop)
            {
                int botPos = freddy.returnBotPos();
                // Check if a robot is in the office, if not, move on
                if (botPos == 0)
                {
                    break;
                }
                

            }
            Console.WriteLine("Goodbye");
            Console.ReadLine();
            #endregion
        }

        public static int PlayerChoice()
        {
            int choice = 0;

            Console.Write("WHAT WOULD YOU LIKE TO DO?\n" +
                "1. Check cameras\n" +
                "2. Check left door\n" +
                "3. Check right door\n" +
                "4. Close left door\n" +
                "5. Close right door\n" +
                "6. Do nothing\n");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}