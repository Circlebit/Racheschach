using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Racheschach.ChessSet
{
    public class Square : IEquatable<Square>
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

        public List<Square> NorthSquares => Y < 7 ? new List<Square>(Column).GetRange(Y + 1, 7 - Y) : new List<Square>();
        public List<Square> EastSquares => X < 7 ? new List<Square>(Row).GetRange(X + 1, 7 - X) : new List<Square>();
        public List<Square> SouthSquares
        {
            get
            {
                if(Y > 0)
                {
                    var southSquares = new List<Square>(Column).GetRange(0, Y);
                    southSquares.Reverse();
                    return southSquares;
                }
                else return new List<Square>();
            }
        }
        public List<Square> WestSquares
        {
            get
            {
                if(X > 0)
                {
                    var westSquares = new List<Square>(Row).GetRange(0, X);
                    westSquares.Reverse();
                    return westSquares;
                }
                else return new List<Square>();
            }
        }
        public List<Square> NorthEastSquares
        {
            get
            {
                if(Y < 7 && X < 7)
                {
                    var northEastSquares = new List<Square>();
                    for (int x = X + 1, y = Y + 1; x <= 7 && y <= 7; x++, y++)
                    {
                        northEastSquares.Add(Board.Squares[x, y]);
                    }
                    return northEastSquares;
                }
                else return new List<Square>();
            }
        }

        public Square[] Row => Board.GetRowByIndex(Y);
        public Square[] Column => Board.GetColumnByIndex(X);
        public char RowName => BoardHelpers.RowIndexToRowName(Y);
        public char ColumnName => BoardHelpers.ColumnIndexToColumnName(X);

        public bool IsFree => Piece.PieceType == PieceType.None;
        
        //TODO: uncomment this after dev
        //public List<Square> ThreateningSquares => GetThreateningSquares();
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

        //TODO: Square.GetThreateningSquares()
        //private List<Square> GetThreateningSquares() //TODO: Square.GetThreateningSquares()
        //{
        //    throw new NotImplementedException();
        //}

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

        public bool Equals(Square other)
        {
            try
            {
                return (this.X == other.X && this.Y == other.Y);
            }
            catch { return false; }
        }
    }
}
