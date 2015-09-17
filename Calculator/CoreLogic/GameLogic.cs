using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StupidMonkey.Material;
using StupidMonkey.Material.Map;

namespace StupidMonkey.CoreLogic
{
    public class GameLogic
    {
        #region gameLogicStatus
        public enum gameLogicStatus
        {
            Noexist=0,
            Initializing=10,
            Running=20,
            Pause=30,
            Finalizing=40
        }

        public gameLogicStatus Status
        {
            get { return status; }
            set { /*status = value; */}
        }
        private gameLogicStatus status = gameLogicStatus.Noexist;

        #endregion
        
        /// <summary>
        /// 临时显示接口 一个string
        /// </summary>
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

            RootNodeEntity rne;
            var bf=new Block.BlockFactory();
            bf.Make(new String[1]);
            bf.Make(new String[1]);


            var mth = new System.Threading.Thread(mainloop);
            mth.Start();
        }
        public static void initialize()
        {

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
