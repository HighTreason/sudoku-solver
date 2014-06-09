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

        public void DrawBoard()
        {
            #region Draw Regions

            Graphics g = SudokuSolverPanel.CreateGraphics();
            Pen pen = new Pen(Brushes.Black);
            pen.Width = 4;
            Point point;
            Rectangle rectangle;

            for (int row = 0; row < GlobalConstants.REGIONS_IN_ROW; row++)
            {
                for (int column = 0; column < GlobalConstants.REGIONS_IN_COLUMN; column++)
                {
                    SudokuRegion region = this.sudokuBoard.Regions[row, column];

                    point = new Point(region.Position.Column * 120, region.Position.Row * 120);

                    rectangle = new Rectangle(point, new Size(120, 120));
                    g.DrawRectangle(pen, rectangle);
                }
            }
            #endregion

            #region Draw Cells


            foreach (SudokuRegion region in this.sudokuBoard.Regions)
            {                                
                pen.Width = 2;

                for (int row = 0; row < GlobalConstants.CELLS_IN_REGION_ROW; row++)
                {
                    for (int column = 0; column < GlobalConstants.CELLS_IN_REGION_COLUMN; column++)
                    {
                        Cell cell = region.Cells[row, column];

                        point = new Point(cell.Position.Column * 40 + (region.Position.Column * 120), cell.Position.Row * 40 + (region.Position.Row * 120));

                        rectangle = new Rectangle(point, new Size(40, 40));
                        g.DrawRectangle(pen, rectangle);

                        g.DrawString(cell.StringValue(), this.Font, cell.Locked ? Brushes.Red : Brushes.Blue, new Point(point.X + 15, point.Y + 15));
                    }
                }
            }
            #endregion
        }

        private void DrawBoardButton_Click(object sender, EventArgs e)
        {
            DrawBoard();
        }
    }
}
