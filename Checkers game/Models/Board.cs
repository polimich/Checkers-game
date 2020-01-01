using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers_game.Models
{
    public class Board
    {
        [Key]
        public int Id { get; set; }
        public const int Lenght = 8;
        public const int Width = 8;
        public Piece[,] Storage = new Piece[Lenght, Width]; //null - empty, 1 - normal piece, 2 - king
        public Board()
        {
            Storage[0, 0] = new Piece(false);
            Storage[2, 0] = new Piece(false);
            Storage[4, 0] = new Piece(false);
            Storage[6, 0] = new Piece(false);
            Storage[1, 1] = new Piece(false);
            Storage[3, 1] = new Piece(false);
            Storage[5, 1] = new Piece(false);
            Storage[7, 1] = new Piece(false);
            Storage[0, 2] = new Piece(false);
            Storage[2, 2] = new Piece(false);
            Storage[4, 2] = new Piece(false);
            Storage[6, 2] = new Piece(false);
            Storage[1, 7] = new Piece(true);
            Storage[3, 7] = new Piece(true);
            Storage[5, 7] = new Piece(true);
            Storage[7, 7] = new Piece(true);
            Storage[0, 6] = new Piece(true);
            Storage[2, 6] = new Piece(true);
            Storage[4, 6] = new Piece(true);
            Storage[6, 6] = new Piece(true);
            Storage[1, 5] = new Piece(true);
            Storage[3, 5] = new Piece(true);
            Storage[5, 5] = new Piece(true);
            Storage[7, 5] = new Piece(true);
        }
    
        
        public void CheckJump (Board board)
        { }
    }
}
