using Xunit;
using Racheschach.ChessSet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet.Tests
{
    public class SquareTests
    {
        [Fact()]
        public void NorthSquaresTest()
        {
            Board b = new Board();
            Square a1 = b.GetSquareBySquareNotation("a1");
            List<Square> assertA1 = new List<Square>() {
                b.GetSquareBySquareNotation("a2"),
                b.GetSquareBySquareNotation("a3"),
                b.GetSquareBySquareNotation("a4"),
                b.GetSquareBySquareNotation("a5"),
                b.GetSquareBySquareNotation("a6"),
                b.GetSquareBySquareNotation("a7"),
                b.GetSquareBySquareNotation("a8")};
            Assert.Equal(a1.NorthSquares, assertA1);

            Square a2 = b.GetSquareBySquareNotation("a2");
            List<Square> assertA2 = new List<Square>() {
                b.GetSquareBySquareNotation("a3"),
                b.GetSquareBySquareNotation("a4"),
                b.GetSquareBySquareNotation("a5"),
                b.GetSquareBySquareNotation("a6"),
                b.GetSquareBySquareNotation("a7"),
                b.GetSquareBySquareNotation("a8")};
            Assert.Equal(a2.NorthSquares, assertA2);

            Square a8 = b.GetSquareBySquareNotation("a8");
            List<Square> assertA8 = new List<Square>();
            Assert.Equal(a8.NorthSquares, assertA8);


            Square b1 = b.GetSquareBySquareNotation("b1");
            List<Square> assertB1 = new List<Square>() {
                b.GetSquareBySquareNotation("b2"),
                b.GetSquareBySquareNotation("b3"),
                b.GetSquareBySquareNotation("b4"),
                b.GetSquareBySquareNotation("b5"),
                b.GetSquareBySquareNotation("b6"),
                b.GetSquareBySquareNotation("b7"),
                b.GetSquareBySquareNotation("b8")};
            Assert.Equal(b1.NorthSquares, assertB1);

            Square b2 = b.GetSquareBySquareNotation("b2");
            List<Square> assertB2 = new List<Square>() {
                b.GetSquareBySquareNotation("b3"),
                b.GetSquareBySquareNotation("b4"),
                b.GetSquareBySquareNotation("b5"),
                b.GetSquareBySquareNotation("b6"),
                b.GetSquareBySquareNotation("b7"),
                b.GetSquareBySquareNotation("b8")};
            Assert.Equal(b2.NorthSquares, assertB2);

            Square b8 = b.GetSquareBySquareNotation("b8");
            List<Square> assertB8 = new List<Square>();
            Assert.Equal(b8.NorthSquares, assertB8);


            Square h1 = b.GetSquareBySquareNotation("h1");
            List<Square> assertH1 = new List<Square>() {
                b.GetSquareBySquareNotation("h2"),
                b.GetSquareBySquareNotation("h3"),
                b.GetSquareBySquareNotation("h4"),
                b.GetSquareBySquareNotation("h5"),
                b.GetSquareBySquareNotation("h6"),
                b.GetSquareBySquareNotation("h7"),
                b.GetSquareBySquareNotation("h8")};
            Assert.Equal(h1.NorthSquares, assertH1);

            Square h2 = b.GetSquareBySquareNotation("h2");
            List<Square> assertH2 = new List<Square>() {
                b.GetSquareBySquareNotation("h3"),
                b.GetSquareBySquareNotation("h4"),
                b.GetSquareBySquareNotation("h5"),
                b.GetSquareBySquareNotation("h6"),
                b.GetSquareBySquareNotation("h7"),
                b.GetSquareBySquareNotation("h8")};
            Assert.Equal(h2.NorthSquares, assertH2);

            Square h8 = b.GetSquareBySquareNotation("h8");
            List<Square> assertH8 = new List<Square>();
            Assert.Equal(h8.NorthSquares, assertH8);
        }

        [Fact()]
        public void EastSquaresTest()
        {
            Board b = new Board();
            Square a1 = b.GetSquareBySquareNotation("a1");
            List<Square> assertA1 = new List<Square>() {
                b.GetSquareBySquareNotation("b1"),
                b.GetSquareBySquareNotation("c1"),
                b.GetSquareBySquareNotation("d1"),
                b.GetSquareBySquareNotation("e1"),
                b.GetSquareBySquareNotation("f1"),
                b.GetSquareBySquareNotation("g1"),
                b.GetSquareBySquareNotation("h1")};
            Assert.Equal(a1.EastSquares, assertA1);

            Square b1 = b.GetSquareBySquareNotation("b1");
            List<Square> assertB1 = new List<Square>() {
                b.GetSquareBySquareNotation("c1"),
                b.GetSquareBySquareNotation("d1"),
                b.GetSquareBySquareNotation("e1"),
                b.GetSquareBySquareNotation("f1"),
                b.GetSquareBySquareNotation("g1"),
                b.GetSquareBySquareNotation("h1")};
            Assert.Equal(b1.EastSquares, assertB1);

            Square a2 = b.GetSquareBySquareNotation("a2");
            List<Square> assertA2 = new List<Square>() {
                b.GetSquareBySquareNotation("b2"),
                b.GetSquareBySquareNotation("c2"),
                b.GetSquareBySquareNotation("d2"),
                b.GetSquareBySquareNotation("e2"),
                b.GetSquareBySquareNotation("f2"),
                b.GetSquareBySquareNotation("g2"),
                b.GetSquareBySquareNotation("h2")};
            Assert.Equal(a2.EastSquares, assertA2);

            Square f8 = b.GetSquareBySquareNotation("f8");
            List<Square> assertF8 = new List<Square>() {
                b.GetSquareBySquareNotation("g8"),
                b.GetSquareBySquareNotation("h8")};
            Assert.Equal(f8.EastSquares, assertF8);

            Square h1 = b.GetSquareBySquareNotation("h1");
            Assert.Equal(h1.EastSquares, new List<Square>());
            Square h2 = b.GetSquareBySquareNotation("h2");
            Assert.Equal(h2.EastSquares, new List<Square>());
            Square h8 = b.GetSquareBySquareNotation("h8");
            Assert.Equal(h8.EastSquares, new List<Square>());
        }

        [Fact()]
        public void SouthSquaresTest()
        {
            Board b = new Board();
            Square a8 = b.GetSquareBySquareNotation("a8");
            List<Square> assertA8 = new List<Square>() {
                b.GetSquareBySquareNotation("a7"),
                b.GetSquareBySquareNotation("a6"),
                b.GetSquareBySquareNotation("a5"),
                b.GetSquareBySquareNotation("a4"),
                b.GetSquareBySquareNotation("a3"),
                b.GetSquareBySquareNotation("a2"),
                b.GetSquareBySquareNotation("a1")};
            Assert.Equal(a8.SouthSquares, assertA8);

            Square a7 = b.GetSquareBySquareNotation("a7");
            List<Square> assertA7 = new List<Square>() {
                b.GetSquareBySquareNotation("a6"),
                b.GetSquareBySquareNotation("a5"),
                b.GetSquareBySquareNotation("a4"),
                b.GetSquareBySquareNotation("a3"),
                b.GetSquareBySquareNotation("a2"),
                b.GetSquareBySquareNotation("a1")};
            Assert.Equal(a7.SouthSquares, assertA7);

            Square a1 = b.GetSquareBySquareNotation("a1");
            List<Square> assertA1 = new List<Square>();
            Assert.Equal(a1.SouthSquares, assertA1);


            Square b8 = b.GetSquareBySquareNotation("b8");
            List<Square> assertB8 = new List<Square>() {
                b.GetSquareBySquareNotation("b7"),
                b.GetSquareBySquareNotation("b6"),
                b.GetSquareBySquareNotation("b5"),
                b.GetSquareBySquareNotation("b4"),
                b.GetSquareBySquareNotation("b3"),
                b.GetSquareBySquareNotation("b2"),
                b.GetSquareBySquareNotation("b1")};
            Assert.Equal(b8.SouthSquares, assertB8);

            Square b7 = b.GetSquareBySquareNotation("b7");
            List<Square> assertB7 = new List<Square>() {
                b.GetSquareBySquareNotation("b6"),
                b.GetSquareBySquareNotation("b5"),
                b.GetSquareBySquareNotation("b4"),
                b.GetSquareBySquareNotation("b3"),
                b.GetSquareBySquareNotation("b2"),
                b.GetSquareBySquareNotation("b1")};
            Assert.Equal(b7.SouthSquares, assertB7);

            Square b1 = b.GetSquareBySquareNotation("b1");
            List<Square> assertB1 = new List<Square>();
            Assert.Equal(b1.SouthSquares, assertB1);


            Square h8 = b.GetSquareBySquareNotation("h8");
            List<Square> assertH8 = new List<Square>() {
                b.GetSquareBySquareNotation("H7"),
                b.GetSquareBySquareNotation("H6"),
                b.GetSquareBySquareNotation("H5"),
                b.GetSquareBySquareNotation("H4"),
                b.GetSquareBySquareNotation("H3"),
                b.GetSquareBySquareNotation("H2"),
                b.GetSquareBySquareNotation("H1")};
            Assert.Equal(h8.SouthSquares, assertH8);

            Square h7 = b.GetSquareBySquareNotation("h7");
            List<Square> assertH7 = new List<Square>() {
                b.GetSquareBySquareNotation("h6"),
                b.GetSquareBySquareNotation("h5"),
                b.GetSquareBySquareNotation("h4"),
                b.GetSquareBySquareNotation("h3"),
                b.GetSquareBySquareNotation("h2"),
                b.GetSquareBySquareNotation("h1")};
            Assert.Equal(h7.SouthSquares, assertH7);

            Square h1 = b.GetSquareBySquareNotation("h1");
            List<Square> assertH1 = new List<Square>();
            Assert.Equal(h1.SouthSquares, assertH1);
        }

        [Fact()]
        public void WestSquaresTest()
        {
            Board b = new Board();
            Square h1 = b.GetSquareBySquareNotation("h1");
            List<Square> assertH1 = new List<Square>() {
                b.GetSquareBySquareNotation("g1"),
                b.GetSquareBySquareNotation("f1"),
                b.GetSquareBySquareNotation("e1"),
                b.GetSquareBySquareNotation("d1"),
                b.GetSquareBySquareNotation("c1"),
                b.GetSquareBySquareNotation("b1"),
                b.GetSquareBySquareNotation("a1")};
            Assert.Equal(h1.WestSquares, assertH1);

            Square g1 = b.GetSquareBySquareNotation("g1");
            List<Square> assertG1 = new List<Square>() {
                b.GetSquareBySquareNotation("f1"),
                b.GetSquareBySquareNotation("e1"),
                b.GetSquareBySquareNotation("d1"),
                b.GetSquareBySquareNotation("c1"),
                b.GetSquareBySquareNotation("b1"),
                b.GetSquareBySquareNotation("a1")};
            Assert.Equal(g1.WestSquares, assertG1);

            Square h2 = b.GetSquareBySquareNotation("h2");
            List<Square> assertH2 = new List<Square>() {
                b.GetSquareBySquareNotation("g2"),
                b.GetSquareBySquareNotation("f2"),
                b.GetSquareBySquareNotation("e2"),
                b.GetSquareBySquareNotation("d2"),
                b.GetSquareBySquareNotation("c2"),
                b.GetSquareBySquareNotation("b2"),
                b.GetSquareBySquareNotation("a2")};
            Assert.Equal(h2.WestSquares, assertH2);

            Square c8 = b.GetSquareBySquareNotation("c8");
            List<Square> assertC8 = new List<Square>() {
                b.GetSquareBySquareNotation("b8"),
                b.GetSquareBySquareNotation("a8")};
            Assert.Equal(c8.WestSquares, assertC8);

            Square a1 = b.GetSquareBySquareNotation("a1");
            Assert.Equal(a1.WestSquares, new List<Square>());
            Square a2 = b.GetSquareBySquareNotation("a2");
            Assert.Equal(a2.WestSquares, new List<Square>());
            Square a8 = b.GetSquareBySquareNotation("a8");
            Assert.Equal(a8.WestSquares, new List<Square>());
        }

        [Fact()]
        public void NorthEastSquares()
        {
            Board b = new Board();
            Square a1 = b.GetSquareBySquareNotation("a1");
            List<Square> assertA1 = new List<Square>() {
                b.GetSquareBySquareNotation("b2"),
                b.GetSquareBySquareNotation("c3"),
                b.GetSquareBySquareNotation("d4"),
                b.GetSquareBySquareNotation("e5"),
                b.GetSquareBySquareNotation("f6"),
                b.GetSquareBySquareNotation("g7"),
                b.GetSquareBySquareNotation("h8")};
            Assert.Equal(a1.NorthEastSquares, assertA1);

            Square a2 = b.GetSquareBySquareNotation("a2");
            List<Square> assertA2 = new List<Square>() {
                b.GetSquareBySquareNotation("b3"),
                b.GetSquareBySquareNotation("c4"),
                b.GetSquareBySquareNotation("d5"),
                b.GetSquareBySquareNotation("e6"),
                b.GetSquareBySquareNotation("f7"),
                b.GetSquareBySquareNotation("g8")};
            Assert.Equal(a2.NorthEastSquares, assertA2);

            Square b1 = b.GetSquareBySquareNotation("b1");
            List<Square> assertB1 = new List<Square>() {
                b.GetSquareBySquareNotation("c2"),
                b.GetSquareBySquareNotation("d3"),
                b.GetSquareBySquareNotation("e4"),
                b.GetSquareBySquareNotation("f5"),
                b.GetSquareBySquareNotation("g6"),
                b.GetSquareBySquareNotation("h7")};
            Assert.Equal(b1.NorthEastSquares, assertB1);

            Square d5 = b.GetSquareBySquareNotation("d5");
            List<Square> assertD5 = new List<Square>() {
                b.GetSquareBySquareNotation("e6"),
                b.GetSquareBySquareNotation("f7"),
                b.GetSquareBySquareNotation("g8")};
            Assert.Equal(d5.NorthEastSquares, assertD5);

            Square a8 = b.GetSquareBySquareNotation("a8");
            Assert.Equal(a8.NorthEastSquares, new List<Square>());
            Square g8 = b.GetSquareBySquareNotation("g8");
            Assert.Equal(g8.NorthEastSquares, new List<Square>());
            Square h8 = b.GetSquareBySquareNotation("h8");
            Assert.Equal(h8.NorthEastSquares, new List<Square>());
            Square h7 = b.GetSquareBySquareNotation("h7");
            Assert.Equal(h7.NorthEastSquares, new List<Square>());
            Square h6 = b.GetSquareBySquareNotation("h6");
            Assert.Equal(h6.NorthEastSquares, new List<Square>());
            Square h5 = b.GetSquareBySquareNotation("h5");
            Assert.Equal(h5.NorthEastSquares, new List<Square>());
            Square h4 = b.GetSquareBySquareNotation("h4");
            Assert.Equal(h4.NorthEastSquares, new List<Square>());
            Square h3 = b.GetSquareBySquareNotation("h3");
            Assert.Equal(h3.NorthEastSquares, new List<Square>());
            Square h2 = b.GetSquareBySquareNotation("h2");
            Assert.Equal(h2.NorthEastSquares, new List<Square>());
            Square h1 = b.GetSquareBySquareNotation("h1");
            Assert.Equal(h1.NorthEastSquares, new List<Square>());
        }

        [Fact()]
        public void SouthEastSquares()
        {
            Board b = new Board();

            Square a8 = b.GetSquareBySquareNotation("a8");
            List<Square> assertA8 = new List<Square>() {
                b.GetSquareBySquareNotation("b7"),
                b.GetSquareBySquareNotation("c6"),
                b.GetSquareBySquareNotation("d5"),
                b.GetSquareBySquareNotation("e4"),
                b.GetSquareBySquareNotation("f3"),
                b.GetSquareBySquareNotation("g2"),
                b.GetSquareBySquareNotation("h1")};
            Assert.Equal(a8.SouthEastSquares, assertA8);

            Square b8 = b.GetSquareBySquareNotation("b8");
            List<Square> assertB8 = new List<Square>() {
                b.GetSquareBySquareNotation("c7"),
                b.GetSquareBySquareNotation("d6"),
                b.GetSquareBySquareNotation("e5"),
                b.GetSquareBySquareNotation("f4"),
                b.GetSquareBySquareNotation("g3"),
                b.GetSquareBySquareNotation("h2")};
            Assert.Equal(b8.SouthEastSquares, assertB8);

            Square a7 = b.GetSquareBySquareNotation("a7");
            List<Square> assertA7 = new List<Square>() {
                b.GetSquareBySquareNotation("b6"),
                b.GetSquareBySquareNotation("c5"),
                b.GetSquareBySquareNotation("d4"),
                b.GetSquareBySquareNotation("e3"),
                b.GetSquareBySquareNotation("f2"),
                b.GetSquareBySquareNotation("g1")};
            Assert.Equal(a7.SouthEastSquares, assertA7);

            Square d5 = b.GetSquareBySquareNotation("d5");
            List<Square> assertD5 = new List<Square>() {
                b.GetSquareBySquareNotation("e4"),
                b.GetSquareBySquareNotation("f3"),
                b.GetSquareBySquareNotation("g2"),
                b.GetSquareBySquareNotation("h1")};
            Assert.Equal(d5.SouthEastSquares, assertD5);

            Square a1 = b.GetSquareBySquareNotation("a1");
            Assert.Equal(a1.SouthEastSquares, new List<Square>());
            Square g1 = b.GetSquareBySquareNotation("g1");
            Assert.Equal(g1.SouthEastSquares, new List<Square>());
            Square h1 = b.GetSquareBySquareNotation("h1");
            Assert.Equal(h1.SouthEastSquares, new List<Square>());
            Square h8 = b.GetSquareBySquareNotation("h8");
            Assert.Equal(h8.SouthEastSquares, new List<Square>());
            Square h7 = b.GetSquareBySquareNotation("h7");
            Assert.Equal(h7.SouthEastSquares, new List<Square>());
        }

        [Fact()]
        public void SouthWestSquares()
        {
            Board b = new Board();

            Square h8 = b.GetSquareBySquareNotation("h8");
            List<Square> assertH8 = new List<Square>() {
                b.GetSquareBySquareNotation("g7"),
                b.GetSquareBySquareNotation("f6"),
                b.GetSquareBySquareNotation("e5"),
                b.GetSquareBySquareNotation("d4"),
                b.GetSquareBySquareNotation("c3"),
                b.GetSquareBySquareNotation("b2"),
                b.GetSquareBySquareNotation("a1")};
            Assert.Equal(h8.SouthWestSquares, assertH8);

            Square g8 = b.GetSquareBySquareNotation("g8");
            List<Square> assertG8 = new List<Square>() {
                b.GetSquareBySquareNotation("f7"),
                b.GetSquareBySquareNotation("e6"),
                b.GetSquareBySquareNotation("d5"),
                b.GetSquareBySquareNotation("c4"),
                b.GetSquareBySquareNotation("b3"),
                b.GetSquareBySquareNotation("a2")};
            Assert.Equal(g8.SouthWestSquares, assertG8);

            Square h7 = b.GetSquareBySquareNotation("h7");
            List<Square> assertH7 = new List<Square>() {
                b.GetSquareBySquareNotation("g6"),
                b.GetSquareBySquareNotation("f5"),
                b.GetSquareBySquareNotation("e4"),
                b.GetSquareBySquareNotation("d3"),
                b.GetSquareBySquareNotation("c2"),
                b.GetSquareBySquareNotation("b1")};
            Assert.Equal(h7.SouthWestSquares, assertH7);

            Square d5 = b.GetSquareBySquareNotation("d5");
            List<Square> assertD5 = new List<Square>() {
                b.GetSquareBySquareNotation("c4"),
                b.GetSquareBySquareNotation("b3"),
                b.GetSquareBySquareNotation("a2")};
            Assert.Equal(d5.SouthWestSquares, assertD5);

            Square a1 = b.GetSquareBySquareNotation("a1");
            Assert.Equal(a1.SouthWestSquares, new List<Square>());
            Square g1 = b.GetSquareBySquareNotation("g1");
            Assert.Equal(g1.SouthWestSquares, new List<Square>());
            Square h1 = b.GetSquareBySquareNotation("h1");
            Assert.Equal(h1.SouthWestSquares, new List<Square>());
            Square a8 = b.GetSquareBySquareNotation("a8");
            Assert.Equal(a8.SouthWestSquares, new List<Square>());
            Square a7 = b.GetSquareBySquareNotation("a7");
            Assert.Equal(a7.SouthWestSquares, new List<Square>());
        }

        [Fact()]
        public void NorthWestSquares()
        {
            Board b = new Board();
            Square h1 = b.GetSquareBySquareNotation("h1");
            List<Square> assertH1 = new List<Square>() {
                b.GetSquareBySquareNotation("g2"),
                b.GetSquareBySquareNotation("f3"),
                b.GetSquareBySquareNotation("e4"),
                b.GetSquareBySquareNotation("d5"),
                b.GetSquareBySquareNotation("c6"),
                b.GetSquareBySquareNotation("b7"),
                b.GetSquareBySquareNotation("a8")};
            Assert.Equal(h1.NorthWestSquares, assertH1);

            Square h2 = b.GetSquareBySquareNotation("h2");
            List<Square> assertH2 = new List<Square>() {
                b.GetSquareBySquareNotation("g3"),
                b.GetSquareBySquareNotation("f4"),
                b.GetSquareBySquareNotation("e5"),
                b.GetSquareBySquareNotation("d6"),
                b.GetSquareBySquareNotation("c7"),
                b.GetSquareBySquareNotation("b8")};
            Assert.Equal(h2.NorthWestSquares, assertH2);

            Square g1 = b.GetSquareBySquareNotation("g1");
            List<Square> assertG1 = new List<Square>() {
                b.GetSquareBySquareNotation("f2"),
                b.GetSquareBySquareNotation("e3"),
                b.GetSquareBySquareNotation("d4"),
                b.GetSquareBySquareNotation("c5"),
                b.GetSquareBySquareNotation("b6"),
                b.GetSquareBySquareNotation("a7")};
            Assert.Equal(g1.NorthWestSquares, assertG1);

            Square d5 = b.GetSquareBySquareNotation("d5");
            List<Square> assertD5 = new List<Square>() {
                b.GetSquareBySquareNotation("c6"),
                b.GetSquareBySquareNotation("b7"),
                b.GetSquareBySquareNotation("a8")};
            Assert.Equal(d5.NorthWestSquares, assertD5);

            Square a8 = b.GetSquareBySquareNotation("a8");
            Assert.Equal(a8.NorthWestSquares, new List<Square>());
            Square g8 = b.GetSquareBySquareNotation("g8");
            Assert.Equal(g8.NorthWestSquares, new List<Square>());
            Square h8 = b.GetSquareBySquareNotation("h8");
            Assert.Equal(h8.NorthWestSquares, new List<Square>());
            Square a7 = b.GetSquareBySquareNotation("a7");
            Assert.Equal(a7.NorthWestSquares, new List<Square>());
            Square a6 = b.GetSquareBySquareNotation("a6");
            Assert.Equal(a6.NorthWestSquares, new List<Square>());
            Square a5 = b.GetSquareBySquareNotation("a5");
            Assert.Equal(a5.NorthWestSquares, new List<Square>());
            Square a4 = b.GetSquareBySquareNotation("a4");
            Assert.Equal(a4.NorthWestSquares, new List<Square>());
            Square a3 = b.GetSquareBySquareNotation("a3");
            Assert.Equal(a3.NorthWestSquares, new List<Square>());
            Square a2 = b.GetSquareBySquareNotation("a2");
            Assert.Equal(a2.NorthWestSquares, new List<Square>());
            Square a1 = b.GetSquareBySquareNotation("a1");
            Assert.Equal(a1.NorthWestSquares, new List<Square>());
        }
    }

}
