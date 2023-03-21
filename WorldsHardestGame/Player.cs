using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WorldsHardestGame
{
    internal class Player
    {
        public int x, y;
        public int speed = 6;
        public int width = 15, height = 15;
        public int PrevX, PrevY;

        public Player(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void Move(string direction)
        {
            if (direction == "up")
            {
                y -= speed;
            }
            if (direction == "down")
            {
                y += speed;
            }

            if (direction == "left")
            {
                x -= speed;
            }

            if (direction == "right")
            {
                x += speed;
            }
        }

        public bool Collision(Floor floor)
        {
            Rectangle playerRec = new Rectangle(x, y, width, height);
            Rectangle floorRec = new Rectangle(floor.x, floor.y, floor.width, floor.height);

            if (!playerRec.IntersectsWith(floorRec))
            {
                x = PrevX;
                y = PrevY;
            }

            PrevX = x;
            PrevY = y;

            return true;
        }
    }
}
