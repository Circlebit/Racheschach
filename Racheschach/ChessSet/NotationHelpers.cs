using System;
using System.Linq;

namespace Racheschach.ChessSet
{
    public static class NotationHelpers
    {
        //TODO: Relocate Methods htat are only relvent with Board-Class to Board-Class or somewhere extra
        //TODO: Relocate universal Notation halpers to notation namespace
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
                throw new ArgumentOutOfRangeException();

            return (ColumnNameToIndex(notation[0]), RowNameToIndex(notation[1]));
        }

        public static bool IsValidColumnName(char columnName)
        {
            return (columnName >= 'a' && columnName <= 'h');
        }

        public static bool IsValidRowName(char rowName)
        {
            return (rowName >= '1' && rowName <= '8');
        }

        public static int RowNameToIndex(char rowName)
        {
            if (IsValidRowName(rowName)) return Convert.ToInt32(char.GetNumericValue(rowName)) - 1;
            else throw new ArgumentOutOfRangeException();
        }

        public static int ColumnNameToIndex(char columnName)
        {
            if (IsValidColumnName(columnName)) return Convert.ToInt32(columnName) - 97;
            else throw new ArgumentOutOfRangeException();
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
