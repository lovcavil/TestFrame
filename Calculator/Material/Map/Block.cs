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
        /// 是否需要公开 尝试私有化 第一与最后放空
        /// </summary>
        public Location[,] Inner = new Location[Length+1, Width+1];

        public Block()
        {
            for(int i = 0; i<Length+1; i++)
            {
                for (int j = 0; j < Width+1;j++)
                {
                    Inner[i, j] = new Location();
                }
            }
        }
    }


}
