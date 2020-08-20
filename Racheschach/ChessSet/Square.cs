using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet
{
    public class Square
    {
        public int X { get; }
        public int Y { get; }
        public Piece Piece { get; }
        public Board Board { get;  }

        public List<Square> Neighbors { get; set; }
        public Square NorthNeighbor { get; set; }
        public Square NorthEastNeighbor { get; set; }
        public Square EastNeighbor { get; set; }
        public Square SouthEastNeighbor { get; set; }
        public Square SouthNeighbor { get; set; }
        public Square SouthWestNeighbor { get; set; }
        public Square WestNeighbor { get; set; }
        public Square NorthWestNeighbor { get; set; }

        public bool IsFree => Piece.PieceType == PieceType.None;
        public List<Square> ThreateningSquares => GetThreateningSquares();
        public string Notation => BoardHelpers.SquareNotationByArrayIndex(X, Y);

        public Square(int x, int y, Board board)
        {
            X = x;
            Y = y;
            Piece = new Piece(PieceType.None, this);
            Board = board;
            Neighbors = new List<Square>();
        }

        public bool IsFriendlyPiece(Color friendlyColor)
        {
            return (!IsFree && Piece.Color == friendlyColor);
        }

        public bool IsEnemyPiece(Color friendlyColor)
        {
            return (!IsFree && Piece.Color == friendlyColor.Opposite());
        }

        private List<Square> GetThreateningSquares() //TODO: Square.GetThreateningSquares()
        {
            throw new NotImplementedException();
        }
    }
}
