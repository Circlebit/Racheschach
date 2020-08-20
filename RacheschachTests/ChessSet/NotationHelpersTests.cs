using Xunit;
using Racheschach.ChessSet;
using System;
using System.Collections.Generic;
using System.Text;
using Racheschach.Notation;

namespace Racheschach.ChessSet.Tests
{
    public class NotationHelpersTests
    {


        [Fact()]
        public void GetUniCodeForPieceTest()
        {
            Assert.Equal('♔', NotationHelpers.GetUniCodeForPiece(Color.White, PieceType.King));
            Assert.Equal('♕', NotationHelpers.GetUniCodeForPiece(Color.White, PieceType.Queen));
            Assert.Equal('♖', NotationHelpers.GetUniCodeForPiece(Color.White, PieceType.Rook));
            Assert.Equal('♗', NotationHelpers.GetUniCodeForPiece(Color.White, PieceType.Bishop));
            Assert.Equal('♘', NotationHelpers.GetUniCodeForPiece(Color.White, PieceType.Knight));
            Assert.Equal('♙', NotationHelpers.GetUniCodeForPiece(Color.White, PieceType.Pawn));

            Assert.Equal('♚', NotationHelpers.GetUniCodeForPiece(Color.Black, PieceType.King));
            Assert.Equal('♛', NotationHelpers.GetUniCodeForPiece(Color.Black, PieceType.Queen));
            Assert.Equal('♜', NotationHelpers.GetUniCodeForPiece(Color.Black, PieceType.Rook));
            Assert.Equal('♝', NotationHelpers.GetUniCodeForPiece(Color.Black, PieceType.Bishop));
            Assert.Equal('♞', NotationHelpers.GetUniCodeForPiece(Color.Black, PieceType.Knight));
            Assert.Equal('♟', NotationHelpers.GetUniCodeForPiece(Color.Black, PieceType.Pawn));

            Assert.Equal(' ', NotationHelpers.GetUniCodeForPiece(Color.White, PieceType.None));
            Assert.Equal(' ', NotationHelpers.GetUniCodeForPiece(Color.Black, PieceType.None));
        }
    }
}