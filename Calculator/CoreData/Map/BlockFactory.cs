using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StupidMonkey.CoreLogic;

namespace StupidMonkey.CoreData.Map
{
    /// <summary>
    /// block工厂 未并行，可能需要
    /// </summary>
    class BlockFactory : Factory<Block>
    {
        public List<Block> Lib = new List<Block>();

        /// <summary>
        /// 构建block数据，再加入block表
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Block Make(String[] data)
        {
           
            Block result=new Block();
            for (int i = 1; i < Block.Length; i++)
            {
                for (int j = 1; j < Block.Width; j++)
                {
                    result.Inner[i, j].AdjacentLocations[0] = result.Inner[i, j - 1];
                    result.Inner[i, j].AdjacentLocations[1] = result.Inner[i + 1, j];
                    result.Inner[i, j].AdjacentLocations[2] = result.Inner[i, j + 1];
                    result.Inner[i, j].AdjacentLocations[3] = result.Inner[i - 1, j];
                }
            }
           

            Lib.Add(result);
            return result;
        }
    }
}
