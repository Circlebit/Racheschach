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
    }
}

