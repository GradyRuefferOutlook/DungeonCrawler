﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Player
    {
        public int x, y, z;
        public int height;
        public Player(int x, int y, int z, int height)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.height = height;
        }
    }
}
