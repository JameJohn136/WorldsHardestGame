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
        public int speed = 3;
        public int width = 15, height = 15;
        public int prevX, prevY;
        private int startX, startY;
        public int deaths;

        public Player(int _x, int _y)
        {
            x = _x;
            y = _y;

            // Set Spawn Point
            startX = x;
            startY = y;
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

            // Check to see if ANY floor is currently active, or else it only allows u in the first one

            if (!playerRec.IntersectsWith(floorRec))
            {
                return false;
            }

            return true;
        }

        public bool Collision(Ball ball)
        {
            Rectangle playerRec = new Rectangle(x, y, width, height);
            Rectangle ballRec = new Rectangle(ball.x, ball.y, ball.size, ball.size);

            // Check to see if the player collides with any balls

            if (playerRec.IntersectsWith(ballRec))
            {
                return true;
            }

            return false;
        }

        public bool Collision(WinArea winArea)
        {
            Rectangle playerRec = new Rectangle(x, y, width, height);
            Rectangle winRec = new Rectangle(winArea.x, winArea.y, winArea.size, winArea.size);

            if (playerRec.IntersectsWith(winRec))
            {
                return true;
            }

            return false;
        }

        public void Restart()
        {
            // Set player back to their spawn point
            x = startX;
            y = startY;
            deaths++;
            
        }
    }
}
