using Racheschach.Notation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet
{
    public class ColorPiece
    {
        public PieceType PieceType { get; set; }
        public Color Color { get; set; } //TODO: return some non-value when PieceType.None

        /// <summary>
        /// new ColorPiece of PieceType.None
        /// </summary>
        public ColorPiece()
        {
            PieceType = PieceType.None;
        }

        public ColorPiece(PieceType pieceType, Color color)
        {
            PieceType = pieceType;
            Color = color;
        }

        public ColorPiece(Piece piece)
        {
            PieceType = piece.ColorPiece.PieceType;
            Color = piece.ColorPiece.Color;
        }
    }

    public class Piece
    {

        public ColorPiece ColorPiece { get; set; }
        public PieceType PieceType => ColorPiece.PieceType;

        public Color Color => ColorPiece.Color;

        public Char UniCode => NotationHelpers.GetUniCodeForPiece(Color, PieceType);
        public Char FEN => NotationHelpers.GetFENForPiece(Color, PieceType);

        public Square Square { get; set; }

        /// <summary>
        /// new piece of PieceType.None
        /// </summary>
        public Piece(Square square)
        {
            ColorPiece = new ColorPiece();
            Square = square;
        }

        public Piece(PieceType pieceType, Color color, Square square)
        {
            ColorPiece = new ColorPiece(pieceType, color);
            Square = square;
        }

        public Piece(ColorPiece colorPiece, Square square)
        {
            ColorPiece = new ColorPiece(colorPiece.PieceType, colorPiece.Color);
            Square = square;
        }

        public List<Move> GetPossibleMoves()
        {
            switch (PieceType)
            {
                case PieceType.None: throw new NotImplementedException();
                case PieceType.King: throw new NotImplementedException();
                case PieceType.Queen: throw new NotImplementedException();
                case PieceType.Rook: return GetPossibleMovesForRook();
                case PieceType.Bishop: return GetPossibleMovesForBishop();
                case PieceType.Knight: throw new NotImplementedException();
                case PieceType.Pawn: throw new NotImplementedException();
                default: throw new Exception();
            }
        }

        private List<Move> GetPossibleMovesForRook()
        {
            List<Move> moves = new List<Move>();

            var squaresInAllDirections = new List<List<Square>>() { Square.NorthSquares,
                                                                  Square.EastSquares,
                                                                  Square.SouthSquares,
                                                                  Square.WestSquares };

            foreach (List<Square> squaresInDirection in squaresInAllDirections)
            {
                foreach (var nextSquare in squaresInDirection)
                {
                    if (nextSquare.HasFriendlyPiece(this.Color)) break; // friendly piece -> can't go there
                    moves.Add(new Move(this.Square, nextSquare));
                    if (nextSquare.HasEnemyPiece(this.Color)) break;    // enemy piece -> can't go beyond
                }
            }

            return moves;
        }

        private List<Move> GetPossibleMovesForBishop()
        {
            List<Move> moves = new List<Move>();

            var squaresInAllDirections = new List<List<Square>>() {Square.NorthWestSquares,
                                                                   Square.NorthEastSquares,
                                                                   Square.SouthEastSquares,
                                                                   Square.SouthWestSquares};

            foreach (List<Square> squaresInDirection in squaresInAllDirections)
            {
                foreach (var nextSquare in squaresInDirection)
                {
                    if (nextSquare.HasFriendlyPiece(this.Color)) break; // friendly piece -> can't go there
                    moves.Add(new Move(this.Square, nextSquare));
                    if (nextSquare.HasEnemyPiece(this.Color)) break;    // enemy piece -> can't go beyond
                }
            }

            return moves;
        }
    }
}
