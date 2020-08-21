﻿namespace Racheschach.ChessSet
{
    public interface IMove
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

    }
}