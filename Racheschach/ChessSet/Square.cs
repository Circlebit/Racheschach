using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet
{
    public class Square
    {
        public int X { get; }
        public int Y { get; }
        public Piece Piece { get; }

        public string Notation => NotationHelpers.SquareNotationByArrayIndex(X, Y);

        public Square(int x, int y)
        {
            X = x;
            Y = y;
            Piece = new Piece(Color.None, PieceType.None);
        }


    }
}
