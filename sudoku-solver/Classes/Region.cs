using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc_Sudoku_Solver_.Classes
{
    protected class Region
    {
        #region private members
        private Position position;
        private Cell[] cells;
        #endregion

        #region properties
        protected Position Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        protected Cell[] Cells
        {
            get { return this.cells; }
            set { this.cells = value; }
        }
        #endregion

        protected Region(Position position)
        {
            this.position.Row = position.Row;
            this.position.Column = position.Column;
        }
    }
}
