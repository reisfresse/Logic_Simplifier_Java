using System.Windows.Forms;

namespace LogicSimplifier
{
    partial class Dnf
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Dnf));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonReset = new System.Windows.Forms.Button();
            this.removeColumn = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelProblem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C,
            this.D});
            this.dataGrid.Location = new System.Drawing.Point(12, 113);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 40;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.ShowCellToolTips = false;
            this.dataGrid.Size = new System.Drawing.Size(188, 372);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellValueChanged += new DataGridViewCellEventHandler(this.dataGrid_Edited);
            // 
            // A
            // 
            this.A.HeaderText = "A";
            this.A.MinimumWidth = 23;
            this.A.Name = "A";
            this.A.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.A.Width = 23;
            // 
            // B
            // 
            this.B.HeaderText = "B";
            this.B.MinimumWidth = 23;
            this.B.Name = "B";
            this.B.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.B.Width = 23;
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.MinimumWidth = 23;
            this.C.Name = "C";
            this.C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.C.Width = 23;
            // 
            // D
            // 
            this.D.HeaderText = "D";
            this.D.MinimumWidth = 23;
            this.D.Name = "D";
            this.D.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.D.Width = 23;
            // 
            // buttonReset
            // 
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.Location = new System.Drawing.Point(12, 12);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(91, 37);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Spalte hinzufügen";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.addColumn_Click);
            // 
            // removeColumn
            // 
            this.removeColumn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeColumn.Location = new System.Drawing.Point(109, 12);
            this.removeColumn.Name = "removeColumn";
            this.removeColumn.Size = new System.Drawing.Size(91, 37);
            this.removeColumn.TabIndex = 2;
            this.removeColumn.Text = "Spalte entfernen";
            this.removeColumn.UseVisualStyleBackColor = true;
            this.removeColumn.Click += new System.EventHandler(this.removeColumn_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheck.Location = new System.Drawing.Point(12, 55);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(74, 23);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Location = new System.Drawing.Point(12, 84);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(188, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Simplify";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelProblem
            // 
            this.labelProblem.AutoSize = true;
            this.labelProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProblem.Location = new System.Drawing.Point(92, 58);
            this.labelProblem.Name = "labelProblem";
            this.labelProblem.Size = new System.Drawing.Size(96, 15);
            this.labelProblem.TabIndex = 5;
            this.labelProblem.Text = "Please check!";
            // 
            // DNF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 497);
            this.Controls.Add(this.labelProblem);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.removeColumn);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(228, 536);
            this.MinimumSize = new System.Drawing.Size(228, 536);
            this.Name = "Dnf";
            this.Text = "DNF";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button removeColumn;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelProblem;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
    }
}