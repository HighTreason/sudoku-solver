using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc_Sudoku_Solver_.Classes
{
    public class GlobalConstants
    {
        public static int REGIONS_IN_ROW = 3;
        public static int REGIONS_IN_COLUMN = 3;

        public static int CELLS_IN_REGION_ROW = 3;
        public static int CELLS_IN_REGION_COLUMN = 3;

        public static System.Drawing.Size DRAWING_CELL_SIZE = new System.Drawing.Size(50, 50);
        public static System.Drawing.Size DRAWING_REGION_SIZE = new System.Drawing.Size(DRAWING_CELL_SIZE.Width * CELLS_IN_REGION_ROW, DRAWING_CELL_SIZE.Height * CELLS_IN_REGION_COLUMN);

        public static int DRAWING_REGION_BORDER_PEN_WIDTH = 4;
        public static int DRAWING_CELL_BORDER_PEN_WIDTH = 2;
    }
}
