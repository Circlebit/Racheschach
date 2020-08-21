using Xunit;
using Racheschach.ChessSet;
using System.Linq;

namespace Racheschach.Notation.Tests
{
    public class FENTests
    {
        [Fact()]
        public void FENByBoardFreshlySetupTest()
        {
            var b = new Board();
            b.SetupGame();
            var fen = new FEN(b);

            Assert.Equal("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1", fen.String);
        }

        [Fact()]
        public void FENByBoardSomePiecesRemovedTest()
        {
            //TODO: ersetzen durch Tests mit moves
            var b = new Board();
            b.SetupGame();

            // remove black knights
            b.GetSquareBySquareNotation("b8").SetPiece();
            b.GetSquareBySquareNotation("g8").SetPiece();

            // remove first and last black pawn
            b.GetSquareBySquareNotation("a7").SetPiece();
            b.GetSquareBySquareNotation("h7").SetPiece();

            // remove all white pawns except the outer ones
            b.GetSquareBySquareNotation("b2").SetPiece();
            b.GetSquareBySquareNotation("c2").SetPiece();
            b.GetSquareBySquareNotation("d2").SetPiece();
            b.GetSquareBySquareNotation("e2").SetPiece();
            b.GetSquareBySquareNotation("f2").SetPiece();
            b.GetSquareBySquareNotation("g2").SetPiece();

            //// remove all white pieces other than king and queen
            b.GetSquareBySquareNotation("a1").SetPiece();
            b.GetSquareBySquareNotation("b1").SetPiece();
            b.GetSquareBySquareNotation("c1").SetPiece();
            b.GetSquareBySquareNotation("f1").SetPiece();
            b.GetSquareBySquareNotation("g1").SetPiece();
            b.GetSquareBySquareNotation("h1").SetPiece();

            var fen = new FEN(b);

            Assert.Equal("r1bqkb1r/1pppppp1/8/8/8/8/P6P/3QK3 w KQkq - 0 1", fen.String);

            var fen2 = new FEN(fen.String);
            var fen3 = new FEN(fen2.Board);

            Assert.Equal("r1bqkb1r/1pppppp1/8/8/8/8/P6P/3QK3 w KQkq - 0 1", fen3.String);
        }


