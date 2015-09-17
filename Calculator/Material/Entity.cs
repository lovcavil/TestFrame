﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StupidMonkey.Material.Structure;


namespace StupidMonkey.Material
{
    class Entity
    {
        public float mass=0;
        public float velocity=0;
        public Material material=new Material();
        public Structure.Structure structure=new Structure.Structure();



        public void Update()
        {
            while (structure.content != null)
            {
                foreach (Entity entity in structure.content)
                {
                    entity.Update();
                }
            }
            SelfUpdate();
        }

        private void SelfUpdate()
        {
            ;
        }
    }
}
