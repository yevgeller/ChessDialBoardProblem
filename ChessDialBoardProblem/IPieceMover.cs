using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessOnPhoneBoard
{
    public interface IPieceMover
    {
        bool CanMove();
        List<Coordinate> NextMoves();
        IBoard Board { get; set; }
    }
}
