using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc_Sudoku_Solver_.Classes
{
    public class SudokuRegion
    {
        #region private members
        private Position position;
        private Cell[,] cells;
        private Board board;
        #endregion

        #region properties
        public Position Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public Board Board
        {
            get { return this.board; }
            set { this.board = value; }
        }

        public Cell[,] Cells
        {
            get { return this.cells; }
            set { this.cells = value; }
        }
        #endregion

        #region Constructors
        public SudokuRegion(Position position)
        {
            this.position = position;
            this.cells = new Cell[GlobalConstants.CELLS_IN_REGION_ROW, GlobalConstants.CELLS_IN_REGION_COLUMN];
            InitializeComponents();
        }
        #endregion

        private void InitializeComponents()
        {
            for (int row = 0; row < GlobalConstants.CELLS_IN_REGION_ROW; row++)
            {
                for (int column = 0; column < GlobalConstants.CELLS_IN_REGION_COLUMN; column++)
                {
                    this.cells[row, column] = new Cell(new Position(row, column));
                    this.cells[row, column].Region = this;
                }
            }
        }

        public bool IsValid()
        {
            bool[] numbers = new bool[GlobalConstants.CELLS_IN_REGION_ROW * GlobalConstants.CELLS_IN_REGION_COLUMN];
            numbers.Initialize();

            bool duplication = false;

            Cell cell;

            for (int row = 0; row < GlobalConstants.CELLS_IN_REGION_ROW; row++)
            {
                for (int column = 0; column < GlobalConstants.CELLS_IN_REGION_COLUMN; column++)
                {
                    cell = this.cells[row, column];
                    if(cell.HasValue)
                    {
                        if(numbers[cell.Value - 1])
                        {
                            duplication = true;
                            break;
                        }
                        else
                        {
                            numbers[cell.Value - 1] = true;
                        }
                    }
                }
            }

            return !duplication;
        }

        public int NumberOfUnknownsInRow(int rowPosition)
        {
            int numberOfUnknowns = 0;
            for (int column = 0; column < GlobalConstants.CELLS_IN_REGION_COLUMN; column++)
            {
                if (!this.cells[rowPosition, column].HasValue)
                    numberOfUnknowns++;
            }
            return numberOfUnknowns;
        }

        internal int NumberOfUnknownsInColumn(int columnPosition)
        {
            int numberOfUnknowns = 0;
            for (int row = 0; row < GlobalConstants.CELLS_IN_REGION_ROW; row++)
            {
                if (!this.cells[row, columnPosition].HasValue)
                    numberOfUnknowns++;
            }
            return numberOfUnknowns;
        }
    }
}
