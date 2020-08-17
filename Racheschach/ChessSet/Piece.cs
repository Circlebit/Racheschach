using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet
{
    public class Piece
    {
        public Color Color { get; set; }
        public PieceType PieceType { get; set; }
        public Char UniCode => NotationHelpers.GetUniCodeForPiece(Color, PieceType);

        public Piece(Color color, PieceType pieceType)
        {
            Color = color;
            PieceType = pieceType;
        }


    }
}
