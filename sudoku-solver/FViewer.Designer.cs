﻿namespace sudoku_solver
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
            this.TestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SudokuSolverPanel
            // 
            this.SudokuSolverPanel.Location = new System.Drawing.Point(12, 41);
            this.SudokuSolverPanel.Name = "SudokuSolverPanel";
            this.SudokuSolverPanel.Size = new System.Drawing.Size(984, 677);
            this.SudokuSolverPanel.TabIndex = 0;
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(12, 12);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 1;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // FViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.SudokuSolverPanel);
            this.Name = "FViewer";
            this.Text = "Sudoku";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SudokuSolverPanel;
        private System.Windows.Forms.Button TestButton;
    }
}

