using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidMonkey.CoreLogic
{
    /// <summary>
    /// 预计拿来处理保存update initial的功能
    /// child manage
    /// </summary>
    class Node
    {
        static int id_count=0;
        int id;
        INodetype nt;
        public void Update()
        {
            nt.Update();
        }
        public void Initialize<T>() where T : INodetype, new()
        {
            id = ++id_count;
            nt = new T(); 
        }
    }

    interface INodetype
    {
        string Name { get; set; }
        void Update();
    }
}
