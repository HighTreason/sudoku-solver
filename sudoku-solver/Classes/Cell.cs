using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc_Sudoku_Solver_.Classes
{
    protected class Cell
    {
        #region private members
        private int value;
        private Position position;
        private bool locked;
        #endregion

        #region properties
        protected Position Position
        {
            get { return this.position; }
        }
        protected int Value
        {
            get {return this.value;}
            set { this.value = this.Locked ? this.value : value; }
        }

        protected bool Locked 
        {
            get { return this.locked; }
            set { this.locked = value; }
        }
        #endregion

        protected Cell(Position position)
        {
            this.position.Row = position.Row;
            this.position.Column = position.Column;
        }
    }
}
