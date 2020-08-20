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
        public Color Color => LastMove.Color.Opposite();
        public bool TakesPiece => To.HasEnemyPiece(Color);

        public bool IsHalfMove => !TakesPiece && Piece.PieceType != PieceType.Pawn;
        public int HalfMoves => IsHalfMove ? LastMove.HalfMoves + 1 : 0;

        public bool WhiteCanCastleKingside { get; private set; }
        public bool WhiteCanCastleQueenside { get; private set; }
        public bool BlackCanCastleKingside { get; private set; }
        public bool BlackCanCastleQueenside { get; private set; }

        public int MoveNumber { get; }

        private Board Board => From.Board;

        public Move(Square from, Square to)
        {
            From = from;
            To = to;

            LastMove = Board.Moves.Peek();

            MoveNumber = Board.Fullmoves;

            //TODO: calc rochade
            WhiteCanCastleKingside = true;
            WhiteCanCastleQueenside = true;
            BlackCanCastleKingside = true;
            BlackCanCastleQueenside = true;
        }
    }
}
