using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidMonkey.Material.Map
{
    class Block:Karo<Block>
    {
        public const short Length=100;
        public const short Width = 100;
        public const int Area = Length * Width;

        /// <summary>
        /// 是否需要公开 尝试私有化
        /// </summary>
        public Location[,] Inner = new Location[Length, Width];
    }


}
