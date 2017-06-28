using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LogicSimplifier
{
    public partial class Dnf : Form
    {
        private static bool _checked;

        public Dnf()
        {
            InitializeComponent();
            MainForm.DebugForm.AddLine("Initiation: DNF");
        }

        private void addColumn_Click(object sender, EventArgs e)
        {
            if (dataGrid.ColumnCount > 3) return;

            var col = new DataGridViewTextBoxColumn();
            var l = char.ConvertFromUtf32(65 + dataGrid.ColumnCount);
            col.Name = l;
            col.MinimumWidth = 23;
            col.Width = 23;
            col.Resizable = DataGridViewTriState.False;
            dataGrid.Columns.Add(col);
        }

        private void removeColumn_Click(object sender, EventArgs e)
        {
            if (dataGrid.ColumnCount > 2)
                dataGrid.ColumnCount = dataGrid.ColumnCount - 1;
        }

        private void dataGrid_Edited(object sender, DataGridViewCellEventArgs e)
        {
            _checked = false;
            labelProblem.Text = @"Check first.";
            labelProblem.ForeColor = Color.Red;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            var error = false;

            // code for checking
            // Get all rows
            var dgvr = dataGrid.Rows;
            for (var i = 0; i < dgvr.Count - 1; i++)
            {
                // Debugging
                Console.Write(i + @":");
                var values = "";

                // Check for every cell in row i
                for (var j = 0; j < dgvr[i].Cells.Count; j++)
                {
                    // Debugging
                    values += " " + dgvr[i].Cells[j].Value;

                    // if cell j in row i isn't 0 or 1
                    if (dgvr[i].Cells[j].Value == null)
                    {
                        // set bool error to true and select the last wrong cell
                        error = true;
                        dgvr[i].Cells[j].Selected = true;
                    }
                    else
                    if (dgvr[i].Cells[j].Value.ToString() != "1" && dgvr[i].Cells[j].Value.ToString() != "0")
                    {
                        // set bool error to true and select the last wrong cell
                        error = true;
                        dgvr[i].Cells[j].Selected = true;
                    }
                }
                // Debugging
                Console.WriteLine(@"DataGrid:" + values);
                MainForm.DebugForm.AddLine("DataGrid:" + values);
            }

            if (error)
            {
                // If error
                labelProblem.Text = @"Error.";
                labelProblem.ForeColor = Color.Red;
            }
            else
            {
                // If no error
                labelProblem.Text = @"No Problems.";
                labelProblem.ForeColor = Color.Green;
                _checked = true;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (_checked)
            {
                // Debugging
                Console.WriteLine(@"Start simplifying");
                MainForm.DebugForm.AddLine("Start simplifying");

                // Get all rows
                var dgvr = dataGrid.Rows;

                // Debugging
                Console.WriteLine(@"Mode " + dataGrid.ColumnCount);
                MainForm.DebugForm.AddLine("Mode " + dataGrid.ColumnCount);

                // Create instance of Simplify.cs
                var simple = new Simplify();

                // 2 columns, use ValueDuo
                if (dataGrid.ColumnCount == 2)
                {
                    // as a result
                    var list = new List<ValueDuo>();

                    // Get row i
                    for (var i = 0; i < dgvr.Count - 1; i++)
                    {
                        int[] ba = { 0, 0 };
                        // Get cell j in row i
                        for (var j = 0; j < dgvr[i].Cells.Count; j++)
                        {
                            // check for 1 and 0 and put it into an bool-array
                            if (dgvr[i].Cells[j].Value.ToString() == "1")
                                ba[j] = 1;
                        }
                        // convert bool array to a ValueDuo and add it to Dictionary
                        var v = new ValueDuo(ba);
                        list.Add(v);
                    }
                    // put dictionary to instance simple of Simplify.cs
                    simple.Add(list); simple.SetMode(2);
                }

                // 3 columns, use ValueTrio
                if (dataGrid.ColumnCount == 3)
                {
                    // as a result
                    var list = new List<ValueTrio>();

                    // Get row i
                    for (var i = 0; i < dgvr.Count - 1; i++)
                    {
                        int[] ba = { 0, 0, 0 };
                        // Get cell j in row i
                        for (var j = 0; j < dgvr[i].Cells.Count; j++)
                        {
                            // check for 1 and 0 and put it into an bool-array
                            if (dgvr[i].Cells[j].Value.ToString() == "1")
                                ba[j] = 1;
                        }
                        // convert bool array to a ValueDuo and add it to Dictionary
                        var v = new ValueTrio(ba);
                        list.Add(v);
                    }
                    // put dictionary to instance simple of Simplify.cs
                    simple.Add(list); simple.SetMode(3);
                }

                // 4 columns, use ValueQuartett
                if (dataGrid.ColumnCount == 4)
                {
                    // as a result
                    var list = new List<ValueQuartett>();

                    // Get row i
                    for (var i = 0; i < dgvr.Count - 1; i++)
                    {
                        int[] ba = { 0, 0, 0, 0 };
                        // Get cell j in row i
                        for (var j = 0; j < dgvr[i].Cells.Count; j++)
                        {
                            // check for 1 and 0 and put it into an bool-array
                            if (dgvr[i].Cells[j].Value.ToString() == "1")
                                ba[j] = 1;
                        }
                        // convert bool array to a ValueDuo and add it to Dictionary
                        var v = new ValueQuartett(ba);
                        list.Add(v);
                    }
                    // put dictionary to instance simple of Simplify.cs
                    simple.Add(list); simple.SetMode(4);
                }

                // 5 columns, use ValueQuintett
                if (dataGrid.ColumnCount == 5)
                {
                    // as a result
                    var list = new List<ValueQuintett>();

                    // Get row i
                    for (var i = 0; i < dgvr.Count - 1; i++)
                    {
                        int[] ba = { 0, 0, 0, 0, 0 };
                        // Get cell j in row i
                        for (var j = 0; j < dgvr[i].Cells.Count; j++)
                        {
                            // check for 1 and 0 and put it into an bool-array
                            if (dgvr[i].Cells[j].Value.ToString() == "1")
                                ba[j] = 1;
                        }
                        // convert bool array to a ValueDuo and add it to Dictionary
                        var v = new ValueQuintett(ba);
                        list.Add(v);
                    }
                    // put dictionary to instance simple of Simplify.cs
                    simple.Add(list); simple.SetMode(5);
                }

                // 6 columns, use ValueSextett
                if (dataGrid.ColumnCount == 6)
                {
                    // as a result
                    var list = new List<ValueSextett>();

                    // Get row i
                    for (var i = 0; i < dgvr.Count - 1; i++)
                    {
                        int[] ba = { 0, 0, 0, 0, 0, 0 };
                        // Get cell j in row i
                        for (var j = 0; j < dgvr[i].Cells.Count; j++)
                        {
                            // check for 1 and 0 and put it into an bool-array
                            if (dgvr[i].Cells[j].Value.ToString() == "1")
                                ba[j] = 1;
                        }
                        // convert bool array to a ValueDuo and add it to Dictionary
                        var v = new ValueSextett(ba);
                        list.Add(v);
                    }
                    // put dictionary to instance simple of Simplify.cs
                    simple.Add(list); simple.SetMode(6);
                }

                // Prepare the algorythm and run it!
                simple.Simple(simple.Prepare());

                if (MainForm.OutputWindow.Visible)
                    MainForm.OutputWindow.Hide();
                else
                {
                    MainForm.OutputWindow = new OutputDnf();
                    MainForm.OutputWindow.Activate();

                    if (dataGrid.ColumnCount == 2)
                        MainForm.OutputWindow.SetString(GetDuoString(simple.GetDuo()));
                    if (dataGrid.ColumnCount == 3)
                        MainForm.OutputWindow.SetString(GetTrioString(simple.GetTrio()));
                    if (dataGrid.ColumnCount == 4)
                        MainForm.OutputWindow.SetString(GetQuartettString(simple.GetQuartett()));

                    MainForm.OutputWindow.Show();
                }
            }
            else
            {
                // If no error
                labelProblem.Text = @"Check first.";
                labelProblem.ForeColor = Color.Red;
            }
        }

        private static string[] GetDuoString(List<ValueDuo> vd)
        {
            var o = new List<string>();

            for (var i = 0; i < vd.Count; i++)
            {
                var v = vd[i];
                var str = "";
                var a = false;

                switch (v.A)
                {
                    case 1:
                        str += "A";
                        a = true;
                        break;

                    case 0:
                        str += "¬A";
                        a = true;
                        break;
                }

                switch (v.B)
                {
                    case 1:
                        if (a)
                            str += " * B";
                        else
                            str += "B";
                        break;

                    case 0:
                        if (a)
                            str += " * ¬B";
                        else
                            str += "¬B";
                        break;
                }

                str = "( " + str + " )";
                if (i != (vd.Count - 1))
                    str = str + " +";
                o.Add(str);
            }

            return o.ToArray();
        }

        private string[] GetTrioString(List<ValueTrio> vd)
        {
            var o = new List<string>();

            for (var i = 0; i < vd.Count; i++)
            {
                var v = vd[i];
                var str = "";
                bool a = false, b = false;

                switch (v.A)
                {
                    case 1:
                        str += "A";
                        a = true;
                        break;

                    case 0:
                        str += "¬A";
                        a = true;
                        break;
                }

                switch (v.B)
                {
                    case 1:
                        if (a)
                            str += " * ";
                        str += "B";
                        b = true;
                        break;

                    case 0:
                        if (a)
                            str += " * ";
                        str += "¬B";
                        b = true;
                        break;
                }

                switch (v.C)
                {
                    case 1:
                        if (a || b)
                            str += " * ";
                        str += "C";
                        break;

                    case 0:
                        if (a || b)
                            str += " * ";
                        str += "¬C";
                        break;
                }

                str = "( " + str + " )";
                if (i != (vd.Count - 1))
                    str = str + " +";
                o.Add(str);
            }

            return o.ToArray();
        }

        private static string[] GetQuartettString(List<ValueQuartett> vd)
        {
            var o = new List<string>();

            for (var i = 0; i < vd.Count; i++)
            {
                var v = vd[i];
                var str = "";
                bool a = false, b = false, c = false;

                switch (v.A)
                {
                    case 1:
                        str += "A";
                        a = true;
                        break;

                    case 0:
                        str += "¬A";
                        a = true;
                        break;
                }

                switch (v.B)
                {
                    case 1:
                        if (a)
                            str += " * ";
                        str += "B";
                        b = true;
                        break;

                    case 0:
                        if (a)
                            str += " * ";
                        str += "¬B";
                        b = true;
                        break;
                }

                switch (v.C)
                {
                    case 1:
                        if (a || b)
                            str += " * ";
                        str += "C";
                        c = true;
                        break;

                    case 0:
                        if (a || b)
                            str += " * ";
                        str += "¬C";
                        c = true;
                        break;
                }

                switch (v.D)
                {
                    case 1:
                        if (a || b || c)
                            str += " * ";
                        str += "D";
                        break;

                    case 0:
                        if (a || b || c)
                            str += " * ";
                        str += "¬D";
                        break;
                }

                str = "( " + str + " )";
                if (i != (vd.Count - 1))
                    str = str + " +";
                o.Add(str);
            }

            return o.ToArray();
        }
    }
}