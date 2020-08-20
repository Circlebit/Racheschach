using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet
{
    public class Move
    {
        public Square From { get; }
        public Square To { get; }

        public Move LastMove { get; }

        public Piece Piece => From.Piece;
        public Color Color => GameHelpers.GetOppositeColor(LastMove.Color);
        public bool TakesPiece => To.IsEnemyPiece(Color);

        private Board Board => From.Board;

        public Move(Square from, Square to)
        {
            From = from;
            To = to;

            LastMove = Board.Moves.Peek();
        }
    }
}
