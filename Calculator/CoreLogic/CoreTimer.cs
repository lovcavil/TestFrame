﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic
{
    public class TimeEventArgs:EventArgs
    {
        public TimeEventArgs()
        { }
    }
    static class CoreTimer
    {

        public static event EventHandler<TimeEventArgs> NewTickTime;
        static void NewTick(object o)
        {
            RaiseNewTick();
        }
        private static System.Threading.Timer t; 
        public static void Start()
        {
             t = new System.Threading.Timer(NewTick, null, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
        }

        private static void RaiseNewTick()
        {
            var newTickTime = NewTickTime;
            if(NewTickTime!=null)
            {
                newTickTime(null, new TimeEventArgs());
            }
        }


    }


}