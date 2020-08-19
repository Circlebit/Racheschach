using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet
{
    public class Move
    {
        public Square From { get; set; }
        public Square To { get; set; }
        public Piece Piece { get; set; }
        public Color Color { get; set; }
        public bool TakesPiece => To.IsEnemyPiece(Color);

        public Move(Square from, Square to)
        {

        }
    }
}
