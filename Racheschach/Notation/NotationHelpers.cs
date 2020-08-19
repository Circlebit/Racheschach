using Racheschach.ChessSet;
using System;
using System.Linq;

namespace Racheschach.Notation
{
    public static class NotationHelpers
    {
        //TODO: Relocate Methods htat are only relvent with Board-Class to Board-Class or somewhere extra
        //TODO: Relocate universal Notation halpers to notation namespace


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
                case Color.None: return ' ';
                default: throw new Exception();
            }
        }

    }
}
