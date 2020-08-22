using Racheschach.Notation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet
{
    public class Board
    {
        public Square[,] Squares { get; set; }
        public Stack<IMove> Moves { get; set; }
        public IMove LastMove { get; private set; }

        public Color ActiveColor => GetActiveColor();

        public bool WhiteCanCastleKingside => true; // Moves.Peek().WhiteCanCastleKingside;
        public bool WhiteCanCastleQueenside => true; // Moves.Peek().WhiteCanCastleQueenside;
        public bool BlackCanCastleKingside => true; // Moves.Peek().BlackCanCastleKingside;
        public bool BlackCanCastleQueenside => true; // Moves.Peek().BlackCanCastleQueenside;

        /// <summary>
        /// is null or a possible en Passant field (in the last draw an enemy pawn went two steps from starting position)
        /// </summary>
        public Square EnPassant => LastMove.EnPassant;

        /// <summary>
        /// Number of moves without movement of any pawn and without any capture (needed for 50-move rule)
        /// </summary>
        public int Halfmoves => LastMove.HalfMoves;

        /// <summary>
        /// Number of moves. Incremented after every black move
        /// </summary>
        public int Fullmoves => ((Moves.Count - 1) / 2) + 1;

        public Square[][] Rows => GetRows();
        public Square[][] Columns => GetColumns();


        public Board()
        {
            Squares = new Square[8, 8];

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Squares[x, y] = new Square(x, y, this);
                }
            }

            SetNeighborSquares();
            Moves = new Stack<IMove>();
            Moves.Push(new InitialMove());
            LastMove = Moves.Peek();
        }

        public void PlayMove(IMove move)
        {
            Moves.Push(move);
            move.To.SetPiece(move.ColorPiece);
            move.From.SetPiece();
            LastMove = Moves.Peek();
        }

        public Move GetNewMove(Square from, Square to)
        {
            var move = new Move(from, to);
            return move;
        }

        public Move GetNewMove(string from, string to)
        {
            return GetNewMove(GetSquareBySquareNotation(from), GetSquareBySquareNotation(to));
        }

        public Square[] GetRowByIndex(int i)
        {
            return new Square[] { Squares[0, i], Squares[1, i], Squares[2, i], Squares[3, i], Squares[4, i], Squares[5, i], Squares[6, i], Squares[7, i] };
        }

        public Square[] GetColumnByIndex(int i)
        {
            return new Square[] { Squares[i, 0], Squares[i, 1], Squares[i, 2], Squares[i, 3], Squares[i, 4], Squares[i, 5], Squares[i, 6], Squares[i, 7] };
        }

        public Square[] GetRowOrColumn(char name)
        {
            if (NotationHelpers.IsValidRowName(name))
                return GetRowByIndex(BoardHelpers.RowNameToIndex(name));

            else if (NotationHelpers.IsValidColumnName(name))
                return GetColumnByIndex(BoardHelpers.ColumnNameToIndex(name));

            else throw new ArgumentOutOfRangeException();
        }

        public Square GetSquareBySquareNotation(string notation)
        {
            var coords = BoardHelpers.ArrayIndexBySquareNotation(notation);
            return Squares[coords.x, coords.y];
        }

        private Square[][] GetColumns()
        {
            var columns = new Square[8][];

            for (int x = 0; x < 8; x++)
            {
                columns[x] = GetColumnByIndex(x);
            }

            return columns;
        }

        private Square[][] GetRows()
        {
            var rows = new Square[8][];

            for (int y = 0; y < 8; y++)
            {
                rows[y] = GetRowByIndex(y);
            }

            return rows;
        }

        private Color GetActiveColor()
        {
            if (Moves.Count > 0) return LastMove.Color.Opposite();
            else return Color.White;
        }

        public void SetupGame()
        {
            SetupPawns(Color.White);
            SetupPawns(Color.Black);
            SetupPieces(Color.White);
            SetupPieces(Color.Black);
        }



        private void SetupPawns(Color color)
        {
            int rowIndex;

            if (color == Color.White) rowIndex = 1;
            else if (color == Color.Black) rowIndex = 6;
            else throw new ArgumentOutOfRangeException();

            for (int x = 0; x < 8; x++)
            {
                Squares[x, rowIndex].Piece.ColorPiece = new ColorPiece(PieceType.Pawn, color);
            }
        }

        private void SetupPieces(Color color)
        {
            PieceType[] piecePattern = new PieceType[]
            {
                PieceType.Rook,
                PieceType.Knight,
                PieceType.Bishop,
                PieceType.Queen,
                PieceType.King,
                PieceType.Bishop,
                PieceType.Knight,
                PieceType.Rook
            };

            int rowIndex;

            if (color == Color.White) rowIndex = 0;
            else if (color == Color.Black) rowIndex = 7;
            else throw new ArgumentOutOfRangeException();

            for (int i = 0; i < piecePattern.Length; i++)
            {
                Squares[i, rowIndex].Piece.ColorPiece = new ColorPiece(piecePattern[i], color);
            }

        }

        private void SetNeighborSquares()
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    //North
                    try
                    {
                        Squares[x, y].North = Squares[x, y + 1];
                        Squares[x, y].Neighbors.Add(Squares[x, y].North);
                    }
                    catch (IndexOutOfRangeException) { };

                    //NorthEast
                    try
                    {
                        Squares[x, y].NorthEast = Squares[x + 1, y + 1];
                        Squares[x, y].Neighbors.Add(Squares[x, y].NorthEast);
                    }
                    catch (IndexOutOfRangeException) { };

                    //East
                    try
                    {
                        Squares[x, y].East = Squares[x + 1, y];
                        Squares[x, y].Neighbors.Add(Squares[x, y].East);
                    }
                    catch (IndexOutOfRangeException) { };

                    //SouthEast
                    try
                    {
                        Squares[x, y].SouthEast = Squares[x + 1, y - 1];
                        Squares[x, y].Neighbors.Add(Squares[x, y].SouthEast);
                    }
                    catch (IndexOutOfRangeException) { };

                    //South
                    try
                    {
                        Squares[x, y].South = Squares[x, y - 1];
                        Squares[x, y].Neighbors.Add(Squares[x, y].South);
                    }
                    catch (IndexOutOfRangeException) { };

                    //SouthWest
                    try
                    {
                        Squares[x, y].SouthWest = Squares[x - 1, y - 1];
                        Squares[x, y].Neighbors.Add(Squares[x, y].SouthWest);
                    }
                    catch (IndexOutOfRangeException) { };

                    //West
                    try
                    {
                        Squares[x, y].West = Squares[x - 1, y];
                        Squares[x, y].Neighbors.Add(Squares[x, y].West);
                    }
                    catch (IndexOutOfRangeException) { };

                    //NorthWest
                    try
                    {
                        Squares[x, y].NorthWest = Squares[x - 1, y + 1];
                        Squares[x, y].Neighbors.Add(Squares[x, y].NorthWest);
                    }
                    catch (IndexOutOfRangeException) { };
                }
            }

        }
    }

}
