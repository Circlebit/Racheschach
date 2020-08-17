using Xunit;
using Racheschach.ChessSet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet.Tests
{
    public class BoardTests
    {
        [Fact()]
        public void BoardSquareNotationsTest()
        {
            Board b = new Board();

            Assert.Equal("a1", b.Squares[0, 0].Notation);
            Assert.Equal("b1", b.Squares[1, 0].Notation);
            Assert.Equal("c1", b.Squares[2, 0].Notation);
            Assert.Equal("d1", b.Squares[3, 0].Notation);
            Assert.Equal("e1", b.Squares[4, 0].Notation);
            Assert.Equal("f1", b.Squares[5, 0].Notation);
            Assert.Equal("g1", b.Squares[6, 0].Notation);
            Assert.Equal("h1", b.Squares[7, 0].Notation);

            Assert.Equal("a2", b.Squares[0, 1].Notation);
            Assert.Equal("b2", b.Squares[1, 1].Notation);
            Assert.Equal("c2", b.Squares[2, 1].Notation);
            Assert.Equal("d2", b.Squares[3, 1].Notation);
            Assert.Equal("e2", b.Squares[4, 1].Notation);
            Assert.Equal("f2", b.Squares[5, 1].Notation);
            Assert.Equal("g2", b.Squares[6, 1].Notation);
            Assert.Equal("h2", b.Squares[7, 1].Notation);

            Assert.Equal("a8", b.Squares[0, 7].Notation);
            Assert.Equal("b8", b.Squares[1, 7].Notation);
            Assert.Equal("c8", b.Squares[2, 7].Notation);
            Assert.Equal("d8", b.Squares[3, 7].Notation);
            Assert.Equal("e8", b.Squares[4, 7].Notation);
            Assert.Equal("f8", b.Squares[5, 7].Notation);
            Assert.Equal("g8", b.Squares[6, 7].Notation);
            Assert.Equal("h8", b.Squares[7, 7].Notation);

        }


        [Fact()]
        public void BoardSquaresNotNullTest()
        {
            Board b = new Board();

            Assert.Equal(8, b.Squares.GetLength(0));
            Assert.Equal(8, b.Squares.GetLength(1));

            for (int x = 0; x < b.Squares.GetLength(0); x++)
            {
                for (int y = 0; y < b.Squares.GetLength(1); y++)
                {
                    Assert.NotNull(b.Squares[x, y]);
                }
            }
        }

    }
}