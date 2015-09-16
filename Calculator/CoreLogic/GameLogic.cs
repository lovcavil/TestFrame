using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StupidMonkey.Material.Map;

namespace CoreLogic
{
    public class GameLogic
    {
        #region gameLogicStatus
        public enum gameLogicStatus
        {
            Noexist=0,
            Initializing=10,
            Running=20,
            Finalizing=30
        }

        public gameLogicStatus Status
        {
            get { return status; }
            set { /*status = value; */}
        }
        private gameLogicStatus status = gameLogicStatus.Noexist;

        #endregion

        StupidMonkey.CalculatorViewModel vm;
        public GameLogic(StupidMonkey.CalculatorViewModel vm)
        {
            this.vm = vm;
        }
        public void run()
        {
 
            CoreTimer.Start();
            var log= new Log();
            log.Start(vm);
            var bf=new Block.BlockFactory();
            bf.Make(new String[1]);
            bf.Make(new String[1]);
            var mth = new System.Threading.Thread(mainloop);

            mth.Start();
        }

        public static void mainloop()
        {

        }


    }

    public class Log
    {
        StupidMonkey.CalculatorViewModel vm;
        int count = 0;
        string data;
        public void Start(StupidMonkey.CalculatorViewModel vm)
        {
            this.vm = vm;
            CoreTimer.NewTickTime += this.Update;
            
        }
        public void Update(object sender, TimeEventArgs e)
        {
            data +=( count++.ToString()+" ");
            vm.Status = data;

        }
    }
}
