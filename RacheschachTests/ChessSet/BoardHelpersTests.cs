using Xunit;
using Racheschach.ChessSet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet.Tests
{
    public class BoardHelpersTests
    {
        [Fact()]
        public void SquareNotationByArrayIndexTest()
        {
            Assert.Equal("a1", BoardHelpers.SquareNotationByArrayIndex(0, 0));
            Assert.Equal("b1", BoardHelpers.SquareNotationByArrayIndex(1, 0));
            Assert.Equal("c1", BoardHelpers.SquareNotationByArrayIndex(2, 0));
            Assert.Equal("d1", BoardHelpers.SquareNotationByArrayIndex(3, 0));
            Assert.Equal("e1", BoardHelpers.SquareNotationByArrayIndex(4, 0));
            Assert.Equal("f1", BoardHelpers.SquareNotationByArrayIndex(5, 0));
            Assert.Equal("g1", BoardHelpers.SquareNotationByArrayIndex(6, 0));
            Assert.Equal("h1", BoardHelpers.SquareNotationByArrayIndex(7, 0));

            Assert.Equal("a2", BoardHelpers.SquareNotationByArrayIndex(0, 1));
            Assert.Equal("b2", BoardHelpers.SquareNotationByArrayIndex(1, 1));
            Assert.Equal("c2", BoardHelpers.SquareNotationByArrayIndex(2, 1));
            Assert.Equal("d2", BoardHelpers.SquareNotationByArrayIndex(3, 1));
            Assert.Equal("e2", BoardHelpers.SquareNotationByArrayIndex(4, 1));
            Assert.Equal("f2", BoardHelpers.SquareNotationByArrayIndex(5, 1));
            Assert.Equal("g2", BoardHelpers.SquareNotationByArrayIndex(6, 1));
            Assert.Equal("h2", BoardHelpers.SquareNotationByArrayIndex(7, 1));

            Assert.Equal("a8", BoardHelpers.SquareNotationByArrayIndex(0, 7));
            Assert.Equal("b8", BoardHelpers.SquareNotationByArrayIndex(1, 7));
            Assert.Equal("c8", BoardHelpers.SquareNotationByArrayIndex(2, 7));
            Assert.Equal("d8", BoardHelpers.SquareNotationByArrayIndex(3, 7));
            Assert.Equal("e8", BoardHelpers.SquareNotationByArrayIndex(4, 7));
            Assert.Equal("f8", BoardHelpers.SquareNotationByArrayIndex(5, 7));
            Assert.Equal("g8", BoardHelpers.SquareNotationByArrayIndex(6, 7));
            Assert.Equal("h8", BoardHelpers.SquareNotationByArrayIndex(7, 7));
        }

        [Fact()]
        public void SquareNotationByArrayIndexInvalidValuesTest()
        {
            Action act;

            act = () => BoardHelpers.SquareNotationByArrayIndex(-1, 0);
            Assert.Throws<ArgumentOutOfRangeException>(act);

            act = () => BoardHelpers.SquareNotationByArrayIndex(0, -1);
            Assert.Throws<ArgumentOutOfRangeException>(act);

            act = () => BoardHelpers.SquareNotationByArrayIndex(8, 0);
            Assert.Throws<ArgumentOutOfRangeException>(act);

            act = () => BoardHelpers.SquareNotationByArrayIndex(0, 8);
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }


        [Fact()]
        public void ArrayIndexBySquareNotationTest()
        {
            Assert.Equal((0, 0), BoardHelpers.ArrayIndexBySquareNotation("A1"));
            Assert.Equal((1, 0), BoardHelpers.ArrayIndexBySquareNotation("B1"));
            Assert.Equal((2, 0), BoardHelpers.ArrayIndexBySquareNotation(" C1"));
            Assert.Equal((3, 0), BoardHelpers.ArrayIndexBySquareNotation("D1 "));
            Assert.Equal((4, 0), BoardHelpers.ArrayIndexBySquareNotation("e1"));
            Assert.Equal((5, 0), BoardHelpers.ArrayIndexBySquareNotation("f1"));
            Assert.Equal((6, 0), BoardHelpers.ArrayIndexBySquareNotation("g1 "));
            Assert.Equal((7, 0), BoardHelpers.ArrayIndexBySquareNotation(" h1"));

            Assert.Equal((0, 1), BoardHelpers.ArrayIndexBySquareNotation("a2"));
            Assert.Equal((1, 1), BoardHelpers.ArrayIndexBySquareNotation("b2"));
            Assert.Equal((2, 1), BoardHelpers.ArrayIndexBySquareNotation("c2"));
            Assert.Equal((3, 1), BoardHelpers.ArrayIndexBySquareNotation("d2"));
            Assert.Equal((4, 1), BoardHelpers.ArrayIndexBySquareNotation("E2"));
            Assert.Equal((5, 1), BoardHelpers.ArrayIndexBySquareNotation("F2"));
            Assert.Equal((6, 1), BoardHelpers.ArrayIndexBySquareNotation("G2"));
            Assert.Equal((7, 1), BoardHelpers.ArrayIndexBySquareNotation("H2"));

            Assert.Equal((0, 7), BoardHelpers.ArrayIndexBySquareNotation("a8"));
            Assert.Equal((1, 7), BoardHelpers.ArrayIndexBySquareNotation("b8"));
            Assert.Equal((2, 7), BoardHelpers.ArrayIndexBySquareNotation("c8"));
            Assert.Equal((3, 7), BoardHelpers.ArrayIndexBySquareNotation("d8"));
            Assert.Equal((4, 7), BoardHelpers.ArrayIndexBySquareNotation("e8"));
            Assert.Equal((5, 7), BoardHelpers.ArrayIndexBySquareNotation("f8"));
            Assert.Equal((6, 7), BoardHelpers.ArrayIndexBySquareNotation("g8"));
            Assert.Equal((7, 7), BoardHelpers.ArrayIndexBySquareNotation("h8"));
        }

        [Fact()]
        public void ArrayIndexBySquareNotationInvalidValuesTest()
        {
            Action act;

            act = () => BoardHelpers.ArrayIndexBySquareNotation("i1");
            Assert.Throws<ArgumentOutOfRangeException>(act);

            act = () => BoardHelpers.ArrayIndexBySquareNotation("a12");
            Assert.Throws<ArgumentOutOfRangeException>(act);

            act = () => BoardHelpers.ArrayIndexBySquareNotation("x3");
            Assert.Throws<ArgumentOutOfRangeException>(act);

            act = () => BoardHelpers.ArrayIndexBySquareNotation("♞1");
            Assert.Throws<ArgumentOutOfRangeException>(act);

            act = () => BoardHelpers.ArrayIndexBySquareNotation("2b");
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }
    }
}