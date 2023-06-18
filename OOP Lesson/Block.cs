using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Block
    {
        public string shape;
        public double positionx;
        public double positiony;
        public string color;
        public int speed;
        public string orientation;

        public void RotateLeft()
        {
            Console.WriteLine("Rotating Left");
            orientation = "Horizontal";
        }

        public void RotateRight()
        {

        }

        public void Hold()
        {

        }

        public void MoveLeft()
        {

        }

        public void MoveRight()
        {

        }

        public void MoveDown()
        {

        }

        public void Drop()
        {

        }

    }
}
