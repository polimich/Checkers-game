using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers_game.Models
{
    public class Piece
    {
        public bool Color { get; set; } // true - black, false - red
        public bool IsKing { get; set; } // true - King, false- normal piece

        public Piece(bool color)
        {
            Color = color;
            IsKing = false;
        }
    }
    
}
