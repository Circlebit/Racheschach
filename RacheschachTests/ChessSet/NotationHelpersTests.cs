using Xunit;
using Racheschach.ChessSet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet.Tests
{
    public class NotationHelpersTests
    {
        [Fact()]
        public void SquareNotationByArrayIndexTest()
        {
            Assert.Equal("a1", NotationHelpers.SquareNotationByArrayIndex(0, 0));
            Assert.Equal("b1", NotationHelpers.SquareNotationByArrayIndex(1, 0));
            Assert.Equal("c1", NotationHelpers.SquareNotationByArrayIndex(2, 0));
            Assert.Equal("d1", NotationHelpers.SquareNotationByArrayIndex(3, 0));
            Assert.Equal("e1", NotationHelpers.SquareNotationByArrayIndex(4, 0));
            Assert.Equal("f1", NotationHelpers.SquareNotationByArrayIndex(5, 0));
            Assert.Equal("g1", NotationHelpers.SquareNotationByArrayIndex(6, 0));
            Assert.Equal("h1", NotationHelpers.SquareNotationByArrayIndex(7, 0));

            Assert.Equal("a2", NotationHelpers.SquareNotationByArrayIndex(0, 1));
            Assert.Equal("b2", NotationHelpers.SquareNotationByArrayIndex(1, 1));
            Assert.Equal("c2", NotationHelpers.SquareNotationByArrayIndex(2, 1));
            Assert.Equal("d2", NotationHelpers.SquareNotationByArrayIndex(3, 1));
            Assert.Equal("e2", NotationHelpers.SquareNotationByArrayIndex(4, 1));
            Assert.Equal("f2", NotationHelpers.SquareNotationByArrayIndex(5, 1));
            Assert.Equal("g2", NotationHelpers.SquareNotationByArrayIndex(6, 1));
            Assert.Equal("h2", NotationHelpers.SquareNotationByArrayIndex(7, 1));

            Assert.Equal("a8", NotationHelpers.SquareNotationByArrayIndex(0, 7));
            Assert.Equal("b8", NotationHelpers.SquareNotationByArrayIndex(1, 7));
            Assert.Equal("c8", NotationHelpers.SquareNotationByArrayIndex(2, 7));
            Assert.Equal("d8", NotationHelpers.SquareNotationByArrayIndex(3, 7));
            Assert.Equal("e8", NotationHelpers.SquareNotationByArrayIndex(4, 7));
            Assert.Equal("f8", NotationHelpers.SquareNotationByArrayIndex(5, 7));
            Assert.Equal("g8", NotationHelpers.SquareNotationByArrayIndex(6, 7));
            Assert.Equal("h8", NotationHelpers.SquareNotationByArrayIndex(7, 7));
        }

        [Fact()]
        public void SquareNotationByArrayIndexInvalidValuesTest()
        {
            Action act;
                
            act = () => NotationHelpers.SquareNotationByArrayIndex(-1, 0);
            Assert.Throws<ArgumentOutOfRangeException>(act);

            act = () => NotationHelpers.SquareNotationByArrayIndex(0, -1);
            Assert.Throws<ArgumentOutOfRangeException>(act);

            act = () => NotationHelpers.SquareNotationByArrayIndex(8, 0);
            Assert.Throws<ArgumentOutOfRangeException>(act);

            act = () => NotationHelpers.SquareNotationByArrayIndex(0, 8);
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }
    }
}