using Xunit;

namespace Racheschach.ChessSet.Tests
{
    public class InitialMoveTests
    {

        [Fact()]
        public void EqualsTest()
        {
            var b1 = new Board();
            b1.SetupGame();

            var b2 = new Board();
            b2.SetupGame();

            var init1 = new InitialMove(b1);
            var init2 = new InitialMove(b2);

            Assert.True(init1.Equals(new InitialMove(b1)));
            Assert.True(init1.Equals(new InitialMove(b2)));
            Assert.True(init1.Equals(init2));
            Assert.True(init2.Equals(init1));

            var b1_e2e4 = b1.GetNewMove("e2", "e4");
            b1.PlayMove(b1_e2e4);

            var b2_d2d3 = b2.GetNewMove("d2", "d3");
            b2.PlayMove(b2_d2d3);

            Assert.False(b1_e2e4.Equals(init1));
            Assert.False(b1_e2e4.Equals(init2));
            Assert.False(b2_d2d3.Equals(init1));
            Assert.False(b2_d2d3.Equals(init2));
        }

    }
}