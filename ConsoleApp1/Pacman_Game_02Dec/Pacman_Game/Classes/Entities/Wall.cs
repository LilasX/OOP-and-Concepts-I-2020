﻿using Pacman_Game.Classes.Pathfinding;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes.Entities
{
    public class Wall:Tile
    {
        public Wall(int row, int column) :base(row, column) 
        {
            base.Entity_Color = Color.DarkSlateBlue;
        }
        
    }
}
