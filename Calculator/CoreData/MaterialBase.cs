using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidMonkey.CoreData
{ 

    class Material
    {

        String name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        float density;

        public float Density
        {
            get { return density; }
            set { density = value; }
        }

        State state;

    }

    class Element
    {

    }
}
