using Racheschach.ChessSet;
using System;
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

    }
}
