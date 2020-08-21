using Xunit;
using Racheschach.ChessSet;
using System;
using System.Collections.Generic;
using System.Text;
using Racheschach.Notation;

namespace Racheschach.ChessSet.Tests
{
    public class MovePlayTests
    {
        [Fact()]
        public void MovePlay_SicilianDefense_Test()
        {
            var b = new Board();

            b.SetupGame();
            var fen0 = new FEN(b);
            Assert.Equal("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1", fen0.String);

            Move e2e4 = b.GetNewMove("e2", "e4");
            b.PlayMove(e2e4);
            var fen1 = new FEN(b);
            Assert.Equal("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1", fen1.String);

            Move c7c5 = b.GetNewMove("c7", "c5");
            b.PlayMove(c7c5);
            var fen2 = new FEN(b);
            Assert.Equal("rnbqkbnr/pp1ppppp/8/2p5/4P3/8/PPPP1PPP/RNBQKBNR w KQkq c6 0 2", fen2.String);

            Move b1c3 = b.GetNewMove("b1", "c3");
            b.PlayMove(b1c3);
            var fen3 = new FEN(b);
            Assert.Equal("rnbqkbnr/pp1ppppp/8/2p5/4P3/2N5/PPPP1PPP/R1BQKBNR b KQkq - 1 2", fen3.String);
        }

        [Fact()]
        public void MovePlay_GibaudLazard_Test()
        {
            var b = new Board();

            b.SetupGame();
            var fen0 = new FEN(b);
            Assert.Equal("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1", fen0.String);

            Move d2d4 = b.GetNewMove("d2", "d4");
            b.PlayMove(d2d4);
            var fen1 = new FEN(b);
            Assert.Equal("rnbqkbnr/pppppppp/8/8/3P4/8/PPP1PPPP/RNBQKBNR b KQkq d3 0 1", fen1.String);

            Move g8f6 = b.GetNewMove("g8", "f6");
            b.PlayMove(g8f6);
            var fen2 = new FEN(b);
            Assert.Equal("rnbqkb1r/pppppppp/5n2/8/3P4/8/PPP1PPPP/RNBQKBNR w KQkq - 1 2", fen2.String);

            Move b1d2 = b.GetNewMove("b1", "d2");
            b.PlayMove(b1d2);
            var fen3 = new FEN(b);
            Assert.Equal("rnbqkb1r/pppppppp/5n2/8/3P4/8/PPPNPPPP/R1BQKBNR b KQkq - 2 2", fen3.String);

            Move e7e5 = b.GetNewMove("e7", "e5");
            b.PlayMove(e7e5);
            var fen4 = new FEN(b);
            Assert.Equal("rnbqkb1r/pppp1ppp/5n2/4p3/3P4/8/PPPNPPPP/R1BQKBNR w KQkq e6 0 3", fen4.String);

            Move d4e5 = b.GetNewMove("d4", "e5");
            b.PlayMove(d4e5);
            var fen5 = new FEN(b);
            Assert.Equal("rnbqkb1r/pppp1ppp/5n2/4P3/8/8/PPPNPPPP/R1BQKBNR b KQkq - 0 3", fen5.String);

            Move f6g4 = b.GetNewMove("f6", "g4");
            b.PlayMove(f6g4);
            var fen6 = new FEN(b);
            Assert.Equal("rnbqkb1r/pppp1ppp/8/4P3/6n1/8/PPPNPPPP/R1BQKBNR w KQkq - 1 4", fen6.String);

            Move h2h3 = b.GetNewMove("h2", "h3");
            b.PlayMove(h2h3);
            var fen7 = new FEN(b);
            Assert.Equal("rnbqkb1r/pppp1ppp/8/4P3/6n1/7P/PPPNPPP1/R1BQKBNR b KQkq - 0 4", fen7.String);

            Move g4e3 = b.GetNewMove("g4", "e3");
            b.PlayMove(g4e3);
            var fen8 = new FEN(b);
            Assert.Equal("rnbqkb1r/pppp1ppp/8/4P3/8/4n2P/PPPNPPP1/R1BQKBNR w KQkq - 1 5", fen8.String);
        }
    }
}