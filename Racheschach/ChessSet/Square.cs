using System;
using System.Collections.Generic;
using System.Linq;
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

        // TODO: Remove or reimplement
        //public List<Square> Neighbors { get; set; }
        public Square North => NorthSquares.FirstOrDefault();
        public Square NorthEast => NorthEastSquares.FirstOrDefault();
        public Square East => EastSquares.FirstOrDefault();
        public Square SouthEast => SouthEastSquares.FirstOrDefault();
        public Square South => SouthSquares.FirstOrDefault();
        public Square SouthWest => SouthWestSquares.FirstOrDefault();
        public Square West => WestSquares.FirstOrDefault();
        public Square NorthWest => NorthWestSquares.FirstOrDefault();

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
        public List<Square> SouthEastSquares
        {
            get
            {
                if (Y > 0 && X < 7)
                {
                    var southEastSquares = new List<Square>();
                    for (int x = X + 1, y = Y - 1; x <= 7 && y >= 0; x++, y--)
                    {
                        southEastSquares.Add(Board.Squares[x, y]);
                    }
                    return southEastSquares;
                }
                else return new List<Square>();
            }
        }
        public List<Square> SouthWestSquares
        {
            get
            {
                if (Y > 0 && X > 0)
                {
                    var southEastSquares = new List<Square>();
                    for (int x = X - 1, y = Y - 1; x >= 0 && y >= 0; x--, y--)
                    {
                        southEastSquares.Add(Board.Squares[x, y]);
                    }
                    return southEastSquares;
                }
                else return new List<Square>();
            }
        }
        public List<Square> NorthWestSquares
        {
            get
            {
                if (Y < 7 && X > 0)
                {
                    var northWestSquares = new List<Square>();
                    for (int x = X - 1, y = Y + 1; x >= 0 && y <= 7; x--, y++)
                    {
                        northWestSquares.Add(Board.Squares[x, y]);
                    }
                    return northWestSquares;
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
