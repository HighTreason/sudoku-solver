using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc_Sudoku_Solver_.Classes
{
    public class Cell
    {
        #region private members
        private int value;
        private Position position;
        private bool locked;
        private SudokuRegion region;
        #endregion

        #region properties
        public Position Position
        {
            get { return this.position; }
        }
        public int Value
        {
            get {return this.value;}
            set { this.value = this.Locked ? this.value : value; }
        }

        public String StringValue()
        {
            return this.value == 0 ? "" : this.value.ToString();
        }

        public bool Locked 
        {
            get { return this.locked; }
            set { this.locked = value; }
        }
        #endregion

        public SudokuRegion Region
        {
            get {return this.region;}
            set { this.region = value; }
        }

        public Cell(Position position)
        {
            this.position = position;
        }

        public bool InitializeValue(int value)
        {
            if(value > 0 && value <= (GlobalConstants.CELLS_IN_REGION_ROW * GlobalConstants.CELLS_IN_REGION_COLUMN))
            {
                this.value = value;
                this.locked = true;
                return true;
            }
            return false;
        }
    }
}
