using Racheschach.ChessSet;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Racheschach.ChessSet.Tests
{
    public class BoardSquareNeighborTests
    {
        [Fact()]
        public void BoardSquareNorthNeighborsTest()
        {
            Board b = new Board();

            Assert.Equal("a2", b.GetSquareBySquareNotation("a1").North.Notation);
            Assert.Equal("b2", b.GetSquareBySquareNotation("b1").North.Notation);
            Assert.Equal("c2", b.GetSquareBySquareNotation("c1").North.Notation);
            Assert.Equal("d2", b.GetSquareBySquareNotation("d1").North.Notation);
            Assert.Equal("e2", b.GetSquareBySquareNotation("e1").North.Notation);
            Assert.Equal("f2", b.GetSquareBySquareNotation("f1").North.Notation);
            Assert.Equal("g2", b.GetSquareBySquareNotation("g1").North.Notation);
            Assert.Equal("h2", b.GetSquareBySquareNotation("h1").North.Notation);

            Assert.Equal("a3", b.GetSquareBySquareNotation("a2").North.Notation);
            Assert.Equal("b3", b.GetSquareBySquareNotation("b2").North.Notation);
            Assert.Equal("c3", b.GetSquareBySquareNotation("c2").North.Notation);
            Assert.Equal("d3", b.GetSquareBySquareNotation("d2").North.Notation);
            Assert.Equal("e3", b.GetSquareBySquareNotation("e2").North.Notation);
            Assert.Equal("f3", b.GetSquareBySquareNotation("f2").North.Notation);
            Assert.Equal("g3", b.GetSquareBySquareNotation("g2").North.Notation);
            Assert.Equal("h3", b.GetSquareBySquareNotation("h2").North.Notation);

            // NorthNeighbors in Row 8 are null
            Assert.Null(b.GetSquareBySquareNotation("a8").North);
            Assert.Null(b.GetSquareBySquareNotation("b8").North);
            Assert.Null(b.GetSquareBySquareNotation("c8").North);
            Assert.Null(b.GetSquareBySquareNotation("d8").North);
            Assert.Null(b.GetSquareBySquareNotation("e8").North);
            Assert.Null(b.GetSquareBySquareNotation("f8").North);
            Assert.Null(b.GetSquareBySquareNotation("g8").North);
            Assert.Null(b.GetSquareBySquareNotation("h8").North);
        }

        [Fact()]
        public void BoardSquareNorthEastNeighborsTest()
        {
            Board b = new Board();

            Assert.Equal("b2", b.GetSquareBySquareNotation("a1").NorthEast.Notation);
            Assert.Equal("c2", b.GetSquareBySquareNotation("b1").NorthEast.Notation);
            Assert.Equal("d2", b.GetSquareBySquareNotation("c1").NorthEast.Notation);
            Assert.Equal("e2", b.GetSquareBySquareNotation("d1").NorthEast.Notation);
            Assert.Equal("f2", b.GetSquareBySquareNotation("e1").NorthEast.Notation);
            Assert.Equal("g2", b.GetSquareBySquareNotation("f1").NorthEast.Notation);
            Assert.Equal("h2", b.GetSquareBySquareNotation("g1").NorthEast.Notation);

            Assert.Equal("b3", b.GetSquareBySquareNotation("a2").NorthEast.Notation);
            Assert.Equal("c3", b.GetSquareBySquareNotation("b2").NorthEast.Notation);
            Assert.Equal("d3", b.GetSquareBySquareNotation("c2").NorthEast.Notation);
            Assert.Equal("e3", b.GetSquareBySquareNotation("d2").NorthEast.Notation);
            Assert.Equal("f3", b.GetSquareBySquareNotation("e2").NorthEast.Notation);
            Assert.Equal("g3", b.GetSquareBySquareNotation("f2").NorthEast.Notation);
            Assert.Equal("h3", b.GetSquareBySquareNotation("g2").NorthEast.Notation);

            Assert.Null(b.GetSquareBySquareNotation("a8").NorthEast);
            Assert.Null(b.GetSquareBySquareNotation("b8").NorthEast);
            Assert.Null(b.GetSquareBySquareNotation("c8").NorthEast);
            Assert.Null(b.GetSquareBySquareNotation("d8").NorthEast);
            Assert.Null(b.GetSquareBySquareNotation("e8").NorthEast);
            Assert.Null(b.GetSquareBySquareNotation("f8").NorthEast);
            Assert.Null(b.GetSquareBySquareNotation("g8").NorthEast);
            Assert.Null(b.GetSquareBySquareNotation("h8").NorthEast);
            Assert.Null(b.GetSquareBySquareNotation("h7").NorthEast);
            Assert.Null(b.GetSquareBySquareNotation("h6").NorthEast);
            Assert.Null(b.GetSquareBySquareNotation("h5").NorthEast);
            Assert.Null(b.GetSquareBySquareNotation("h4").NorthEast);
            Assert.Null(b.GetSquareBySquareNotation("h3").NorthEast);
            Assert.Null(b.GetSquareBySquareNotation("h2").NorthEast);
            Assert.Null(b.GetSquareBySquareNotation("h1").NorthEast);
        }

        [Fact()]
        public void BoardSquareEastNeighborsTest()
        {
            Board b = new Board();

            Assert.Equal("b1", b.GetSquareBySquareNotation("a1").East.Notation);
            Assert.Equal("b2", b.GetSquareBySquareNotation("a2").East.Notation);
            Assert.Equal("b3", b.GetSquareBySquareNotation("a3").East.Notation);
            Assert.Equal("b4", b.GetSquareBySquareNotation("a4").East.Notation);
            Assert.Equal("b5", b.GetSquareBySquareNotation("a5").East.Notation);
            Assert.Equal("b6", b.GetSquareBySquareNotation("a6").East.Notation);
            Assert.Equal("b7", b.GetSquareBySquareNotation("a7").East.Notation);
            Assert.Equal("b8", b.GetSquareBySquareNotation("a8").East.Notation);

            Assert.Equal("c1", b.GetSquareBySquareNotation("b1").East.Notation);
            Assert.Equal("c2", b.GetSquareBySquareNotation("b2").East.Notation);
            Assert.Equal("c3", b.GetSquareBySquareNotation("b3").East.Notation);
            Assert.Equal("c4", b.GetSquareBySquareNotation("b4").East.Notation);
            Assert.Equal("c5", b.GetSquareBySquareNotation("b5").East.Notation);
            Assert.Equal("c6", b.GetSquareBySquareNotation("b6").East.Notation);
            Assert.Equal("c7", b.GetSquareBySquareNotation("b7").East.Notation);
            Assert.Equal("c8", b.GetSquareBySquareNotation("b8").East.Notation);

            // EastNeighbors in H-Column are null
            Assert.Null(b.GetSquareBySquareNotation("h1").East);
            Assert.Null(b.GetSquareBySquareNotation("h2").East);
            Assert.Null(b.GetSquareBySquareNotation("h3").East);
            Assert.Null(b.GetSquareBySquareNotation("h4").East);
            Assert.Null(b.GetSquareBySquareNotation("h5").East);
            Assert.Null(b.GetSquareBySquareNotation("h6").East);
            Assert.Null(b.GetSquareBySquareNotation("h7").East);
            Assert.Null(b.GetSquareBySquareNotation("h8").East);
        }

        [Fact()]
        public void BoardSquareSouthEastNeighborsTest()
        {
            Board b = new Board();

            Assert.Equal("b7", b.GetSquareBySquareNotation("a8").SouthEast.Notation);
            Assert.Equal("c7", b.GetSquareBySquareNotation("b8").SouthEast.Notation);
            Assert.Equal("d7", b.GetSquareBySquareNotation("c8").SouthEast.Notation);
            Assert.Equal("e7", b.GetSquareBySquareNotation("d8").SouthEast.Notation);
            Assert.Equal("f7", b.GetSquareBySquareNotation("e8").SouthEast.Notation);
            Assert.Equal("g7", b.GetSquareBySquareNotation("f8").SouthEast.Notation);
            Assert.Equal("h7", b.GetSquareBySquareNotation("g8").SouthEast.Notation);

            Assert.Equal("b6", b.GetSquareBySquareNotation("a7").SouthEast.Notation);
            Assert.Equal("c6", b.GetSquareBySquareNotation("b7").SouthEast.Notation);
            Assert.Equal("d6", b.GetSquareBySquareNotation("c7").SouthEast.Notation);
            Assert.Equal("e6", b.GetSquareBySquareNotation("d7").SouthEast.Notation);
            Assert.Equal("f6", b.GetSquareBySquareNotation("e7").SouthEast.Notation);
            Assert.Equal("g6", b.GetSquareBySquareNotation("f7").SouthEast.Notation);
            Assert.Equal("h6", b.GetSquareBySquareNotation("g7").SouthEast.Notation);

            Assert.Null(b.GetSquareBySquareNotation("a1").SouthEast);
            Assert.Null(b.GetSquareBySquareNotation("b1").SouthEast);
            Assert.Null(b.GetSquareBySquareNotation("c1").SouthEast);
            Assert.Null(b.GetSquareBySquareNotation("d1").SouthEast);
            Assert.Null(b.GetSquareBySquareNotation("e1").SouthEast);
            Assert.Null(b.GetSquareBySquareNotation("f1").SouthEast);
            Assert.Null(b.GetSquareBySquareNotation("g1").SouthEast);
            Assert.Null(b.GetSquareBySquareNotation("h1").SouthEast);
            Assert.Null(b.GetSquareBySquareNotation("h2").SouthEast);
            Assert.Null(b.GetSquareBySquareNotation("h3").SouthEast);
            Assert.Null(b.GetSquareBySquareNotation("h4").SouthEast);
            Assert.Null(b.GetSquareBySquareNotation("h5").SouthEast);
            Assert.Null(b.GetSquareBySquareNotation("h6").SouthEast);
            Assert.Null(b.GetSquareBySquareNotation("h7").SouthEast);
            Assert.Null(b.GetSquareBySquareNotation("h8").SouthEast);

        }

        [Fact()]
        public void BoardSquareSouthNeighborsTest()
        {
            Board b = new Board();

            Assert.Equal("a7", b.GetSquareBySquareNotation("a8").South.Notation);
            Assert.Equal("b7", b.GetSquareBySquareNotation("b8").South.Notation);
            Assert.Equal("c7", b.GetSquareBySquareNotation("c8").South.Notation);
            Assert.Equal("d7", b.GetSquareBySquareNotation("d8").South.Notation);
            Assert.Equal("e7", b.GetSquareBySquareNotation("e8").South.Notation);
            Assert.Equal("f7", b.GetSquareBySquareNotation("f8").South.Notation);
            Assert.Equal("g7", b.GetSquareBySquareNotation("g8").South.Notation);
            Assert.Equal("h7", b.GetSquareBySquareNotation("h8").South.Notation);

            Assert.Equal("a6", b.GetSquareBySquareNotation("a7").South.Notation);
            Assert.Equal("b6", b.GetSquareBySquareNotation("b7").South.Notation);
            Assert.Equal("c6", b.GetSquareBySquareNotation("c7").South.Notation);
            Assert.Equal("d6", b.GetSquareBySquareNotation("d7").South.Notation);
            Assert.Equal("e6", b.GetSquareBySquareNotation("e7").South.Notation);
            Assert.Equal("f6", b.GetSquareBySquareNotation("f7").South.Notation);
            Assert.Equal("g6", b.GetSquareBySquareNotation("g7").South.Notation);
            Assert.Equal("h6", b.GetSquareBySquareNotation("h7").South.Notation);

            // SouthNeighbors in Row 1 are null
            Assert.Null(b.GetSquareBySquareNotation("a1").South);
            Assert.Null(b.GetSquareBySquareNotation("b1").South);
            Assert.Null(b.GetSquareBySquareNotation("c1").South);
            Assert.Null(b.GetSquareBySquareNotation("d1").South);
            Assert.Null(b.GetSquareBySquareNotation("e1").South);
            Assert.Null(b.GetSquareBySquareNotation("f1").South);
            Assert.Null(b.GetSquareBySquareNotation("g1").South);
            Assert.Null(b.GetSquareBySquareNotation("h1").South);
        }

        [Fact()]
        public void BoardSquareSouthWestNeighborsTest()
        {
            Board b = new Board();

            Assert.Equal("a7", b.GetSquareBySquareNotation("b8").SouthWest.Notation);
            Assert.Equal("b7", b.GetSquareBySquareNotation("c8").SouthWest.Notation);
            Assert.Equal("c7", b.GetSquareBySquareNotation("d8").SouthWest.Notation);
            Assert.Equal("d7", b.GetSquareBySquareNotation("e8").SouthWest.Notation);
            Assert.Equal("e7", b.GetSquareBySquareNotation("f8").SouthWest.Notation);
            Assert.Equal("f7", b.GetSquareBySquareNotation("g8").SouthWest.Notation);
            Assert.Equal("g7", b.GetSquareBySquareNotation("h8").SouthWest.Notation);

            Assert.Equal("a6", b.GetSquareBySquareNotation("b7").SouthWest.Notation);
            Assert.Equal("b6", b.GetSquareBySquareNotation("c7").SouthWest.Notation);
            Assert.Equal("c6", b.GetSquareBySquareNotation("d7").SouthWest.Notation);
            Assert.Equal("d6", b.GetSquareBySquareNotation("e7").SouthWest.Notation);
            Assert.Equal("e6", b.GetSquareBySquareNotation("f7").SouthWest.Notation);
            Assert.Equal("f6", b.GetSquareBySquareNotation("g7").SouthWest.Notation);
            Assert.Equal("g6", b.GetSquareBySquareNotation("h7").SouthWest.Notation);

            Assert.Null(b.GetSquareBySquareNotation("a1").SouthWest);
            Assert.Null(b.GetSquareBySquareNotation("b1").SouthWest);
            Assert.Null(b.GetSquareBySquareNotation("c1").SouthWest);
            Assert.Null(b.GetSquareBySquareNotation("d1").SouthWest);
            Assert.Null(b.GetSquareBySquareNotation("e1").SouthWest);
            Assert.Null(b.GetSquareBySquareNotation("f1").SouthWest);
            Assert.Null(b.GetSquareBySquareNotation("g1").SouthWest);
            Assert.Null(b.GetSquareBySquareNotation("h1").SouthWest);
            Assert.Null(b.GetSquareBySquareNotation("a2").SouthWest);
            Assert.Null(b.GetSquareBySquareNotation("a3").SouthWest);
            Assert.Null(b.GetSquareBySquareNotation("a4").SouthWest);
            Assert.Null(b.GetSquareBySquareNotation("a5").SouthWest);
            Assert.Null(b.GetSquareBySquareNotation("a6").SouthWest);
            Assert.Null(b.GetSquareBySquareNotation("a7").SouthWest);
            Assert.Null(b.GetSquareBySquareNotation("a8").SouthWest);
        }

        [Fact()]
        public void BoardSquareWestNeighborsTest()
        {
            Board b = new Board();

            Assert.Equal("g1", b.GetSquareBySquareNotation("h1").West.Notation);
            Assert.Equal("g2", b.GetSquareBySquareNotation("h2").West.Notation);
            Assert.Equal("g3", b.GetSquareBySquareNotation("h3").West.Notation);
            Assert.Equal("g4", b.GetSquareBySquareNotation("h4").West.Notation);
            Assert.Equal("g5", b.GetSquareBySquareNotation("h5").West.Notation);
            Assert.Equal("g6", b.GetSquareBySquareNotation("h6").West.Notation);
            Assert.Equal("g7", b.GetSquareBySquareNotation("h7").West.Notation);
            Assert.Equal("g8", b.GetSquareBySquareNotation("h8").West.Notation);

            Assert.Equal("f1", b.GetSquareBySquareNotation("g1").West.Notation);
            Assert.Equal("f2", b.GetSquareBySquareNotation("g2").West.Notation);
            Assert.Equal("f3", b.GetSquareBySquareNotation("g3").West.Notation);
            Assert.Equal("f4", b.GetSquareBySquareNotation("g4").West.Notation);
            Assert.Equal("f5", b.GetSquareBySquareNotation("g5").West.Notation);
            Assert.Equal("f6", b.GetSquareBySquareNotation("g6").West.Notation);
            Assert.Equal("f7", b.GetSquareBySquareNotation("g7").West.Notation);
            Assert.Equal("f8", b.GetSquareBySquareNotation("g8").West.Notation);

            // WestNeighbors in Row 8 are null
            Assert.Null(b.GetSquareBySquareNotation("a1").West);
            Assert.Null(b.GetSquareBySquareNotation("a2").West);
            Assert.Null(b.GetSquareBySquareNotation("a3").West);
            Assert.Null(b.GetSquareBySquareNotation("a4").West);
            Assert.Null(b.GetSquareBySquareNotation("a5").West);
            Assert.Null(b.GetSquareBySquareNotation("a6").West);
            Assert.Null(b.GetSquareBySquareNotation("a7").West);
            Assert.Null(b.GetSquareBySquareNotation("a8").West);
        }

        [Fact()]
        public void BoardSquareNorthWestNeighborsTest()
        {
            Board b = new Board();

            Assert.Equal("a2", b.GetSquareBySquareNotation("b1").NorthWest.Notation);
            Assert.Equal("b2", b.GetSquareBySquareNotation("c1").NorthWest.Notation);
            Assert.Equal("c2", b.GetSquareBySquareNotation("d1").NorthWest.Notation);
            Assert.Equal("d2", b.GetSquareBySquareNotation("e1").NorthWest.Notation);
            Assert.Equal("e2", b.GetSquareBySquareNotation("f1").NorthWest.Notation);
            Assert.Equal("f2", b.GetSquareBySquareNotation("g1").NorthWest.Notation);
            Assert.Equal("g2", b.GetSquareBySquareNotation("h1").NorthWest.Notation);

            Assert.Equal("a3", b.GetSquareBySquareNotation("b2").NorthWest.Notation);
            Assert.Equal("b3", b.GetSquareBySquareNotation("c2").NorthWest.Notation);
            Assert.Equal("c3", b.GetSquareBySquareNotation("d2").NorthWest.Notation);
            Assert.Equal("d3", b.GetSquareBySquareNotation("e2").NorthWest.Notation);
            Assert.Equal("e3", b.GetSquareBySquareNotation("f2").NorthWest.Notation);
            Assert.Equal("f3", b.GetSquareBySquareNotation("g2").NorthWest.Notation);
            Assert.Equal("g3", b.GetSquareBySquareNotation("h2").NorthWest.Notation);

            Assert.Null(b.GetSquareBySquareNotation("a8").NorthWest);
            Assert.Null(b.GetSquareBySquareNotation("b8").NorthWest);
            Assert.Null(b.GetSquareBySquareNotation("c8").NorthWest);
            Assert.Null(b.GetSquareBySquareNotation("d8").NorthWest);
            Assert.Null(b.GetSquareBySquareNotation("e8").NorthWest);
            Assert.Null(b.GetSquareBySquareNotation("f8").NorthWest);
            Assert.Null(b.GetSquareBySquareNotation("g8").NorthWest);
            Assert.Null(b.GetSquareBySquareNotation("h8").NorthWest);
            Assert.Null(b.GetSquareBySquareNotation("a1").NorthWest);
            Assert.Null(b.GetSquareBySquareNotation("a2").NorthWest);
            Assert.Null(b.GetSquareBySquareNotation("a3").NorthWest);
            Assert.Null(b.GetSquareBySquareNotation("a4").NorthWest);
            Assert.Null(b.GetSquareBySquareNotation("a5").NorthWest);
            Assert.Null(b.GetSquareBySquareNotation("a6").NorthWest);
            Assert.Null(b.GetSquareBySquareNotation("a7").NorthWest);
        }
    }
}
