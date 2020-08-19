using Xunit;
using Racheschach.Notation;
using System;
using System.Collections.Generic;
using System.Text;
using Racheschach.ChessSet;

namespace Racheschach.Notation.Tests
{
    public class FENTests
    {
        [Fact()]
        public void FENFreshlySetupTest()
        {
            var b = new Board();
            var fen = new FEN(b);

            Assert.Equal("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1", fen.String);
        }

        [Fact()]
        public void ParseRowSquaresFreshlySetupTest()
        {
            var b = new Board();
            var fen = new FEN(b);

            Assert.Equal("rnbqkbnr", fen.ParseRowSquares(b.GetRowOrColumn('8')));
            Assert.Equal("pppppppp", fen.ParseRowSquares(b.GetRowOrColumn('7')));
            Assert.Equal("8", fen.ParseRowSquares(b.GetRowOrColumn('6')));
            Assert.Equal("8", fen.ParseRowSquares(b.GetRowOrColumn('5')));
            Assert.Equal("8", fen.ParseRowSquares(b.GetRowOrColumn('4')));
            Assert.Equal("8", fen.ParseRowSquares(b.GetRowOrColumn('3')));
            Assert.Equal("PPPPPPPP", fen.ParseRowSquares(b.GetRowOrColumn('2')));
            Assert.Equal("RNBQKBNR", fen.ParseRowSquares(b.GetRowOrColumn('1')));

            //TODO: Do more tests when moves are possible
        }

        [Fact()]
        public void ParseRowSquaresSomePiecesRemovedTest()
        {
            var b = new Board();
            var fen = new FEN(b);

            // remove black knights
            b.GetSquareBySquareNotation("b8").Piece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("g8").Piece.PieceType = PieceType.None;

            // remove first and last black pawn
            b.GetSquareBySquareNotation("a7").Piece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("h7").Piece.PieceType = PieceType.None;

            // remove all white pawns except the outer ones
            b.GetSquareBySquareNotation("b2").Piece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("c2").Piece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("d2").Piece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("e2").Piece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("f2").Piece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("g2").Piece.PieceType = PieceType.None;

            //// remove all white pieces other than king and queen
            b.GetSquareBySquareNotation("a1").Piece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("b1").Piece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("c1").Piece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("f1").Piece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("g1").Piece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("h1").Piece.PieceType = PieceType.None;

            Assert.Equal("r1bqkb1r", fen.ParseRowSquares(b.GetRowOrColumn('8')));
            Assert.Equal("1pppppp1", fen.ParseRowSquares(b.GetRowOrColumn('7')));
            Assert.Equal("8", fen.ParseRowSquares(b.GetRowOrColumn('6')));
            Assert.Equal("8", fen.ParseRowSquares(b.GetRowOrColumn('5')));
            Assert.Equal("8", fen.ParseRowSquares(b.GetRowOrColumn('4')));
            Assert.Equal("8", fen.ParseRowSquares(b.GetRowOrColumn('3')));
            Assert.Equal("P6P", fen.ParseRowSquares(b.GetRowOrColumn('2')));
            Assert.Equal("3QK3", fen.ParseRowSquares(b.GetRowOrColumn('1')));
        }
    }
}