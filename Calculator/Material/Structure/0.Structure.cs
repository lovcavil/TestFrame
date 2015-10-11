using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidMonkey.Material.Structure
{
    class Structure
    {
        /// <summary>
        /// should be never used 
        /// </summary>
        private static string name = "baseStructure";
        public Entity[] content;

        public static string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }


    }
}
