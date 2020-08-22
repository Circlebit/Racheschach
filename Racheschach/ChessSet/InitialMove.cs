using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet
{
    public class InitialMove : IMove, IEquatable<IMove>, IEquatable<Move>
    {
        public Square From => null;

        public Square To => null;

        public IMove LastMove => null;

        public ColorPiece ColorPiece => null;

        public Color Color => Color.Black;

        public bool TakesPiece => false;

        public Square EnPassant => null;

        public bool IsHalfMove => false;

        public int HalfMoves => 0;

        public bool WhiteCanCastleKingside => true;

        public bool WhiteCanCastleQueenside => true;

        public bool BlackCanCastleKingside => true;

        public bool BlackCanCastleQueenside => true;

        public int MoveNumber => 0;

        public Board Board { get; set; }

        public InitialMove(Board board)
        {
            Board = board;
        }

        public bool Equals(IMove other)
        {
            return other is InitialMove;
        }

        public bool Equals(Move other)
        {
            return false;
        }
    }
}
