using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Racheschach.ChessSet
{
    public class Square
    {
        public int X { get; }
        public int Y { get; }
        public Piece Piece { get; set; }
        public Board Board { get; }

        public List<Square> Neighbors { get; set; }
        public Square North { get; set; }
        public Square NorthEast { get; set; }
        public Square East { get; set; }
        public Square SouthEast { get; set; }
        public Square South { get; set; }
        public Square SouthWest { get; set; }
        public Square West { get; set; }
        public Square NorthWest { get; set; }

        public char RowName => BoardHelpers.RowIndexToRowName(Y);
        public char ColumnName => BoardHelpers.ColumnIndexToColumnName(X);

        public bool IsFree => Piece.PieceType == PieceType.None;
        public List<Square> ThreateningSquares => GetThreateningSquares();
        public string Notation => BoardHelpers.SquareNotationByArrayIndex(X, Y);

        public Square(int x, int y, Board board)
        {
            X = x;
            Y = y;
            Piece = new Piece(this);
            Board = board;
            Neighbors = new List<Square>();
        }

        public bool HasFriendlyPiece(Color friendlyColor)
        {
            return (!IsFree && Piece.Color == friendlyColor);
        }

        public bool HasEnemyPiece(Color friendlyColor)
        {
            return (!IsFree && Piece.Color == friendlyColor.Opposite());
        }

        private List<Square> GetThreateningSquares() //TODO: Square.GetThreateningSquares()
        {
            throw new NotImplementedException();
        }

        public void SetPiece(ColorPiece colorPiece)
        {
            Piece.ColorPiece.PieceType = colorPiece.PieceType;
            Piece.ColorPiece.Color = colorPiece.Color;
        }

        /// <summary>
        /// set piece to None
        /// </summary>
        public void SetPiece()
        {
            SetPiece(new ColorPiece());
        }


        public Square Forwards(Color color)
        {
            switch (color)
            {
                case Color.White: return North;
                case Color.Black: return South;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public Square ForwardsRight(Color color)
        {
            switch (color)
            {
                case Color.White: return NorthEast;
                case Color.Black: return SouthWest;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public Square Right(Color color)
        {
            switch (color)
            {
                case Color.White: return East;
                case Color.Black: return West;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public Square BackwardsRight(Color color)
        {
            switch (color)
            {
                case Color.White: return SouthEast;
                case Color.Black: return NorthWest;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public Square Backwards(Color color)
        {
            switch (color)
            {
                case Color.White: return South;
                case Color.Black: return North;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public Square BackwardsLeft(Color color)
        {
            switch (color)
            {
                case Color.White: return SouthWest;
                case Color.Black: return NorthEast;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public Square Left(Color color)
        {
            switch (color)
            {
                case Color.White: return West;
                case Color.Black: return East;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public Square ForwardsLeft(Color color)
        {
            switch (color)
            {
                case Color.White: return NorthWest;
                case Color.Black: return SouthEast;
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
