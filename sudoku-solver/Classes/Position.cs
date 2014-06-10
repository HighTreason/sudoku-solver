using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc_Sudoku_Solver_.Classes
{
    public struct Position
    {
        #region private members
        private int row;
        private int column;
        #endregion

        #region Members;
        public int Row
        {
            get { return this.row; }
        }
        public int Column 
        {
            get { return this.column; }
        }
        #endregion

        public Position(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public override string ToString()
        {
            return "[row: '" + this.Row + " column: '" + this.column + "']";
        }
    }
}
