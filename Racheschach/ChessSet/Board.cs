using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet
{
    public class Board
    {
        public Square[,] Squares { get; set; }
        public List<Move> Moves { get; set; }

        public Board()
        {
            Squares = new Square[8, 8];

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Squares[x, y] = new Square(x, y);
                }
            }

            SetupGame();
        }

        public Square GetSquareBySquareNotation(string notation)
        {
            var coords = NotationHelpers.ArrayIndexBySquareNotation(notation);
            return Squares[coords.x, coords.y];
        }

        public void SetupGame()
        {
            SetupPawns(Color.White);
            SetupPawns(Color.Black);
            SetupPieces(Color.White);
            SetupPieces(Color.Black);
            Moves = new List<Move>();
        }

        private void SetupPawns(Color color)
        {
            int rowIndex;

            if (color == Color.White) rowIndex = 1;
            else if (color == Color.Black) rowIndex = 6;
            else throw new ArgumentOutOfRangeException();

            for (int x = 0; x < 8; x++)
            {
                Squares[x, rowIndex].Piece.PieceType = PieceType.Pawn;
                Squares[x, rowIndex].Piece.Color = color;
            }
        }

        private void SetupPieces(Color color)
        {
            PieceType[] piecePattern = new PieceType[]
            {
                PieceType.Rook,
                PieceType.Knight,
                PieceType.Bishop,
                PieceType.Queen,
                PieceType.King,
                PieceType.Bishop,
                PieceType.Knight,
                PieceType.Rook
            };

            int rowIndex;

            if (color == Color.White) rowIndex = 0;
            else if (color == Color.Black) rowIndex = 7;
            else throw new ArgumentOutOfRangeException();

            for (int i = 0; i < piecePattern.Length; i++)
            {
                Squares[i, rowIndex].Piece.PieceType = piecePattern[i];
                Squares[i, rowIndex].Piece.Color = color;
            }

        }
    }

}
