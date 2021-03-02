﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku_Demo
{
    class blackPiece : Piece
    {
        public blackPiece(int x,int y) : base(x, y)
        {
            this.Image = Properties.Resources.black;
        }

        public override PieceType GetPieceType()
        {
            return PieceType.BLACK;
        }
    }
}
