﻿using Racheschach.Notation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Racheschach.ChessSet
{
    public class Piece
    {
        public Color Color { get; set; }
        public Color EnemyColor => GameHelpers.GetOppositeColor(Color);

        public PieceType PieceType { get; set; }
        public Char UniCode => NotationHelpers.GetUniCodeForPiece(Color, PieceType);
        public Square Square { get; set; }

        public Piece(Color color, PieceType pieceType, Square square)
        {
            Color = color;
            PieceType = pieceType;
            Square = square;
        }

        public List<Move> GetPossibleMoves()
        {
            switch (PieceType)
            {
                case PieceType.None: throw new NotImplementedException();
                case PieceType.King: throw new NotImplementedException();
                case PieceType.Queen: throw new NotImplementedException();
                case PieceType.Rook: return GetPossibleMovesForRook();
                case PieceType.Bishop: throw new NotImplementedException();
                case PieceType.Knight: throw new NotImplementedException();
                case PieceType.Pawn: throw new NotImplementedException();
                default: throw new Exception();
            }
        }

        private List<Move> GetPossibleMovesForRook()
        {
            List<Move> moves = new List<Move>();
            Square nextSquare;

            //Moves towards North
            nextSquare = this.Square.NorthNeighbor;
            while(nextSquare != null)
            {
                // friendly piece on nextSquare -> can't go there
                if (nextSquare.IsFriendlyPiece(this.Color)) break;

                moves.Add(new Move(this.Square, nextSquare));

                // enemy piece of nextSquare -> can't go beyond
                if (nextSquare.IsEnemyPiece(this.Color)) break;
            }

            return moves;
        }
    }
}
