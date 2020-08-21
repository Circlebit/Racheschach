using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet
{
    public enum PieceType
    {
        None,
        King,
        Queen,
        Rook,
        Bishop,
        Knight,
        Pawn
    }

    public enum Color
    {
        White,
        Black
    }

    public static class ColorExtensions
    {
        public static Color Opposite(this Color c) => GameHelpers.GetOppositeColor(c);
        public static char BaseRow(this Color c) => GameHelpers.GetBaseRowNameByColor(c);
        public static char PawnRow(this Color c) => GameHelpers.GetPawnRowNameByColor(c);
    }


}
