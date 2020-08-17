using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet
{
    public class Square
    {
        public int X { get; set; }
        public int Y { get; set; }

        public string Notation => NotationHelpers.SquareNotationByArrayIndex(X, Y);

        public Square(int x, int y)
        {
            X = x;
            Y = y;
        }


    }
}
