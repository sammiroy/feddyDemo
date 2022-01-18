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

            // Init objects
            Robot freddy = new Robot("Freddy", 10, 5, 5); // Origin, Position, Agression

            // Init variables
            RNG systemRoll = new RNG();
            bool loop = true;
            int posCheck = freddy.returnBotPos();
            #endregion

            #region Game Loop
            // Menu Loop
            while (loop)
            {
                // Check if a robot is in the office, if not, move on
                if (posCheck == 0)
                {
                    // Player dies end loop
                    Console.WriteLine("You died, something got inside!");
                    loop = false;
                }

                // Reveal System Int & Robot Stats
                Console.WriteLine(systemRoll.returnRoll());
                freddy.showStats();

                // Roll and compare 
            }
            #endregion
        }
    }
}