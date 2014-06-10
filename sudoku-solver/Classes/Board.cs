using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc_Sudoku_Solver_.Classes
{
    public class Board
    {
        #region private members
        private SudokuRegion[,] regions;
        #endregion

        #region Properties
        public SudokuRegion[,] Regions
        {
            get { return this.regions; }
            set { this.regions = value; }
        }
        #endregion

        public Board()
        {
            this.regions = new SudokuRegion[GlobalConstants.REGIONS_IN_COLUMN, GlobalConstants.REGIONS_IN_ROW];
            InitializeComponents();
            FillBoardWithGivenData();
        }

        private void InitializeComponents()
        {
            for (int row = 0; row < GlobalConstants.REGIONS_IN_COLUMN; row++)
            {
                for (int column = 0; column < GlobalConstants.REGIONS_IN_ROW; column++)
                {
                    this.regions[row, column] = new SudokuRegion(new Position(row, column));
                    this.regions[row, column].Board = this;
                }
            }
        }

        public int NumberOfUnknownsInRow(int rowIndex)
        {
            int regionRowIndex = rowIndex / GlobalConstants.REGIONS_IN_ROW;
            int cellRowIndex = rowIndex % GlobalConstants.CELLS_IN_REGION_ROW;
            int numberOfUnknowns = 0;

            for (int column = 0; column < GlobalConstants.REGIONS_IN_ROW; column++)
            {
                numberOfUnknowns += this.regions[regionRowIndex, column].NumberOfUnknownsInRow(cellRowIndex);
            }

            return numberOfUnknowns;
        }

        public int NumberOfUnknownsInColumn(int columnIndex)
        {
            int regionColumnIndex = columnIndex / GlobalConstants.REGIONS_IN_COLUMN;
            int cellColumnIndex = columnIndex % GlobalConstants.CELLS_IN_REGION_COLUMN;
            int numberOfUnknowns = 0;

            for (int row = 0; row < GlobalConstants.REGIONS_IN_COLUMN; row++)
            {
                numberOfUnknowns += this.regions[row, regionColumnIndex].NumberOfUnknownsInColumn(cellColumnIndex);
            }

            return numberOfUnknowns;
        }

        public void FillBoardWithGivenData()
        {
            #region Fill Board With Initial Values
            #region 0, 0
            this.regions[0, 0].Cells[0, 1].InitializeValue(2);
            this.regions[0, 0].Cells[1, 0].InitializeValue(8);
            this.regions[0, 0].Cells[2, 1].InitializeValue(3);
            #endregion

            #region 0, 1
            this.regions[0, 1].Cells[0, 0].InitializeValue(5);
            this.regions[0, 1].Cells[0, 2].InitializeValue(1);
            this.regions[0, 1].Cells[1, 0].InitializeValue(2);
            this.regions[0, 1].Cells[1, 2].InitializeValue(3);
            this.regions[0, 1].Cells[2, 1].InitializeValue(6);
            #endregion

            #region 0, 2
            this.regions[0, 2].Cells[0, 1].InitializeValue(9);
            this.regions[0, 2].Cells[1, 2].InitializeValue(6);
            this.regions[0, 2].Cells[2, 1].InitializeValue(7);
            #endregion

            #region 1, 0
            this.regions[1, 0].Cells[0, 2].InitializeValue(1);
            this.regions[1, 0].Cells[1, 0].InitializeValue(5);
            this.regions[1, 0].Cells[1, 1].InitializeValue(4);
            this.regions[1, 0].Cells[2, 2].InitializeValue(2);
            #endregion

            #region 1, 1
            #endregion

            #region 1, 2
            this.regions[1, 2].Cells[0, 0].InitializeValue(6);
            this.regions[1, 2].Cells[1, 1].InitializeValue(1);
            this.regions[1, 2].Cells[1, 2].InitializeValue(9);
            this.regions[1, 2].Cells[2, 0].InitializeValue(7);
            #endregion

            #region 2, 0
            this.regions[2, 0].Cells[0, 1].InitializeValue(9);
            this.regions[2, 0].Cells[1, 0].InitializeValue(2);
            this.regions[2, 0].Cells[2, 1].InitializeValue(1);
            #endregion

            #region 2, 1
            this.regions[2, 1].Cells[0, 1].InitializeValue(3);
            this.regions[2, 1].Cells[1, 0].InitializeValue(8);
            this.regions[2, 1].Cells[1, 2].InitializeValue(4);
            this.regions[2, 1].Cells[2, 0].InitializeValue(9);
            this.regions[2, 1].Cells[2, 2].InitializeValue(7);
            #endregion

            #region 2, 2
            this.regions[2, 2].Cells[0, 1].InitializeValue(8);
            this.regions[2, 2].Cells[1, 2].InitializeValue(7);
            this.regions[2, 2].Cells[2, 1].InitializeValue(6);
            #endregion
            #endregion
        }
    }
}
