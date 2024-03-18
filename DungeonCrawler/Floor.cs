using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Floor
    {
        public int x, z, length, width;
        public Floor(int x, int z, int length, int width)
        {
            this.x = x;
            this.z = z;
            this.length = length;
            this.width = width;
        }
    }
}
