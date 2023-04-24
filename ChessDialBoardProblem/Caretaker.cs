using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessOnPhoneBoard
{
    public class Caretaker
    {
        private IBoard board;
        private IChessPiece chessPiece;

        public Caretaker(IBoard board, IChessPiece chessPiece)
        {
            this.board = board;
            this.chessPiece = chessPiece;
        }
    }
}
