using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet
{
    public static class BoardHelpers
    {
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
    }
}
