using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet
{
    public class Move : IMove
    {
        public Square From { get; }
        public Square To { get; }

        public IMove LastMove { get; }

        public ColorPiece ColorPiece { get; }
        public Color Color => LastMove.Color.Opposite();
        public bool TakesPiece => To.HasEnemyPiece(Color);

        public Square EnPassant => GetEnPassant();

        private Square GetEnPassant()
        {
            var foo = Color.PawnRow();

            if (ColorPiece.PieceType == PieceType.Pawn
                && From.RowName == Color.PawnRow()
                && To == From.Forwards(Color).Forwards(Color))
                return From.Forwards(Color);
            else return null;
        }

        public bool IsHalfMove => !TakesPiece && ColorPiece.PieceType != PieceType.Pawn;
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
            ColorPiece = new ColorPiece(from.Piece);

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
