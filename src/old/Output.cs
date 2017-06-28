using System.Collections.Generic;
using System.Linq;

namespace LogicSimplifier
{
    internal class Output
    {
        public static bool EqualsDuo(ValueDuo a, ValueDuo b)
        {
            return a.A == b.A && a.B == b.B;
        }

        public static List<ValueDuo> CheckDoubleInDuo(List<ValueDuo> value)
        {
            var doub = new List<int>();
            var length = value.Count;

            for (var i = 0; i < length; i++)
                for (var j = i + 1; j < length; j++)
                    if (EqualsDuo(value[i], value[j]))
                        doub.Add(j);

            var res = value;
            doub.Sort();
            doub = doub.Distinct().ToList();
            doub.Reverse();

            foreach (var i in doub)
                res.RemoveAt(i);

            return res;
        }

        public static void Duo(List<ValueDuo> value)
        {
            MainForm.DebugForm.AddLine("------------------------");

            // Gebe DataGrid in Debugfenster aus
            foreach (var t in value)
            {
                var values = "";

                if (t.A == -1)
                    values += " " + "-";
                else
                    values += " " + t.A;

                if (t.B == -1)
                    values += " " + "-";
                else
                    values += " " + t.B;

                MainForm.DebugForm.AddLine("DataGrid:" + values);
            }
        }

        public static bool EqualsTrio(ValueTrio a, ValueTrio b)
        {
            return a.A == b.A && a.B == b.B && a.C == b.C;
        }

        public static List<ValueTrio> CheckDoubleInTrio(List<ValueTrio> value)
        {
            var doub = new List<int>();
            var length = value.Count;

            for (var i = 0; i < length; i++)
                for (var j = i + 1; j < length; j++)
                    if (EqualsTrio(value[i], value[j]))
                        doub.Add(j);

            var res = value;
            doub.Sort();
            doub = doub.Distinct().ToList();
            doub.Reverse();

            foreach (var i in doub)
                res.RemoveAt(i);

            return res;
        }

        public static void Trio(List<ValueTrio> value)
        {
            MainForm.DebugForm.AddLine("------------------------");

            // Gebe DataGrid in Debugfenster aus
            foreach (var t in value)
            {
                var values = "";

                if (t.A == -1)
                    values += " " + "-";
                else
                    values += " " + t.A;

                if (t.B == -1)
                    values += " " + "-";
                else
                    values += " " + t.B;

                if (t.C == -1)
                    values += " " + "-";
                else
                    values += " " + t.C;

                MainForm.DebugForm.AddLine("DataGrid:" + values);
            }
        }

        public static bool EqualsQuartett(ValueQuartett a, ValueQuartett b)
        {
            return a.A == b.A && a.B == b.B && a.C == b.C && a.D == b.D;
        }

        public static List<ValueQuartett> CheckDoubleInQuartett(List<ValueQuartett> value)
        {
            var doub = new List<int>();
            var length = value.Count;

            for (var i = 0; i < length; i++)
                for (var j = i + 1; j < length; j++)
                    if (EqualsQuartett(value[i], value[j]))
                        doub.Add(j);

            var res = value;
            doub.Sort();
            doub = doub.Distinct().ToList();
            doub.Reverse();

            foreach (var i in doub)
                res.RemoveAt(i);

            return res;
        }

        public static void Quartett(List<ValueQuartett> value)
        {
            MainForm.DebugForm.AddLine("------------------------");

            // Gebe DataGrid in Debugfenster aus
            foreach (var t in value)
            {
                var values = "";

                if (t.A == -1)
                    values += " " + "-";
                else
                    values += " " + t.A;

                if (t.B == -1)
                    values += " " + "-";
                else
                    values += " " + t.B;

                if (t.C == -1)
                    values += " " + "-";
                else
                    values += " " + t.C;

                if (t.D == -1)
                    values += " " + "-";
                else
                    values += " " + t.D;

                MainForm.DebugForm.AddLine("DataGrid:" + values);
            }
        }
    }
}