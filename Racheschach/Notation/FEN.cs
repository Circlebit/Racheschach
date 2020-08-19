using Racheschach.ChessSet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.Notation
{
    public class FEN
    {
        public string String { get; set; }

        public FEN(Board board)
        {
            var result = new StringBuilder();

            //FEN is Top to Bottom so we start at row 8
            for (int y = 7; y >= 0; y--)
            {
                result.Append(ParseRowSquares(board.Rows[y]));
                if (y != 0) result.Append('/');
            }

            result.Append($" {(board.ActiveColor == Color.White ? 'w' : 'b')} ");

            result.Append(board.WhiteCanCastleKingside ? "K" : "");
            result.Append(board.WhiteCanCastleQueenside ? "Q" : "");
            result.Append(board.BlackCanCastleKingside ? "k" : "");
            result.Append(board.BlackCanCastleQueenside ? "q " : "");
            result.Append(!board.WhiteCanCastleKingside && !board.WhiteCanCastleQueenside
                       && !board.BlackCanCastleKingside && !board.BlackCanCastleQueenside
                        ? "- " : "");

            result.Append(board.EnPassant == null ? "-" : board.EnPassant.Notation);

            result.Append($" {board.Halfmoves}");

            result.Append($" {board.Fullmoves}");

            String = result.ToString();
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
