using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidMonkey.Material
{ 
    public enum States
    {
        Solid=100,
        Liquid=200,
        Gas=300
    }
    class MaterialBase
    {

        String name;

        public String Name
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
        States state;

        public States State
        {
            get { return state; }
            set { /*state = value;*/ }
        }
    }

    class Element
    {

    }
}
