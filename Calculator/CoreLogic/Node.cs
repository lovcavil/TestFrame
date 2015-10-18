using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidMonkey.CoreLogic
{
    /// <summary>
    /// 预计拿来处理保存update initial的功能
    /// 
    /// </summary>
    class Node
    {
        int id;
        INodetype nt;
        public void Update()
        {
            nt.Update();
        }
    }
    interface INodetype
    {
         void Update();
    }
}
