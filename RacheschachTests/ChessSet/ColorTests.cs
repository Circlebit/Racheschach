using Xunit;
using Racheschach.ChessSet;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace Racheschach.ChessSet.Tests
{
    public class ColorTests
    {

        [Fact()]
        public void ColorOppositeTest()
        {
            var white = Color.White;
            var black = Color.Black;

            Assert.Equal(Color.White, black.Opposite());
            Assert.Equal(Color.Black, white.Opposite());
            Assert.Equal(Color.White, white.Opposite().Opposite());
            Assert.Equal(Color.Black, white.Opposite().Opposite().Opposite());

        }
    }
}