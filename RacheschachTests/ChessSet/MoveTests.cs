using Xunit;
using Racheschach.ChessSet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet.Tests
{
    public class MoveTests
    {
        [Fact()]
        public void EqualsTest()
        {
            var b1 = new Board();
            b1.SetupGame();

            var b2 = new Board();
            b2.SetupGame();

            var b1_e2e4 = b1.GetNewMove("e2", "e4");
            var b1_d2d4 = b1.GetNewMove("d2", "d4");

            var b2_e2e4 = b2.GetNewMove("e2", "e4");
            var b2_d2d4 = b2.GetNewMove("d2", "d4");

            Assert.Equal(b1_e2e4, b1_e2e4);

            Assert.Equal(b1_e2e4, b2_e2e4);
            Assert.Equal(b1_d2d4, b2_d2d4);

            Assert.NotEqual(b1_e2e4, b1_d2d4);
            Assert.NotEqual(b1_e2e4, b2_d2d4);
            Assert.NotEqual(b2_e2e4, b1_d2d4);
            Assert.NotEqual(b2_e2e4, b2_d2d4);

            b1.PlayMove(b1_e2e4);
            Assert.NotEqual(b1, b2);

            b2.PlayMove(b2_e2e4);
            Assert.Equal(b1, b2);
        }
    }
}