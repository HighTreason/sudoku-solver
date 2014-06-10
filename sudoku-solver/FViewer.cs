using Misc_Sudoku_Solver_.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku_solver
{
    public partial class FViewer : Form
    {
        Board sudokuBoard;
        public FViewer()
        {
            InitializeComponent();

            sudokuBoard = new Board();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawBoard();
        }

        public void DrawBoard()
        {
            #region Draw Regions

            Graphics rowLabels = SudokuSolverPanel.CreateGraphics();
            Graphics columnLabels = SudokuSolverPanel.CreateGraphics();
            Graphics g = SudokuSolverPanel.CreateGraphics();
            g.TranslateTransform(40, 40);
            Pen pen = new Pen(Brushes.Black);
            pen.Width = GlobalConstants.DRAWING_REGION_BORDER_PEN_WIDTH;
            Point point;
            Rectangle rectangle;

            for (int row = 0; row < GlobalConstants.REGIONS_IN_COLUMN; row++)
            {
                for (int column = 0; column < GlobalConstants.REGIONS_IN_ROW; column++)
                {
                    SudokuRegion region = this.sudokuBoard.Regions[row, column];

                    point = new Point(region.Position.Column * GlobalConstants.DRAWING_REGION_SIZE.Width, region.Position.Row * GlobalConstants.DRAWING_REGION_SIZE.Height);

                    rectangle = new Rectangle(point, GlobalConstants.DRAWING_REGION_SIZE);
                    g.DrawRectangle(pen, rectangle);
                }
            }
            #endregion

            #region Draw Cells
            int globalRowIndex = 0, globalColumnIndex = 0;
            int pointX = 0, pointY = 0;
            foreach (SudokuRegion region in this.sudokuBoard.Regions)
            {                                
                pen.Width = GlobalConstants.DRAWING_CELL_BORDER_PEN_WIDTH;

                for (int row = 0; row < GlobalConstants.CELLS_IN_REGION_ROW; row++)
                {
                    for (int column = 0; column < GlobalConstants.CELLS_IN_REGION_COLUMN; column++)
                    {
                        Cell cell = region.Cells[row, column];

                        pointX = cell.Position.Column * GlobalConstants.DRAWING_CELL_SIZE.Width + (region.Position.Column * GlobalConstants.DRAWING_REGION_SIZE.Width);
                        pointY = cell.Position.Row * GlobalConstants.DRAWING_CELL_SIZE.Height + (region.Position.Row * GlobalConstants.DRAWING_REGION_SIZE.Height);
                        point = new Point(pointX, pointY);

                        rectangle = new Rectangle(point, GlobalConstants.DRAWING_CELL_SIZE);
                        g.DrawRectangle(pen, rectangle);

                        g.DrawString(cell.StringValue(), this.Font, cell.Locked ? Brushes.Red : Brushes.Blue, new Point(point.X + GlobalConstants.DRAWING_CELL_SIZE.Width * 40 / 100, point.Y + GlobalConstants.DRAWING_CELL_SIZE.Height * 40 / 100));

                        globalRowIndex = row + region.Position.Row * GlobalConstants.CELLS_IN_REGION_ROW;
                        globalColumnIndex = column + region.Position.Column * GlobalConstants.CELLS_IN_REGION_COLUMN;

                        rowLabels.DrawString((globalRowIndex).ToString(), this.Font, Brushes.Green, new Point(10, 40 + point.Y + GlobalConstants.DRAWING_CELL_SIZE.Height * 40 / 100));
                        columnLabels.DrawString(globalColumnIndex.ToString(), this.Font, Brushes.Green, new Point(40 + point.X + GlobalConstants.DRAWING_CELL_SIZE.Width * 40 / 100, 10));
                    }
                }
            }
            #endregion
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            int numberOfRows = GlobalConstants.REGIONS_IN_COLUMN * GlobalConstants.CELLS_IN_REGION_COLUMN;

            for (int index = 0; index < numberOfRows; index++)
            {
                Console.WriteLine("Row :'" + index + "' has '" + this.sudokuBoard.NumberOfUnknownsInRow(index) + "' unknowns");
            }

            int numberOfColumns = GlobalConstants.REGIONS_IN_ROW * GlobalConstants.CELLS_IN_REGION_ROW;

            for (int index = 0; index < numberOfColumns; index++)
            {
                Console.WriteLine("Column :'" + index + "' has '" + this.sudokuBoard.NumberOfUnknownsInColumn(index) + "' unknowns");
            }
        }
    }
}
