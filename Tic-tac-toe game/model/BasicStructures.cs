using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tic_tac_toe_game.model
{
    struct Point
    {
        public readonly int x;
        public readonly int y;

        public Point(int cx,int cy)
        {
            x = cx;
            y = cy;
        }
    }
    struct Size
    {
        public readonly int width;
        readonly int height;
        public int Area => width * height;

        public Size(int w,int h)
        {
            width = w;
            height = h;
        }
    }
}
