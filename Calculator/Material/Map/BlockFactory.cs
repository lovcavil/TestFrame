using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StupidMonkey.CoreLogic;

namespace StupidMonkey.Material.Map
{
    class BlockFactory : Factory<Block>
    {
        List<Block> Lib=new List<Block>();
        public Block Make(String[] data)
        {
            Block result=new Block();
            foreach (Location loc in result.Inner)
            {
                loc.Adjacent[0] = result.Inner[0,0];
            }
            Lib.Add(result);
            return result;
        }
    }
}
