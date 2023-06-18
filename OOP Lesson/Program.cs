using System;
using System.Drawing;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Block IBlock = new Block(); //object for block L

            IBlock.shape = "I";
            IBlock.positionx = 0;
            IBlock.positiony = 100;
            IBlock.color = "Orange";
            IBlock.speed = 1;
            IBlock.orientation = "Vertical";

            IBlock.RotateLeft(); //call method in IBLock class

            Console.WriteLine($"Current orientation: {IBlock.orientation}");

        }
    }
}
