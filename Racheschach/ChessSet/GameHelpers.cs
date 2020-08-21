using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet
{
    public static class GameHelpers
    {
        public static Color GetOppositeColor(Color color)
        {
            switch (color)
            {
                case Color.White: return Color.Black;
                case Color.Black: return Color.White;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static char GetBaseRowNameByColor(Color color)
        {
            switch (color)
            {
                case Color.White: return '1';
                case Color.Black: return '8';
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static char GetPawnRowNameByColor(Color color)
        {
            switch (color)
            {
                case Color.White: return '2';
                case Color.Black: return '7';
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}

