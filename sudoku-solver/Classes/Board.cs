using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc_Sudoku_Solver_.Classes
{
    protected class Board
    {
        #region private members
        private Region[] regions;
        #endregion

        #region Properties
        protected Region[] Regions
        {
            get { return this.regions; }
            set { this.regions = value; }
        }
        #endregion

        protected Board()
        {

        }
    }
}
