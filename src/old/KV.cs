using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogicSimplifier
{
    public partial class Kv : Form
    {
        public Kv()
        {
            InitializeComponent();
            MainForm.DebugForm.AddLine("Initiation: KV");
        }

        private void create_Click(object sender, EventArgs e)
        {
            MainForm.DebugForm.AddLine("ButtonClick: KV - create");
            var tab = tabControl1.SelectedIndex;
            MainForm.DebugForm.AddLine("KV: TabIndex " + tab);

            if (tab == 0)
                Make2();
            if (tab == 1)
                Make3();
            if (tab == 2)
                Make4();
        }

        private void Make2()
        {
            MainForm.DebugForm.AddLine("KV: make2");

            // create instance of simplifier
            var s = new Simplify();
            var value = new List<ValueDuo>();

            if (boxA1.Checked) value.Add(new ValueDuo(1, 1));
            if (boxA2.Checked) value.Add(new ValueDuo(0, 1));
            if (boxA3.Checked) value.Add(new ValueDuo(1, 0));
            if (boxA4.Checked) value.Add(new ValueDuo(0, 0));

            s.Add(value);
            s.SetMode(2);

            // Prepare the algorythm and run it!
            s.Simple(s.Prepare());

            var res = s.GetDuo();

            if (MainForm.OutputWindow.Visible)
                MainForm.OutputWindow.Hide();
            else
            {
                MainForm.OutputWindow = new OutputDnf();
                MainForm.OutputWindow.Activate();
                MainForm.OutputWindow.SetString(GetDuoString(res));
                MainForm.OutputWindow.Show();
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

        private void Make3()
        {
            MainForm.DebugForm.AddLine("KV: make3");

            // create instance of simplifier
            var s = new Simplify();
            var value = new List<ValueTrio>();

            if (boxB1.Checked) value.Add(new ValueTrio(1, 1, 1));
            if (boxB2.Checked) value.Add(new ValueTrio(1, 1, 0));
            if (boxB3.Checked) value.Add(new ValueTrio(0, 1, 0));
            if (boxB4.Checked) value.Add(new ValueTrio(0, 1, 1));
            if (boxB5.Checked) value.Add(new ValueTrio(1, 0, 1));
            if (boxB6.Checked) value.Add(new ValueTrio(1, 0, 0));
            if (boxB7.Checked) value.Add(new ValueTrio(0, 0, 0));
            if (boxB8.Checked) value.Add(new ValueTrio(0, 0, 1));

            s.Add(value);
            s.SetMode(3);

            // Prepare the algorythm and run it!
            s.Simple(s.Prepare());

            var res = s.GetTrio();

            if (MainForm.OutputWindow.Visible)
                MainForm.OutputWindow.Hide();
            else
            {
                MainForm.OutputWindow = new OutputDnf();
                MainForm.OutputWindow.Activate();
                MainForm.OutputWindow.SetString(GetTrioString(res));
                MainForm.OutputWindow.Show();
            }
        }

        private static string[] GetTrioString(List<ValueTrio> vd)
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

        private void Make4()
        {
            MainForm.DebugForm.AddLine("KV: make4");

            // create instance of simplifier
            var s = new Simplify();
            var value = new List<ValueQuartett>();

            if (boxC1.Checked) value.Add(new ValueQuartett(1, 1, 1, 1));
            if (boxC2.Checked) value.Add(new ValueQuartett(1, 1, 0, 1));
            if (boxC3.Checked) value.Add(new ValueQuartett(0, 1, 0, 1));
            if (boxC4.Checked) value.Add(new ValueQuartett(0, 1, 1, 1));
            if (boxC5.Checked) value.Add(new ValueQuartett(1, 1, 1, 0));
            if (boxC6.Checked) value.Add(new ValueQuartett(1, 1, 0, 0));
            if (boxC7.Checked) value.Add(new ValueQuartett(0, 1, 0, 0));
            if (boxC8.Checked) value.Add(new ValueQuartett(0, 1, 1, 0));
            if (boxC9.Checked) value.Add(new ValueQuartett(1, 0, 1, 0));
            if (boxC10.Checked) value.Add(new ValueQuartett(1, 0, 0, 0));
            if (boxC11.Checked) value.Add(new ValueQuartett(0, 0, 0, 0));
            if (boxC12.Checked) value.Add(new ValueQuartett(0, 0, 1, 0));
            if (boxC13.Checked) value.Add(new ValueQuartett(1, 0, 1, 1));
            if (boxC14.Checked) value.Add(new ValueQuartett(1, 0, 0, 1));
            if (boxC15.Checked) value.Add(new ValueQuartett(0, 0, 0, 1));
            if (boxC16.Checked) value.Add(new ValueQuartett(0, 0, 1, 1));

            s.Add(value);
            s.SetMode(4);

            // Prepare the algorythm and run it!
            s.Simple(s.Prepare());

            var res = s.GetQuartett();

            if (MainForm.OutputWindow.Visible)
                MainForm.OutputWindow.Hide();
            else
            {
                MainForm.OutputWindow = new OutputDnf();
                MainForm.OutputWindow.Activate();
                MainForm.OutputWindow.SetString(GetQuartettString(res));
                MainForm.OutputWindow.Show();
            }
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