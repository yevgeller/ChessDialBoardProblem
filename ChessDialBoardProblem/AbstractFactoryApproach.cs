using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryApproach
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            var candidate = (Coordinate)obj;
            return candidate.X == X && candidate.Y == Y;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public enum PieceType
    {
        Pawn,
        Rook
    }
    public interface IPiece
    {
        PieceType PieceType { get; }
    }

    public interface IBoard
    {
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        List<Coordinate> ForbiddenSpots { get; set; }
    }

    public interface IMover
    {
        bool CanMove();
        List<Coordinate> NextMoves();
    }
    interface IChessPieceAndBoardFactory
    {
        IPiece Piece { get; }
        IBoard Board { get; }
        IMover Mover { get; }
    }//Mover needs to take a board as a constructor
    public class PawnImplementation : IChessPieceAndBoardFactory
    {        
        public PawnImplementation(IPiece piece, IBoard board, IMover mover)
        {
            this.Piece = piece;
            this.Board = board;
            this.Mover = new PawnMover(board);
        }

        public IPiece Piece { get; }
        public IBoard Board { get; }
        public IMover Mover { get; }
    }

    public class PawnMover : IMover
    {
        public PawnMover(IBoard board)
        {
            this.Board = board;   
        }

        public IBoard Board { get; }

        public bool CanMove()
        {
            throw new NotImplementedException();
        }

        public List<Coordinate> NextMoves()
        {
            throw new NotImplementedException();
        }
    }
}