        [Fact()]
        public void BoardByFENFreshlySetupTest()
        {
            var fen = new FEN("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1");

            Assert.Equal("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1", fen.String);

            Assert.Equal(PieceType.Pawn, fen.Board.GetSquareBySquareNotation("a2").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, fen.Board.GetSquareBySquareNotation("b2").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, fen.Board.GetSquareBySquareNotation("c2").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, fen.Board.GetSquareBySquareNotation("d2").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, fen.Board.GetSquareBySquareNotation("e2").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, fen.Board.GetSquareBySquareNotation("f2").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, fen.Board.GetSquareBySquareNotation("g2").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, fen.Board.GetSquareBySquareNotation("h2").Piece.PieceType);
            Assert.Equal(Color.White, fen.Board.GetSquareBySquareNotation("a2").Piece.Color);
            Assert.Equal(Color.White, fen.Board.GetSquareBySquareNotation("b2").Piece.Color);
            Assert.Equal(Color.White, fen.Board.GetSquareBySquareNotation("c2").Piece.Color);
            Assert.Equal(Color.White, fen.Board.GetSquareBySquareNotation("d2").Piece.Color);
            Assert.Equal(Color.White, fen.Board.GetSquareBySquareNotation("e2").Piece.Color);
            Assert.Equal(Color.White, fen.Board.GetSquareBySquareNotation("f2").Piece.Color);
            Assert.Equal(Color.White, fen.Board.GetSquareBySquareNotation("g2").Piece.Color);
            Assert.Equal(Color.White, fen.Board.GetSquareBySquareNotation("h2").Piece.Color);

            Assert.Equal(PieceType.Rook, fen.Board.GetSquareBySquareNotation("a1").Piece.PieceType);
            Assert.Equal(PieceType.Knight, fen.Board.GetSquareBySquareNotation("b1").Piece.PieceType);
            Assert.Equal(PieceType.Bishop, fen.Board.GetSquareBySquareNotation("c1").Piece.PieceType);
            Assert.Equal(PieceType.Queen, fen.Board.GetSquareBySquareNotation("d1").Piece.PieceType);
            Assert.Equal(PieceType.King, fen.Board.GetSquareBySquareNotation("e1").Piece.PieceType);
            Assert.Equal(PieceType.Bishop, fen.Board.GetSquareBySquareNotation("f1").Piece.PieceType);
            Assert.Equal(PieceType.Knight, fen.Board.GetSquareBySquareNotation("g1").Piece.PieceType);
            Assert.Equal(PieceType.Rook, fen.Board.GetSquareBySquareNotation("h1").Piece.PieceType);
            Assert.Equal(Color.White, fen.Board.GetSquareBySquareNotation("a1").Piece.Color);
            Assert.Equal(Color.White, fen.Board.GetSquareBySquareNotation("b1").Piece.Color);
            Assert.Equal(Color.White, fen.Board.GetSquareBySquareNotation("c1").Piece.Color);
            Assert.Equal(Color.White, fen.Board.GetSquareBySquareNotation("d1").Piece.Color);
            Assert.Equal(Color.White, fen.Board.GetSquareBySquareNotation("e1").Piece.Color);
            Assert.Equal(Color.White, fen.Board.GetSquareBySquareNotation("f1").Piece.Color);
            Assert.Equal(Color.White, fen.Board.GetSquareBySquareNotation("g1").Piece.Color);
            Assert.Equal(Color.White, fen.Board.GetSquareBySquareNotation("h1").Piece.Color);

            Assert.Equal(PieceType.Pawn, fen.Board.GetSquareBySquareNotation("a7").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, fen.Board.GetSquareBySquareNotation("b7").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, fen.Board.GetSquareBySquareNotation("c7").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, fen.Board.GetSquareBySquareNotation("d7").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, fen.Board.GetSquareBySquareNotation("e7").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, fen.Board.GetSquareBySquareNotation("f7").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, fen.Board.GetSquareBySquareNotation("g7").Piece.PieceType);
            Assert.Equal(PieceType.Pawn, fen.Board.GetSquareBySquareNotation("h7").Piece.PieceType);
            Assert.Equal(Color.Black, fen.Board.GetSquareBySquareNotation("a7").Piece.Color);
            Assert.Equal(Color.Black, fen.Board.GetSquareBySquareNotation("b7").Piece.Color);
            Assert.Equal(Color.Black, fen.Board.GetSquareBySquareNotation("c7").Piece.Color);
            Assert.Equal(Color.Black, fen.Board.GetSquareBySquareNotation("d7").Piece.Color);
            Assert.Equal(Color.Black, fen.Board.GetSquareBySquareNotation("e7").Piece.Color);
            Assert.Equal(Color.Black, fen.Board.GetSquareBySquareNotation("f7").Piece.Color);
            Assert.Equal(Color.Black, fen.Board.GetSquareBySquareNotation("g7").Piece.Color);
            Assert.Equal(Color.Black, fen.Board.GetSquareBySquareNotation("h7").Piece.Color);

            Assert.Equal(PieceType.Rook, fen.Board.GetSquareBySquareNotation("a8").Piece.PieceType);
            Assert.Equal(PieceType.Knight, fen.Board.GetSquareBySquareNotation("b8").Piece.PieceType);
            Assert.Equal(PieceType.Bishop, fen.Board.GetSquareBySquareNotation("c8").Piece.PieceType);
            Assert.Equal(PieceType.Queen, fen.Board.GetSquareBySquareNotation("d8").Piece.PieceType);
            Assert.Equal(PieceType.King, fen.Board.GetSquareBySquareNotation("e8").Piece.PieceType);
            Assert.Equal(PieceType.Bishop, fen.Board.GetSquareBySquareNotation("f8").Piece.PieceType);
            Assert.Equal(PieceType.Knight, fen.Board.GetSquareBySquareNotation("g8").Piece.PieceType);
            Assert.Equal(PieceType.Rook, fen.Board.GetSquareBySquareNotation("h8").Piece.PieceType);
            Assert.Equal(Color.Black, fen.Board.GetSquareBySquareNotation("a8").Piece.Color);
            Assert.Equal(Color.Black, fen.Board.GetSquareBySquareNotation("b8").Piece.Color);
            Assert.Equal(Color.Black, fen.Board.GetSquareBySquareNotation("c8").Piece.Color);
            Assert.Equal(Color.Black, fen.Board.GetSquareBySquareNotation("d8").Piece.Color);
            Assert.Equal(Color.Black, fen.Board.GetSquareBySquareNotation("e8").Piece.Color);
            Assert.Equal(Color.Black, fen.Board.GetSquareBySquareNotation("f8").Piece.Color);
            Assert.Equal(Color.Black, fen.Board.GetSquareBySquareNotation("g8").Piece.Color);
            Assert.Equal(Color.Black, fen.Board.GetSquareBySquareNotation("h8").Piece.Color);


            var row3 = fen.Board.GetRowOrColumn('3');
            var row4 = fen.Board.GetRowOrColumn('4');
            var row5 = fen.Board.GetRowOrColumn('5');
            var row6 = fen.Board.GetRowOrColumn('6');

            for (int x = 0; x < 8; x++)
            {
                Assert.Equal(PieceType.None, row3[x].Piece.PieceType);
                Assert.Equal(PieceType.None, row4[x].Piece.PieceType);
                Assert.Equal(PieceType.None, row5[x].Piece.PieceType);
                Assert.Equal(PieceType.None, row6[x].Piece.PieceType);
            }
        }

        [Fact()]
        public void ParseRowSquaresFreshlySetupTest()
        {
            var b = new Board();
            b.SetupGame();
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
            //TODO: ersetzen durch Tests mit moves
            var b = new Board();
            b.SetupGame();
            var fen = new FEN(b);

            // remove black knights
            b.GetSquareBySquareNotation("b8").Piece.ColorPiece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("g8").Piece.ColorPiece.PieceType = PieceType.None;

            // remove first and last black pawn
            b.GetSquareBySquareNotation("a7").Piece.ColorPiece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("h7").Piece.ColorPiece.PieceType = PieceType.None;

            // remove all white pawns except the outer ones
            b.GetSquareBySquareNotation("b2").Piece.ColorPiece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("c2").Piece.ColorPiece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("d2").Piece.ColorPiece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("e2").Piece.ColorPiece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("f2").Piece.ColorPiece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("g2").Piece.ColorPiece.PieceType = PieceType.None;

            //// remove all white pieces other than king and queen
            b.GetSquareBySquareNotation("a1").Piece.ColorPiece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("b1").Piece.ColorPiece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("c1").Piece.ColorPiece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("f1").Piece.ColorPiece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("g1").Piece.ColorPiece.PieceType = PieceType.None;
            b.GetSquareBySquareNotation("h1").Piece.ColorPiece.PieceType = PieceType.None;

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