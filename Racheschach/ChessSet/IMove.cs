using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Racheschach.ChessSet
{
    public interface IMove : IEquatable<IMove>, IEquatable<Move>
    {
        Square From { get; }
        Square To { get; }

        IMove LastMove { get; }

        ColorPiece ColorPiece { get; }
        Color Color { get; }
        bool TakesPiece { get; }

        Square EnPassant { get; }

        bool IsHalfMove { get; }
        int HalfMoves { get; }

        bool WhiteCanCastleKingside { get; }
        bool WhiteCanCastleQueenside { get; }
        bool BlackCanCastleKingside { get; }
        bool BlackCanCastleQueenside { get; }

        int MoveNumber { get; }
        Board Board { get; }

    }

    public class MoveEqualityComparer : IEqualityComparer<IMove>
    {
        public bool Equals(IMove x, IMove y)
        {
            return x.Board.Equals(y.Board)
                && (x.From.Equals(y.From))
                && (x.To.Equals(y.To));
        }

        public int GetHashCode(IMove obj)
        {
            return obj.Board.GetHashCode() * 17 + obj.From.GetHashCode() + obj.To.GetHashCode();
        }
    }
}