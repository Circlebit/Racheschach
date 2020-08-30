using System;
using System.Linq;
using Racheschach.ChessSet;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            var b = new Board();
            b.SetupGame();

            PrintBoard(b);
        }

        private static void PrintBoard(Board board, bool blackPerspective = false)
        {
            bool nextSquareBlack = false;

            string columnNames = blackPerspective ? "    h  g  f  e  d  c  b  a\n" : "    a  b  c  d  e  f  g  h\n";

            Console.Write(columnNames);

            foreach (Square[] row in blackPerspective ? board.Rows : board.Rows.Reverse<Square[]>())
            {
                Console.Write($" {row[0].RowName} ");
                nextSquareBlack = !nextSquareBlack;
                foreach (Square square in blackPerspective ? row.Reverse<Square>() : row)
                {
                    nextSquareBlack = !nextSquareBlack;
                    Console.BackgroundColor = nextSquareBlack ? ConsoleColor.DarkBlue : ConsoleColor.DarkGray;
                    Console.ForegroundColor = square.Piece.Color == Color.Black ? ConsoleColor.Black : ConsoleColor.White;
                    Console.Write($" {square.Piece.UniCode} ");
                    Console.ResetColor();
                }
                Console.Write($" {row[0].RowName} \n");
            }
            Console.Write(columnNames);

        }
    }
}
