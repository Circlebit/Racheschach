using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
