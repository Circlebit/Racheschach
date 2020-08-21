using Racheschach.ChessSet;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Racheschach.Notation
{
    public static class NotationHelpers
    {
        public static bool IsValidColumnName(char columnName)
        {
            return (columnName >= 'a' && columnName <= 'h');
        }

        public static bool IsValidRowName(char rowName)
        {
            return (rowName >= '1' && rowName <= '8');
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
                default: throw new Exception();
            }
        }

        public static Char GetFENForPiece(Color color, PieceType pieceType)
        {
            switch (color)
            {
                case Color.White:
                    switch (pieceType)
                    {
                        case PieceType.None: return '\0';
                        case PieceType.King: return 'K';
                        case PieceType.Queen: return 'Q';
                        case PieceType.Rook: return 'R';
                        case PieceType.Bishop: return 'B';
                        case PieceType.Knight: return 'N';
                        case PieceType.Pawn: return 'P';
                        default: throw new Exception();
                    }
                case Color.Black:
                    switch (pieceType)
                    {
                        case PieceType.None: return '\0';
                        case PieceType.King: return 'k';
                        case PieceType.Queen: return 'q';
                        case PieceType.Rook: return 'r';
                        case PieceType.Bishop: return 'b';
                        case PieceType.Knight: return 'n';
                        case PieceType.Pawn: return 'p';
                        default: throw new Exception();
                    }
                default: throw new Exception();
            }
        }

        public static ColorPiece GetColorPieceByFENChar(char c)
        {
            if (!IsValidFENChar(c)) throw new ArgumentOutOfRangeException();
            if (Char.IsDigit(c)) return new ColorPiece(); // empty square(s)
            if (Char.IsUpper(c)) // White
            {
                switch (c)
                {
                    case 'K': return new ColorPiece(PieceType.King, Color.White);
                    case 'Q': return new ColorPiece(PieceType.Queen, Color.White);
                    case 'R': return new ColorPiece(PieceType.Rook, Color.White);
                    case 'B': return new ColorPiece(PieceType.Bishop, Color.White);
                    case 'N': return new ColorPiece(PieceType.Knight, Color.White);
                    case 'P': return new ColorPiece(PieceType.Pawn, Color.White);
                }
            }
            if(Char.IsLower(c)) // Black
            {
                switch (c)
                {
                    case 'k': return new ColorPiece(PieceType.King, Color.Black);
                    case 'q': return new ColorPiece(PieceType.Queen, Color.Black);
                    case 'r': return new ColorPiece(PieceType.Rook, Color.Black);
                    case 'b': return new ColorPiece(PieceType.Bishop, Color.Black);
                    case 'n': return new ColorPiece(PieceType.Knight, Color.Black);
                    case 'p': return new ColorPiece(PieceType.Pawn, Color.Black);
                }
            }
            throw new Exception();
        }

        public static ColorPiece[] GetColorPiecesByFENRow(string fenRow)
        {
            List<ColorPiece> pieces = new List<ColorPiece>();

            foreach (char c in fenRow)
            {
                ColorPiece cp = GetColorPieceByFENChar(c);
                if (GetColorPieceByFENChar(c).PieceType == PieceType.None)
                {
                    int numberOfEmptySquares = Convert.ToInt32(Char.GetNumericValue(c));
                    pieces.AddRange(Enumerable.Repeat(new ColorPiece(), numberOfEmptySquares));
                }
                else pieces.Add(cp);
            }

            return pieces.ToArray();
        }


        private static bool IsValidFENChar(char c)
        {
            return "kqrbnpKQRBNP12345678".Contains(c);
        }
    }

}
