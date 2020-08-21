using Racheschach.ChessSet;
using System;
using System.Text;

namespace Racheschach.Notation
{
    public class FEN
    {
        public string String { get; }
        public Board Board { get; }

        public FEN(Board board)
        {
            Board = board;
            var sb = new StringBuilder();

            //FEN is Top to Bottom so we start at row 8
            for (int y = 7; y >= 0; y--)
            {
                sb.Append(ParseRowSquares(Board.Rows[y]));
                if (y != 0) sb.Append('/');
            }

            sb.Append($" {(Board.ActiveColor == Color.White ? 'w' : 'b')} ");

            sb.Append(Board.WhiteCanCastleKingside ? "K" : "");
            sb.Append(Board.WhiteCanCastleQueenside ? "Q" : "");
            sb.Append(Board.BlackCanCastleKingside ? "k" : "");
            sb.Append(Board.BlackCanCastleQueenside ? "q " : "");
            sb.Append(!Board.WhiteCanCastleKingside && !Board.WhiteCanCastleQueenside
                       && !Board.BlackCanCastleKingside && !Board.BlackCanCastleQueenside
                        ? "- " : "");

            sb.Append(Board.EnPassant == null ? "-" : Board.EnPassant.Notation);
            sb.Append($" {Board.Halfmoves}");
            sb.Append($" {Board.Fullmoves}");

            String = sb.ToString();
        }

        public FEN(string s)
        {
            String = s;
            Board = new Board();

            string[] subStrings = String.Split(' ');
            string[] rowStrings = subStrings[0].Split('/');
            Array.Reverse(rowStrings); // reverse FEN rows so indexes are like board rows (bottom to top)

            for (int y = 0; y < 8; y++)
            {
                ColorPiece[] cPieceRowFromFen = NotationHelpers.GetColorPiecesByFENRow(rowStrings[y]);
                Square[] squareRowFromBoard = Board.Rows[y];

                for (int x = 0; x < 8; x++)
                {
                    squareRowFromBoard[x].SetPiece(cPieceRowFromFen[x]);
                }
            }
        }

        public string ParseRowSquares(Square[] squares)
        {
            var result = new StringBuilder();
            int emptySquares = 0;
            foreach (Square square in squares)
            {
                if (square.IsFree) emptySquares++;
                else
                {
                    if (emptySquares > 0)
                    {
                        result.Append(emptySquares.ToString());
                        emptySquares = 0;
                    }
                    result.Append(square.Piece.FEN);
                }
            }
            if (emptySquares > 0) result.Append(emptySquares.ToString());

            return result.ToString();
        }
    }
}
