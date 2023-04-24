using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessOnPhoneBoard
{
    public interface IChessPiece
    {
        Coordinate Location { get; set;  }
        IPieceMover PieceMover { get;  set; }
    }
}
