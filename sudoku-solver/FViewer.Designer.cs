namespace sudoku_solver
{
    partial class FViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SudokuSolverPanel = new System.Windows.Forms.Panel();
            this.DrawBoardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SudokuSolverPanel
            // 
            this.SudokuSolverPanel.Location = new System.Drawing.Point(12, 12);
            this.SudokuSolverPanel.Name = "SudokuSolverPanel";
            this.SudokuSolverPanel.Size = new System.Drawing.Size(760, 411);
            this.SudokuSolverPanel.TabIndex = 0;
            // 
            // DrawBoardButton
            // 
            this.DrawBoardButton.Location = new System.Drawing.Point(12, 527);
            this.DrawBoardButton.Name = "DrawBoardButton";
            this.DrawBoardButton.Size = new System.Drawing.Size(75, 23);
            this.DrawBoardButton.TabIndex = 1;
            this.DrawBoardButton.Text = "Draw Board";
            this.DrawBoardButton.UseVisualStyleBackColor = true;
            this.DrawBoardButton.Click += new System.EventHandler(this.DrawBoardButton_Click);
            // 
            // FViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.DrawBoardButton);
            this.Controls.Add(this.SudokuSolverPanel);
            this.Name = "FViewer";
            this.Text = "Sudoku";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SudokuSolverPanel;
        private System.Windows.Forms.Button DrawBoardButton;
    }
}

