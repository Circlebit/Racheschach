using Xunit;
using System.Collections.Generic;
using Racheschach.Notation;

namespace Racheschach.ChessSet.Tests
{
    public class PieceRookTests
    {
        [Fact()]
        public void GetPossibleMoves_Rook_Test()
        {
            var f = new FEN("rnb1kbn1/2p1p1p1/P7/3q1r2/2R3pP/7R/1P1P1P2/1NBQKBN1 b q - 2 11");
            var b = f.Board;

            Piece whiteRookL = b.GetSquareBySquareNotation("c4").Piece;
            var whiteRookLAssertMoves = new List<Move>() {
                b.GetNewMove("c4","c5"),
                b.GetNewMove("c4","c6"),
                b.GetNewMove("c4","c7"),
                b.GetNewMove("c4","d4"),
                b.GetNewMove("c4","e4"),
                b.GetNewMove("c4","f4"),
                b.GetNewMove("c4","g4"),
                b.GetNewMove("c4","c3"),
                b.GetNewMove("c4","c2"),
                b.GetNewMove("c4","b4"),
                b.GetNewMove("c4","a4")};
            Assert.Equal(whiteRookLAssertMoves, whiteRookL.GetPossibleMoves());

            Piece whiteRookR = b.GetSquareBySquareNotation("h3").Piece;
            var whiteRookRAssertMoves = new List<Move>() {
                b.GetNewMove("h3","h2"),
                b.GetNewMove("h3","h1"),
                b.GetNewMove("h3","g3"),
                b.GetNewMove("h3","f3"),
                b.GetNewMove("h3","e3"),
                b.GetNewMove("h3","d3"),
                b.GetNewMove("h3","c3"),
                b.GetNewMove("h3","b3"),
                b.GetNewMove("h3","a3")};
            Assert.Equal(whiteRookRAssertMoves, whiteRookR.GetPossibleMoves());

            Piece blackRookL = b.GetSquareBySquareNotation("a8").Piece;
            var blackRookLAssertMoves = new List<Move>() {
                b.GetNewMove("a8","a7"),
                b.GetNewMove("a8","a6")};
            Assert.Equal(blackRookLAssertMoves, blackRookL.GetPossibleMoves());

            Piece blackRookR = b.GetSquareBySquareNotation("f5").Piece;
            var blackRookRAssertMoves = new List<Move>() {
                b.GetNewMove("f5","f6"),
                b.GetNewMove("f5","f7"),
                b.GetNewMove("f5","g5"),
                b.GetNewMove("f5","h5"),
                b.GetNewMove("f5","f4"),
                b.GetNewMove("f5","f3"),
                b.GetNewMove("f5","f2"),
                b.GetNewMove("f5","e5")};
            Assert.Equal(blackRookRAssertMoves, blackRookR.GetPossibleMoves());


            var b2 = new Board();
            b2.SetupGame();
            Assert.Equal(new List<Move>(), b2.GetSquareBySquareNotation("a1").Piece.GetPossibleMoves());
            Assert.Equal(new List<Move>(), b2.GetSquareBySquareNotation("h1").Piece.GetPossibleMoves());
            Assert.Equal(new List<Move>(), b2.GetSquareBySquareNotation("a8").Piece.GetPossibleMoves());
            Assert.Equal(new List<Move>(), b2.GetSquareBySquareNotation("h8").Piece.GetPossibleMoves());
        }
    }
}