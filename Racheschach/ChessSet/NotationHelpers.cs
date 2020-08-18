using System;
using System.Linq;

namespace Racheschach.ChessSet
{
    public static class NotationHelpers
    {
        public static string SquareNotationByArrayIndex(int x, int y)
        {
            if (x >= 0 && y >= 0 && x < 8 && y < 8)
                return $"{Convert.ToChar(97 + x)}{y + 1}";
            else
                throw new ArgumentOutOfRangeException();
        }

        public static (int x, int y) ArrayIndexBySquareNotation(string notation)
        {
            notation = notation.ToLower().Trim();

            if (notation.Length != 2 || !notation.All(Char.IsLetterOrDigit))
                throw new Exception();

            var foox = notation[0];
            var foo = notation[0]-97;

            var barx = notation[1];
            var bar = Convert.ToInt32(Char.GetNumericValue(notation[1])) - 1;

            bool b = foo >= 'a';

            if (notation[0] >= 'a'
             && notation[0] <= 'h'
             && notation[1] >= '0'
             && notation[1] <= '8')
            {
                return ((Convert.ToInt32(notation[0])-97), Convert.ToInt32(Char.GetNumericValue(notation[1]))-1);
            }
            else throw new Exception();
        }

        public static Char GetUniCodeForPiece(Color color, PieceType pieceType)
        {
            switch (color)
            {
                case Color.White:
                    switch (pieceType)
                    {
                        case PieceType.None: return ' ';
                        case PieceType.King: return '♔';
                        case PieceType.Queen: return '♕';
                        case PieceType.Rook: return '♖';
                        case PieceType.Bishop: return '♗';
                        case PieceType.Knight: return '♘';
                        case PieceType.Pawn: return '♙';
                        default: throw new Exception();
                    }
                case Color.Black:
                    switch (pieceType)
                    {
                        case PieceType.None: return ' ';
                        case PieceType.King: return '♚';
                        case PieceType.Queen: return '♛';
                        case PieceType.Rook: return '♜';
                        case PieceType.Bishop: return '♝';
                        case PieceType.Knight: return '♞';
                        case PieceType.Pawn: return '♟';
                        default: throw new Exception();
                    }
                case Color.None: return ' ';
                default: throw new Exception();
            }
        }

    }
}
