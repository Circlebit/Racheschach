using Xunit;
using Racheschach.ChessSet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet.Tests
{
    public class PieceRookTests
    {
        [Fact()]
        public void GetPossibleRookMovesTest()
        {
            var b = new Board();
            b.SetupGame();

            Assert.Equal(new List<Move>(), b.GetSquareBySquareNotation("a1").Piece.GetPossibleMoves());

            b.PlayMove(b.GetNewMove("a2", "a3"));

            //TODO: make moves comparable (from/to, boardstate);

            //Assert.Equal(new List<Move>() { b.GetSquareBySquareNotation("a2") },
            //    b.GetSquareBySquareNotation("a1").Piece.GetPossibleMoves());

        }
    }
}