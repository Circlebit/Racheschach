using Racheschach.ChessSet;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RacheschachTests.ChessSet
{
    public class BoardSquareNeighborTests
    {
        [Fact()]
        public void BoardSquareNorthNeighborsTest()
        {
            Board b = new Board();

            Assert.Equal("a2", b.GetSquareBySquareNotation("a1").NorthNeighbor.Notation);
            Assert.Equal("b2", b.GetSquareBySquareNotation("b1").NorthNeighbor.Notation);
            Assert.Equal("c2", b.GetSquareBySquareNotation("c1").NorthNeighbor.Notation);
            Assert.Equal("d2", b.GetSquareBySquareNotation("d1").NorthNeighbor.Notation);
            Assert.Equal("e2", b.GetSquareBySquareNotation("e1").NorthNeighbor.Notation);
            Assert.Equal("f2", b.GetSquareBySquareNotation("f1").NorthNeighbor.Notation);
            Assert.Equal("g2", b.GetSquareBySquareNotation("g1").NorthNeighbor.Notation);
            Assert.Equal("h2", b.GetSquareBySquareNotation("h1").NorthNeighbor.Notation);

            Assert.Equal("a3", b.GetSquareBySquareNotation("a2").NorthNeighbor.Notation);
            Assert.Equal("b3", b.GetSquareBySquareNotation("b2").NorthNeighbor.Notation);
            Assert.Equal("c3", b.GetSquareBySquareNotation("c2").NorthNeighbor.Notation);
            Assert.Equal("d3", b.GetSquareBySquareNotation("d2").NorthNeighbor.Notation);
            Assert.Equal("e3", b.GetSquareBySquareNotation("e2").NorthNeighbor.Notation);
            Assert.Equal("f3", b.GetSquareBySquareNotation("f2").NorthNeighbor.Notation);
            Assert.Equal("g3", b.GetSquareBySquareNotation("g2").NorthNeighbor.Notation);
            Assert.Equal("h3", b.GetSquareBySquareNotation("h2").NorthNeighbor.Notation);

            // NorthNeighbors in Row 8 are null
            Assert.Null(b.GetSquareBySquareNotation("a8").NorthNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("b8").NorthNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("c8").NorthNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("d8").NorthNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("e8").NorthNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("f8").NorthNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("g8").NorthNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h8").NorthNeighbor);
        }

        [Fact()]
        public void BoardSquareNorthEastNeighborsTest()
        {
            Board b = new Board();

            Assert.Equal("b2", b.GetSquareBySquareNotation("a1").NorthEastNeighbor.Notation);
            Assert.Equal("c2", b.GetSquareBySquareNotation("b1").NorthEastNeighbor.Notation);
            Assert.Equal("d2", b.GetSquareBySquareNotation("c1").NorthEastNeighbor.Notation);
            Assert.Equal("e2", b.GetSquareBySquareNotation("d1").NorthEastNeighbor.Notation);
            Assert.Equal("f2", b.GetSquareBySquareNotation("e1").NorthEastNeighbor.Notation);
            Assert.Equal("g2", b.GetSquareBySquareNotation("f1").NorthEastNeighbor.Notation);
            Assert.Equal("h2", b.GetSquareBySquareNotation("g1").NorthEastNeighbor.Notation);

            Assert.Equal("b3", b.GetSquareBySquareNotation("a2").NorthEastNeighbor.Notation);
            Assert.Equal("c3", b.GetSquareBySquareNotation("b2").NorthEastNeighbor.Notation);
            Assert.Equal("d3", b.GetSquareBySquareNotation("c2").NorthEastNeighbor.Notation);
            Assert.Equal("e3", b.GetSquareBySquareNotation("d2").NorthEastNeighbor.Notation);
            Assert.Equal("f3", b.GetSquareBySquareNotation("e2").NorthEastNeighbor.Notation);
            Assert.Equal("g3", b.GetSquareBySquareNotation("f2").NorthEastNeighbor.Notation);
            Assert.Equal("h3", b.GetSquareBySquareNotation("g2").NorthEastNeighbor.Notation);

            Assert.Null(b.GetSquareBySquareNotation("a8").NorthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("b8").NorthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("c8").NorthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("d8").NorthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("e8").NorthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("f8").NorthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("g8").NorthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h8").NorthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h7").NorthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h6").NorthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h5").NorthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h4").NorthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h3").NorthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h2").NorthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h1").NorthEastNeighbor);
        }

        [Fact()]
        public void BoardSquareEastNeighborsTest()
        {
            Board b = new Board();

            Assert.Equal("b1", b.GetSquareBySquareNotation("a1").EastNeighbor.Notation);
            Assert.Equal("b2", b.GetSquareBySquareNotation("a2").EastNeighbor.Notation);
            Assert.Equal("b3", b.GetSquareBySquareNotation("a3").EastNeighbor.Notation);
            Assert.Equal("b4", b.GetSquareBySquareNotation("a4").EastNeighbor.Notation);
            Assert.Equal("b5", b.GetSquareBySquareNotation("a5").EastNeighbor.Notation);
            Assert.Equal("b6", b.GetSquareBySquareNotation("a6").EastNeighbor.Notation);
            Assert.Equal("b7", b.GetSquareBySquareNotation("a7").EastNeighbor.Notation);
            Assert.Equal("b8", b.GetSquareBySquareNotation("a8").EastNeighbor.Notation);

            Assert.Equal("c1", b.GetSquareBySquareNotation("b1").EastNeighbor.Notation);
            Assert.Equal("c2", b.GetSquareBySquareNotation("b2").EastNeighbor.Notation);
            Assert.Equal("c3", b.GetSquareBySquareNotation("b3").EastNeighbor.Notation);
            Assert.Equal("c4", b.GetSquareBySquareNotation("b4").EastNeighbor.Notation);
            Assert.Equal("c5", b.GetSquareBySquareNotation("b5").EastNeighbor.Notation);
            Assert.Equal("c6", b.GetSquareBySquareNotation("b6").EastNeighbor.Notation);
            Assert.Equal("c7", b.GetSquareBySquareNotation("b7").EastNeighbor.Notation);
            Assert.Equal("c8", b.GetSquareBySquareNotation("b8").EastNeighbor.Notation);

            // EastNeighbors in H-Column are null
            Assert.Null(b.GetSquareBySquareNotation("h1").EastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h2").EastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h3").EastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h4").EastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h5").EastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h6").EastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h7").EastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h8").EastNeighbor);
        }

        [Fact()]
        public void BoardSquareSouthEastNeighborsTest()
        {
            Board b = new Board();

            Assert.Equal("b7", b.GetSquareBySquareNotation("a8").SouthEastNeighbor.Notation);
            Assert.Equal("c7", b.GetSquareBySquareNotation("b8").SouthEastNeighbor.Notation);
            Assert.Equal("d7", b.GetSquareBySquareNotation("c8").SouthEastNeighbor.Notation);
            Assert.Equal("e7", b.GetSquareBySquareNotation("d8").SouthEastNeighbor.Notation);
            Assert.Equal("f7", b.GetSquareBySquareNotation("e8").SouthEastNeighbor.Notation);
            Assert.Equal("g7", b.GetSquareBySquareNotation("f8").SouthEastNeighbor.Notation);
            Assert.Equal("h7", b.GetSquareBySquareNotation("g8").SouthEastNeighbor.Notation);

            Assert.Equal("b6", b.GetSquareBySquareNotation("a7").SouthEastNeighbor.Notation);
            Assert.Equal("c6", b.GetSquareBySquareNotation("b7").SouthEastNeighbor.Notation);
            Assert.Equal("d6", b.GetSquareBySquareNotation("c7").SouthEastNeighbor.Notation);
            Assert.Equal("e6", b.GetSquareBySquareNotation("d7").SouthEastNeighbor.Notation);
            Assert.Equal("f6", b.GetSquareBySquareNotation("e7").SouthEastNeighbor.Notation);
            Assert.Equal("g6", b.GetSquareBySquareNotation("f7").SouthEastNeighbor.Notation);
            Assert.Equal("h6", b.GetSquareBySquareNotation("g7").SouthEastNeighbor.Notation);

            Assert.Null(b.GetSquareBySquareNotation("a1").SouthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("b1").SouthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("c1").SouthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("d1").SouthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("e1").SouthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("f1").SouthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("g1").SouthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h1").SouthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h2").SouthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h3").SouthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h4").SouthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h5").SouthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h6").SouthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h7").SouthEastNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h8").SouthEastNeighbor);

        }

        [Fact()]
        public void BoardSquareSouthNeighborsTest()
        {
            Board b = new Board();

            Assert.Equal("a7", b.GetSquareBySquareNotation("a8").SouthNeighbor.Notation);
            Assert.Equal("b7", b.GetSquareBySquareNotation("b8").SouthNeighbor.Notation);
            Assert.Equal("c7", b.GetSquareBySquareNotation("c8").SouthNeighbor.Notation);
            Assert.Equal("d7", b.GetSquareBySquareNotation("d8").SouthNeighbor.Notation);
            Assert.Equal("e7", b.GetSquareBySquareNotation("e8").SouthNeighbor.Notation);
            Assert.Equal("f7", b.GetSquareBySquareNotation("f8").SouthNeighbor.Notation);
            Assert.Equal("g7", b.GetSquareBySquareNotation("g8").SouthNeighbor.Notation);
            Assert.Equal("h7", b.GetSquareBySquareNotation("h8").SouthNeighbor.Notation);

            Assert.Equal("a6", b.GetSquareBySquareNotation("a7").SouthNeighbor.Notation);
            Assert.Equal("b6", b.GetSquareBySquareNotation("b7").SouthNeighbor.Notation);
            Assert.Equal("c6", b.GetSquareBySquareNotation("c7").SouthNeighbor.Notation);
            Assert.Equal("d6", b.GetSquareBySquareNotation("d7").SouthNeighbor.Notation);
            Assert.Equal("e6", b.GetSquareBySquareNotation("e7").SouthNeighbor.Notation);
            Assert.Equal("f6", b.GetSquareBySquareNotation("f7").SouthNeighbor.Notation);
            Assert.Equal("g6", b.GetSquareBySquareNotation("g7").SouthNeighbor.Notation);
            Assert.Equal("h6", b.GetSquareBySquareNotation("h7").SouthNeighbor.Notation);

            // SouthNeighbors in Row 1 are null
            Assert.Null(b.GetSquareBySquareNotation("a1").SouthNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("b1").SouthNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("c1").SouthNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("d1").SouthNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("e1").SouthNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("f1").SouthNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("g1").SouthNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h1").SouthNeighbor);
        }

        [Fact()]
        public void BoardSquareSouthWestNeighborsTest()
        {
            Board b = new Board();

            Assert.Equal("a7", b.GetSquareBySquareNotation("b8").SouthWestNeighbor.Notation);
            Assert.Equal("b7", b.GetSquareBySquareNotation("c8").SouthWestNeighbor.Notation);
            Assert.Equal("c7", b.GetSquareBySquareNotation("d8").SouthWestNeighbor.Notation);
            Assert.Equal("d7", b.GetSquareBySquareNotation("e8").SouthWestNeighbor.Notation);
            Assert.Equal("e7", b.GetSquareBySquareNotation("f8").SouthWestNeighbor.Notation);
            Assert.Equal("f7", b.GetSquareBySquareNotation("g8").SouthWestNeighbor.Notation);
            Assert.Equal("g7", b.GetSquareBySquareNotation("h8").SouthWestNeighbor.Notation);

            Assert.Equal("a6", b.GetSquareBySquareNotation("b7").SouthWestNeighbor.Notation);
            Assert.Equal("b6", b.GetSquareBySquareNotation("c7").SouthWestNeighbor.Notation);
            Assert.Equal("c6", b.GetSquareBySquareNotation("d7").SouthWestNeighbor.Notation);
            Assert.Equal("d6", b.GetSquareBySquareNotation("e7").SouthWestNeighbor.Notation);
            Assert.Equal("e6", b.GetSquareBySquareNotation("f7").SouthWestNeighbor.Notation);
            Assert.Equal("f6", b.GetSquareBySquareNotation("g7").SouthWestNeighbor.Notation);
            Assert.Equal("g6", b.GetSquareBySquareNotation("h7").SouthWestNeighbor.Notation);

            Assert.Null(b.GetSquareBySquareNotation("a1").SouthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("b1").SouthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("c1").SouthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("d1").SouthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("e1").SouthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("f1").SouthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("g1").SouthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h1").SouthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a2").SouthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a3").SouthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a4").SouthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a5").SouthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a6").SouthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a7").SouthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a8").SouthWestNeighbor);
        }

        [Fact()]
        public void BoardSquareWestNeighborsTest()
        {
            Board b = new Board();

            Assert.Equal("g1", b.GetSquareBySquareNotation("h1").WestNeighbor.Notation);
            Assert.Equal("g2", b.GetSquareBySquareNotation("h2").WestNeighbor.Notation);
            Assert.Equal("g3", b.GetSquareBySquareNotation("h3").WestNeighbor.Notation);
            Assert.Equal("g4", b.GetSquareBySquareNotation("h4").WestNeighbor.Notation);
            Assert.Equal("g5", b.GetSquareBySquareNotation("h5").WestNeighbor.Notation);
            Assert.Equal("g6", b.GetSquareBySquareNotation("h6").WestNeighbor.Notation);
            Assert.Equal("g7", b.GetSquareBySquareNotation("h7").WestNeighbor.Notation);
            Assert.Equal("g8", b.GetSquareBySquareNotation("h8").WestNeighbor.Notation);

            Assert.Equal("f1", b.GetSquareBySquareNotation("g1").WestNeighbor.Notation);
            Assert.Equal("f2", b.GetSquareBySquareNotation("g2").WestNeighbor.Notation);
            Assert.Equal("f3", b.GetSquareBySquareNotation("g3").WestNeighbor.Notation);
            Assert.Equal("f4", b.GetSquareBySquareNotation("g4").WestNeighbor.Notation);
            Assert.Equal("f5", b.GetSquareBySquareNotation("g5").WestNeighbor.Notation);
            Assert.Equal("f6", b.GetSquareBySquareNotation("g6").WestNeighbor.Notation);
            Assert.Equal("f7", b.GetSquareBySquareNotation("g7").WestNeighbor.Notation);
            Assert.Equal("f8", b.GetSquareBySquareNotation("g8").WestNeighbor.Notation);

            // WestNeighbors in Row 8 are null
            Assert.Null(b.GetSquareBySquareNotation("a1").WestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a2").WestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a3").WestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a4").WestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a5").WestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a6").WestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a7").WestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a8").WestNeighbor);
        }

        [Fact()]
        public void BoardSquareNorthWestNeighborsTest()
        {
            Board b = new Board();

            Assert.Equal("a2", b.GetSquareBySquareNotation("b1").NorthWestNeighbor.Notation);
            Assert.Equal("b2", b.GetSquareBySquareNotation("c1").NorthWestNeighbor.Notation);
            Assert.Equal("c2", b.GetSquareBySquareNotation("d1").NorthWestNeighbor.Notation);
            Assert.Equal("d2", b.GetSquareBySquareNotation("e1").NorthWestNeighbor.Notation);
            Assert.Equal("e2", b.GetSquareBySquareNotation("f1").NorthWestNeighbor.Notation);
            Assert.Equal("f2", b.GetSquareBySquareNotation("g1").NorthWestNeighbor.Notation);
            Assert.Equal("g2", b.GetSquareBySquareNotation("h1").NorthWestNeighbor.Notation);

            Assert.Equal("a3", b.GetSquareBySquareNotation("b2").NorthWestNeighbor.Notation);
            Assert.Equal("b3", b.GetSquareBySquareNotation("c2").NorthWestNeighbor.Notation);
            Assert.Equal("c3", b.GetSquareBySquareNotation("d2").NorthWestNeighbor.Notation);
            Assert.Equal("d3", b.GetSquareBySquareNotation("e2").NorthWestNeighbor.Notation);
            Assert.Equal("e3", b.GetSquareBySquareNotation("f2").NorthWestNeighbor.Notation);
            Assert.Equal("f3", b.GetSquareBySquareNotation("g2").NorthWestNeighbor.Notation);
            Assert.Equal("g3", b.GetSquareBySquareNotation("h2").NorthWestNeighbor.Notation);

            Assert.Null(b.GetSquareBySquareNotation("a8").NorthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("b8").NorthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("c8").NorthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("d8").NorthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("e8").NorthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("f8").NorthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("g8").NorthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("h8").NorthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a1").NorthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a2").NorthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a3").NorthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a4").NorthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a5").NorthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a6").NorthWestNeighbor);
            Assert.Null(b.GetSquareBySquareNotation("a7").NorthWestNeighbor);
        }
    }
}
