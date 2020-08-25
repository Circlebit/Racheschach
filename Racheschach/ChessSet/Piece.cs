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
                case PieceType.Bishop: throw new NotImplementedException();
                case PieceType.Knight: throw new NotImplementedException();
                case PieceType.Pawn: throw new NotImplementedException();
                default: throw new Exception();
            }
        }

        private List<Move> GetPossibleMovesForRook()
        {
            List<Move> moves = new List<Move>();
            Square nextSquare;

            //TODO: do this in a nice Loop instead four times

            //Moves towards North
            nextSquare = this.Square;
            while (nextSquare.North != null)
            {
                nextSquare = nextSquare.North;
                // friendly piece on nextSquare -> can't go there
                if (nextSquare.HasFriendlyPiece(this.Color)) break;
                moves.Add(new Move(this.Square, nextSquare));
                // enemy piece of nextSquare -> can't go beyond
                if (nextSquare.HasEnemyPiece(this.Color)) break;
            }

            //Moves towards East
            nextSquare = this.Square;
            while (nextSquare.East != null)
            {
                nextSquare = nextSquare.East;
                if (nextSquare.HasFriendlyPiece(this.Color)) break;
                moves.Add(new Move(this.Square, nextSquare));
                if (nextSquare.HasEnemyPiece(this.Color)) break;
            }

            //Moves towards South
            nextSquare = this.Square;
            while (nextSquare.South != null)
            {
                nextSquare = nextSquare.South;
                if (nextSquare.HasFriendlyPiece(this.Color)) break;
                moves.Add(new Move(this.Square, nextSquare));
                if (nextSquare.HasEnemyPiece(this.Color)) break;
            }

            //Moves towards West
            nextSquare = this.Square;
            while (nextSquare.West != null)
            {
                nextSquare = nextSquare.West;
                if (nextSquare.HasFriendlyPiece(this.Color)) break;
                moves.Add(new Move(this.Square, nextSquare));
                if (nextSquare.HasEnemyPiece(this.Color)) break;
            }

            return moves;
        }

        private List<Move> GetPossibleMovesForRookXXX()
        {
            List<Move> moves = new List<Move>();
            Square nextSquare;

            //TODO: do this in a nice Loop instead four times

            //Moves towards North
            nextSquare = this.Square;
            while (nextSquare.North != null)
            {
                nextSquare = nextSquare.North;
                // friendly piece on nextSquare -> can't go there
                if (nextSquare.HasFriendlyPiece(this.Color)) break;
                moves.Add(new Move(this.Square, nextSquare));
                // enemy piece of nextSquare -> can't go beyond
                if (nextSquare.HasEnemyPiece(this.Color)) break;
            }

            //Moves towards East
            nextSquare = this.Square;
            while (nextSquare.East != null)
            {
                nextSquare = nextSquare.East;
                if (nextSquare.HasFriendlyPiece(this.Color)) break;
                moves.Add(new Move(this.Square, nextSquare));
                if (nextSquare.HasEnemyPiece(this.Color)) break;
            }

            //Moves towards South
            nextSquare = this.Square;
            while (nextSquare.South != null)
            {
                nextSquare = nextSquare.South;
                if (nextSquare.HasFriendlyPiece(this.Color)) break;
                moves.Add(new Move(this.Square, nextSquare));
                if (nextSquare.HasEnemyPiece(this.Color)) break;
            }

            //Moves towards West
            nextSquare = this.Square;
            while (nextSquare.West != null)
            {
                nextSquare = nextSquare.West;
                if (nextSquare.HasFriendlyPiece(this.Color)) break;
                moves.Add(new Move(this.Square, nextSquare));
                if (nextSquare.HasEnemyPiece(this.Color)) break;
            }

            return moves;
        }


    }
}
