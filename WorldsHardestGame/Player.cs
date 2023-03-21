using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldsHardestGame
{
    internal class Player
    {
        public int x, y;
        public int speed = 6;
        public int width = 15, height = 15;

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
    }
}
