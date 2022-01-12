using System;
using System.Runtime;
using System.Diagnostics;

namespace feddyDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Welcome Notice
            Console.WriteLine("feddyDemo version 0.0.1");
            Console.WriteLine("By Samantha Roy");

            // Test Fuctions
            Robot robot1 = new Robot("Freddy", 0, 0, 0);
            robot1.showBotPos();

            // Menu Loop
            bool loop = true;
            while (loop)
            {
                loop = false;
            }
        }

    }
}