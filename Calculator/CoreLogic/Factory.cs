using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidMonkey.CoreLogic
{
    abstract class Factory<T>
    {
        T Make(String[] data);
    }
}
