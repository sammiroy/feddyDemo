using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Diagnostics;

namespace feddyDemo
{
    public class RNG
    {
        // Global System Roll Object

        #region Fields & Constructor
        private int SysRandInt;

        public RNG()
        {
            SysRandInt = roll(21);
        }
        #endregion

        // Methods

        #region Methods 
        public static int roll(int hi)
        {
            int rVal;
            Random r = new Random();
            rVal = r.Next(1, hi);
            return rVal;
        }

        public int returnRoll()
        {
            return this.SysRandInt;
        }

        public void reroll()
        {
            this.SysRandInt = roll(21);
        }
        #endregion
    }
}
