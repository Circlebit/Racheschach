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
        public bool TakesPiece => To.IsEnemyPiece(From.Piece.Color);

        public Move(Square from, Square to)
        {

        }
    }
}
