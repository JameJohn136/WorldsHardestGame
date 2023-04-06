using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WorldsHardestGame
{
    internal class Ball
    {
        public int x, y, size, xSpeed, ySpeed;
        public Ball(int _x, int _y, int _size, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            size = _size;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }

        public bool Collision(Floor floor)
        {
            Rectangle ballRec = new Rectangle(x, y, size, size);
            Rectangle floorRec = new Rectangle(floor.x, floor.y, floor.width, floor.height);

            // Check to see if ANY floor is currently active, or else it only allows u in the first one

            if (ballRec.IntersectsWith(floorRec))
            {
                return true;
            }

            return false;
        }

        public void InvertSpeed()
        {
            xSpeed *= -1;
            ySpeed *= -1;
        }
    }
}
