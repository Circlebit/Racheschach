using Xunit;
using Racheschach.ChessSet;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace Racheschach.ChessSet.Tests
{
    public class BoardHelpersOutputTests
    {
        private readonly ITestOutputHelper output;

        public BoardHelpersOutputTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact()]
        public void BoardToUnicodeTest()
        {
            var b = new Board();
            b.SetupGame();
            string s = BoardHelpers.BoardToUnicode(b);
            output.WriteLine(s);
            Assert.True(false, "This test needs an implementation");
        }
    }
}