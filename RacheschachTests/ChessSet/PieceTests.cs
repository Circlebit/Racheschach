﻿using Xunit;
using System.Collections.Generic;
using Racheschach.Notation;

namespace Racheschach.ChessSet.Tests
{
    public class PieceTests
    {
        [Fact()]
        public void GetPossibleMovesForRookTest()
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

        [Fact()]
        public void GetPossibleMovesForBishopTest()
        {
            var f = new FEN("rnb1k1n1/2p3p1/P7/3qpr2/2R3pP/bP5R/1B1P1P2/1N1QKBN1 b q - 2 13");
            var b = f.Board;

            Piece whiteBishopL = b.GetSquareBySquareNotation("b2").Piece;
            var whiteBishopLAssertMoves = new List<Move>() {
                b.GetNewMove("b2","a3"),
                b.GetNewMove("b2","c3"),
                b.GetNewMove("b2","d4"),
                b.GetNewMove("b2","e5"),
                b.GetNewMove("b2","c1"),
                b.GetNewMove("b2","a1")};
            Assert.Equal(whiteBishopLAssertMoves, whiteBishopL.GetPossibleMoves());

            Piece whiteBishopR = b.GetSquareBySquareNotation("f1").Piece;
            var whiteBishopRAssertMoves = new List<Move>() {
                b.GetNewMove("f1","e2"),
                b.GetNewMove("f1","d3"),
                b.GetNewMove("f1","g2")};
            Assert.Equal(whiteBishopRAssertMoves, whiteBishopR.GetPossibleMoves());

            Piece blackBishopL = b.GetSquareBySquareNotation("c8").Piece;
            var blackBishopLAssertMoves = new List<Move>() {
                b.GetNewMove("c8","d7"),
                b.GetNewMove("c8","e6"),
                b.GetNewMove("c8","b7"),
                b.GetNewMove("c8","a6")};
            Assert.Equal(blackBishopLAssertMoves, blackBishopL.GetPossibleMoves());

            Piece blackBishopR = b.GetSquareBySquareNotation("a3").Piece;
            var blackBishopRAssertMoves = new List<Move>() {
                b.GetNewMove("a3","b4"),
                b.GetNewMove("a3","c5"),
                b.GetNewMove("a3","d6"),
                b.GetNewMove("a3","e7"),
                b.GetNewMove("a3","f8"),
                b.GetNewMove("a3","b2")};
            Assert.Equal(blackBishopRAssertMoves, blackBishopR.GetPossibleMoves());


            var b2 = new Board();
            b2.SetupGame();
            Assert.Equal(new List<Move>(), b2.GetSquareBySquareNotation("c1").Piece.GetPossibleMoves());
            Assert.Equal(new List<Move>(), b2.GetSquareBySquareNotation("f1").Piece.GetPossibleMoves());
            Assert.Equal(new List<Move>(), b2.GetSquareBySquareNotation("c8").Piece.GetPossibleMoves());
            Assert.Equal(new List<Move>(), b2.GetSquareBySquareNotation("f8").Piece.GetPossibleMoves());
        }

        [Fact()]
        public void GetPossibleMovesForQueenTest()
        {
            var f = new FEN("rnb1k1n1/2p3p1/P7/3qpr2/2R3pP/bP5R/1B1P1P2/1N1QKBN1 b q - 2 13");
            var b = f.Board;

            Piece whiteQueen = b.GetSquareBySquareNotation("d1").Piece;
            var whiteBishopLAssertMoves = new List<Move>() {
                b.GetNewMove("d1","c2"),
                b.GetNewMove("d1","e2"),
                b.GetNewMove("d1","f3"),
                b.GetNewMove("d1","g4"),
                b.GetNewMove("d1","c1")};
            Assert.Equal(whiteBishopLAssertMoves, whiteQueen.GetPossibleMoves());

            Piece blackQueen = b.GetSquareBySquareNotation("d5").Piece;
            var blackBishopLAssertMoves = new List<Move>() {
                b.GetNewMove("d5","c6"),
                b.GetNewMove("d5","b7"),
                b.GetNewMove("d5","d6"),
                b.GetNewMove("d5","d7"),
                b.GetNewMove("d5","d8"),
                b.GetNewMove("d5","e6"),
                b.GetNewMove("d5","f7"),
                b.GetNewMove("d5","e4"),
                b.GetNewMove("d5","f3"),
                b.GetNewMove("d5","g2"),
                b.GetNewMove("d5","h1"),
                b.GetNewMove("d5","d4"),
                b.GetNewMove("d5","d3"),
                b.GetNewMove("d5","d2"),
                b.GetNewMove("d5","c4"),
                b.GetNewMove("d5","c5"),
                b.GetNewMove("d5","b5"),
                b.GetNewMove("d5","a5")};
            Assert.Equal(blackBishopLAssertMoves, blackQueen.GetPossibleMoves());

            var b2 = new Board();
            b2.SetupGame();
            Assert.Equal(new List<Move>(), b2.GetSquareBySquareNotation("d1").Piece.GetPossibleMoves());
            Assert.Equal(new List<Move>(), b2.GetSquareBySquareNotation("d8").Piece.GetPossibleMoves());
        }

