﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessSFML
{
    public class King : PieceBase
    {
        public override int SpriteID => 5;
        public King(PieceColor color) : base(color)
        {
            MoveVertical = true;
            MoveHorizontal = true;
            MoveDiagonal = true;
            MoveCap = 1;
        }
    }
}
