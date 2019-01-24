using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tic_tac_toe_game.model
{
    class Cell
    {
        public enum Type { Empty, Cross, Zero}
        readonly Point point;
        public Type type = Type.Empty;
        public Cell(Point p) => point = p;
        public bool IsEmpty
        {
            get
            {
                return type == Type.Empty;
            }
        } 
    }
}