        [Fact()]
        public void GetPossibleMovesForKingTest()
        {
            var f = new FEN("rnb5/2p1k1p1/P1R4n/3qpr2/6pP/bP5R/1B1P1P2/1N1QKBN1 w - - 5 15");
            var b = f.Board;

            Piece whiteKing = b.GetSquareBySquareNotation("e1").Piece;
            var whiteKingAssertMoves = new List<Move>() { b.GetNewMove("e1","e2") };
            Assert.Equal(whiteKingAssertMoves, whiteKing.GetPossibleMoves());

            Piece blackKing = b.GetSquareBySquareNotation("e7").Piece;
            var blackKingAssertMoves = new List<Move>() {
                b.GetNewMove("e7","d8"),
                b.GetNewMove("e7","e8"),
                b.GetNewMove("e7","f8"),
                b.GetNewMove("e7","f7"),
                b.GetNewMove("e7","f6"),
                b.GetNewMove("e7","e6"),
                b.GetNewMove("e7","d6"),
                b.GetNewMove("e7","d7")};
            var foo = blackKing.GetPossibleMoves();
            Assert.Equal(blackKingAssertMoves, blackKing.GetPossibleMoves());

            var b2 = new Board();
            b2.SetupGame();
            Assert.Equal(new List<Move>(), b2.GetSquareBySquareNotation("e1").Piece.GetPossibleMoves());
            Assert.Equal(new List<Move>(), b2.GetSquareBySquareNotation("e8").Piece.GetPossibleMoves());
        }

        [Fact()]
        public void GetPossibleMovesForKnightTest()
        {
            var f = new FEN("rnbqkbnr/ppppppp1/7p/3N4/8/8/PPPPPPPP/R1BQKBNR b KQkq - 1 2");
            var b = f.Board;

            Piece whiteKnightL = b.GetSquareBySquareNotation("d5").Piece;
            var whiteKnightLAssertMoves = new List<Move>() {
                b.GetNewMove("d5","c7"),
                b.GetNewMove("d5","e7"),
                b.GetNewMove("d5","f6"),
                b.GetNewMove("d5","f4"),
                b.GetNewMove("d5","e3"),
                b.GetNewMove("d5","c3"),
                b.GetNewMove("d5","b4"),
                b.GetNewMove("d5","b6")};
            Assert.Equal(whiteKnightLAssertMoves, whiteKnightL.GetPossibleMoves());

            Piece whiteKnightR = b.GetSquareBySquareNotation("g1").Piece;
            var whiteKnightRAssertMoves = new List<Move>() {
                b.GetNewMove("g1","f3"),
                b.GetNewMove("g1","h3")};
            Assert.Equal(whiteKnightRAssertMoves, whiteKnightR.GetPossibleMoves());

            Piece blackKnightL = b.GetSquareBySquareNotation("b8").Piece;
            var blackKnightLAssertMoves = new List<Move>() {
                b.GetNewMove("b8","c6"),
                b.GetNewMove("b8","a6")};
            Assert.Equal(blackKnightLAssertMoves, blackKnightL.GetPossibleMoves());

            Piece blackKnightR = b.GetSquareBySquareNotation("g8").Piece;
            var blackKnightRAssertMoves = new List<Move>() {
                b.GetNewMove("g8","f6") };
            Assert.Equal(blackKnightRAssertMoves, blackKnightR.GetPossibleMoves());
        }

    }
}