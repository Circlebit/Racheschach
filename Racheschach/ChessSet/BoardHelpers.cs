using Racheschach.Notation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Racheschach.ChessSet
{
    public static class BoardHelpers
    {
        //TODO: make this somehow
        public static string BoardToUnicode(Board board)
        {
            var output = new StringBuilder();

            for (int y = 7; y >= 0; y--)
            {
                output.Append("│");
                for (int x = 0; x < 8; x++)
                {
                    output.Append($" {board.Squares[x,y].Piece.UniCode} │");
                }
                output.Append("\n├────────────────────────────────\n");            
            }

            return output.ToString();
        }

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

        public static int RowNameToIndex(char rowName)
        {
            if (NotationHelpers.IsValidRowName(rowName)) 
                return Convert.ToInt32(char.GetNumericValue(rowName)) - 1;
            else throw new ArgumentOutOfRangeException();
        }

        public static int ColumnNameToIndex(char columnName)
        {
            if (NotationHelpers.IsValidColumnName(columnName)) 
                return Convert.ToInt32(columnName) - 97;
            else throw new ArgumentOutOfRangeException();
        }

        public static char RowIndexToRowName(int rowIndex)
        {
            if (rowIndex > 0 && rowIndex < 8)
                return (char)(rowIndex + 49);
            else throw new ArgumentOutOfRangeException();
        }

        public static char ColumnIndexToColumnName(int columnIndex)
        {
            if (columnIndex > 0 && columnIndex < 8)
                return (char)(columnIndex + 97);
            else throw new ArgumentOutOfRangeException();
        }

        public static string BoardToFEN(Board board)
        {
            var foo = new FEN(board);
            throw new NotImplementedException();
            //return "";
        }
    }
}
