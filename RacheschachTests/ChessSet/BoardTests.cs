﻿using Xunit;
using Racheschach.ChessSet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet.Tests
{
    public class BoardTests
    {
        [Fact()]
        public void BoardSquareNotationsTest()
        {
            Board b = new Board();

            Assert.Equal("a1", b.Squares[0, 0].Notation);
            Assert.Equal("b1", b.Squares[1, 0].Notation);
            Assert.Equal("c1", b.Squares[2, 0].Notation);
            Assert.Equal("d1", b.Squares[3, 0].Notation);
            Assert.Equal("e1", b.Squares[4, 0].Notation);
            Assert.Equal("f1", b.Squares[5, 0].Notation);
            Assert.Equal("g1", b.Squares[6, 0].Notation);
            Assert.Equal("h1", b.Squares[7, 0].Notation);

            Assert.Equal("a2", b.Squares[0, 1].Notation);
            Assert.Equal("b2", b.Squares[1, 1].Notation);
            Assert.Equal("c2", b.Squares[2, 1].Notation);
            Assert.Equal("d2", b.Squares[3, 1].Notation);
            Assert.Equal("e2", b.Squares[4, 1].Notation);
            Assert.Equal("f2", b.Squares[5, 1].Notation);
            Assert.Equal("g2", b.Squares[6, 1].Notation);
            Assert.Equal("h2", b.Squares[7, 1].Notation);

            Assert.Equal("a8", b.Squares[0, 7].Notation);
            Assert.Equal("b8", b.Squares[1, 7].Notation);
            Assert.Equal("c8", b.Squares[2, 7].Notation);
            Assert.Equal("d8", b.Squares[3, 7].Notation);
            Assert.Equal("e8", b.Squares[4, 7].Notation);
            Assert.Equal("f8", b.Squares[5, 7].Notation);
            Assert.Equal("g8", b.Squares[6, 7].Notation);
            Assert.Equal("h8", b.Squares[7, 7].Notation);

        }

        [Fact()]
        public void BoardSquaresNotNullTest()
        {
            Board b = new Board();

            Assert.Equal(8, b.Squares.GetLength(0));
            Assert.Equal(8, b.Squares.GetLength(1));

            for (int x = 0; x < b.Squares.GetLength(0); x++)
            {
                for (int y = 0; y < b.Squares.GetLength(1); y++)
                {
                    Assert.NotNull(b.Squares[x, y]);
                }
            }
        }

        [Fact()]
        public void SetupGameTest_WhitePawns()
        {
            Board b = new Board();
            Assert.Equal(PieceType.Pawn, b.GetSquareBySquareNotation("a2").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, b.GetSquareBySquareNotation("b2").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, b.GetSquareBySquareNotation("c2").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, b.GetSquareBySquareNotation("d2").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, b.GetSquareBySquareNotation("e2").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, b.GetSquareBySquareNotation("f2").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, b.GetSquareBySquareNotation("g2").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, b.GetSquareBySquareNotation("h2").Piece.PieceType);
            Assert.Equal(Color.White, b.GetSquareBySquareNotation("a2").Piece.Color);
            Assert.Equal(Color.White, b.GetSquareBySquareNotation("b2").Piece.Color);
            Assert.Equal(Color.White, b.GetSquareBySquareNotation("c2").Piece.Color);
            Assert.Equal(Color.White, b.GetSquareBySquareNotation("d2").Piece.Color);
            Assert.Equal(Color.White, b.GetSquareBySquareNotation("e2").Piece.Color);
            Assert.Equal(Color.White, b.GetSquareBySquareNotation("f2").Piece.Color);
            Assert.Equal(Color.White, b.GetSquareBySquareNotation("g2").Piece.Color);
            Assert.Equal(Color.White, b.GetSquareBySquareNotation("h2").Piece.Color);
        }

        [Fact()]
        public void SetupGameTest_WhitePieces()
        {
            Board b = new Board();
            Assert.Equal(PieceType.Rook, b.GetSquareBySquareNotation("a1").Piece.PieceType);
            Assert.Equal(PieceType.Knight, b.GetSquareBySquareNotation("b1").Piece.PieceType);
            Assert.Equal(PieceType.Bishop, b.GetSquareBySquareNotation("c1").Piece.PieceType);
            Assert.Equal(PieceType.Queen, b.GetSquareBySquareNotation("d1").Piece.PieceType);
            Assert.Equal(PieceType.King, b.GetSquareBySquareNotation("e1").Piece.PieceType);
            Assert.Equal(PieceType.Bishop, b.GetSquareBySquareNotation("f1").Piece.PieceType);
            Assert.Equal(PieceType.Knight, b.GetSquareBySquareNotation("g1").Piece.PieceType);
            Assert.Equal(PieceType.Rook, b.GetSquareBySquareNotation("h1").Piece.PieceType);
            Assert.Equal(Color.White, b.GetSquareBySquareNotation("a1").Piece.Color);
            Assert.Equal(Color.White, b.GetSquareBySquareNotation("b1").Piece.Color);
            Assert.Equal(Color.White, b.GetSquareBySquareNotation("c1").Piece.Color);
            Assert.Equal(Color.White, b.GetSquareBySquareNotation("d1").Piece.Color);
            Assert.Equal(Color.White, b.GetSquareBySquareNotation("e1").Piece.Color);
            Assert.Equal(Color.White, b.GetSquareBySquareNotation("f1").Piece.Color);
            Assert.Equal(Color.White, b.GetSquareBySquareNotation("g1").Piece.Color);
            Assert.Equal(Color.White, b.GetSquareBySquareNotation("h1").Piece.Color);
        }

        [Fact()]
        public void SetupGameTest_BlackPawns()
        {
            Board b = new Board();
            Assert.Equal(PieceType.Pawn, b.GetSquareBySquareNotation("a7").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, b.GetSquareBySquareNotation("b7").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, b.GetSquareBySquareNotation("c7").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, b.GetSquareBySquareNotation("d7").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, b.GetSquareBySquareNotation("e7").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, b.GetSquareBySquareNotation("f7").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, b.GetSquareBySquareNotation("g7").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, b.GetSquareBySquareNotation("h7").Piece.PieceType);
            Assert.Equal(Color.Black, b.GetSquareBySquareNotation("a7").Piece.Color);
            Assert.Equal(Color.Black, b.GetSquareBySquareNotation("b7").Piece.Color);
            Assert.Equal(Color.Black, b.GetSquareBySquareNotation("c7").Piece.Color);
            Assert.Equal(Color.Black, b.GetSquareBySquareNotation("d7").Piece.Color);
            Assert.Equal(Color.Black, b.GetSquareBySquareNotation("e7").Piece.Color);
            Assert.Equal(Color.Black, b.GetSquareBySquareNotation("f7").Piece.Color);
            Assert.Equal(Color.Black, b.GetSquareBySquareNotation("g7").Piece.Color);
            Assert.Equal(Color.Black, b.GetSquareBySquareNotation("h7").Piece.Color);
        }

        [Fact()]
        public void SetupGameTest_BlackPieces()
        {
            Board b = new Board();
            Assert.Equal(PieceType.Rook, b.GetSquareBySquareNotation("a8").Piece.PieceType);
            Assert.Equal(PieceType.Knight, b.GetSquareBySquareNotation("b8").Piece.PieceType);
            Assert.Equal(PieceType.Bishop, b.GetSquareBySquareNotation("c8").Piece.PieceType);
            Assert.Equal(PieceType.Queen, b.GetSquareBySquareNotation("d8").Piece.PieceType);
            Assert.Equal(PieceType.King, b.GetSquareBySquareNotation("e8").Piece.PieceType);
            Assert.Equal(PieceType.Bishop, b.GetSquareBySquareNotation("f8").Piece.PieceType);
            Assert.Equal(PieceType.Knight, b.GetSquareBySquareNotation("g8").Piece.PieceType);
            Assert.Equal(PieceType.Rook, b.GetSquareBySquareNotation("h8").Piece.PieceType);
            Assert.Equal(Color.Black, b.GetSquareBySquareNotation("a8").Piece.Color);
            Assert.Equal(Color.Black, b.GetSquareBySquareNotation("b8").Piece.Color);
            Assert.Equal(Color.Black, b.GetSquareBySquareNotation("c8").Piece.Color);
            Assert.Equal(Color.Black, b.GetSquareBySquareNotation("d8").Piece.Color);
            Assert.Equal(Color.Black, b.GetSquareBySquareNotation("e8").Piece.Color);
            Assert.Equal(Color.Black, b.GetSquareBySquareNotation("f8").Piece.Color);
            Assert.Equal(Color.Black, b.GetSquareBySquareNotation("g8").Piece.Color);
            Assert.Equal(Color.Black, b.GetSquareBySquareNotation("h8").Piece.Color);
        }
    }
}