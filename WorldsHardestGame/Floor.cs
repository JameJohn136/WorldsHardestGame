using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldsHardestGame
{
    internal class Floor
    {
        public int x, y;
        public int width, height;

        public Floor (int _x, int _y, int _width, int _height)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
        }
    }
}
