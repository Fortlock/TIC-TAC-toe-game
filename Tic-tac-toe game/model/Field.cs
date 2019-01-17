using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tic_tac_toe_game.model
{
    class Generator
    {
        int width;
        public Generator(int w) => width = w;

        public Cell generate(int index) => new Cell(pointForIndex(index));

        Point pointForIndex(int index) => new Point(index % width, index / width);
        public int IndexForPoint(Point p) => p.y * width + p.x;
    }
    class Field
    {
        Size size = new Size(3, 3);
        List<Cell> cells = new List<Cell>();
        Generator generator;
        public Field()
        {
            generator = new Generator(size.width);
            for (int i = 0; i < size.Area; i++)
                cells.Add(generator.generate(i));
        }

        bool isAvailable(Point p) => (generator.IndexForPoint(p) >= 0 && generator.IndexForPoint(p) < size.Area);

        public Cell this[Point p]
        {
            get {
                if (isAvailable(p))
                    return cells[generator.IndexForPoint(p)];
                else
                    return null;
            }
        }

        List<Cell> getHorizontal(int index) => new List<Cell> { this[new Point(0,index)], this[new Point(1, index)], this[new Point(2, index)]};
        List<Cell> getVertical(int index) => new List<Cell> { this[new Point(index,0)], this[new Point(index,1)], this[new Point(index,2)]};
        List<Cell> getMainDiagonal() => new List<Cell> { this[new Point(0, 0)], this[new Point(1, 1)], this[new Point(2, 2)]};
        List<Cell> getSideDiagonal() => new List<Cell> { this[new Point(0, 2)], this[new Point(1, 1)], this[new Point(2, 0)]};
    }
}
