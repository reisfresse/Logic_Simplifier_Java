using System;
using System.Collections.Generic;

namespace LogicSimplifier
{
    internal class Simplify
    {
        private List<ValueDuo> _in2 = new List<ValueDuo>();
        private List<ValueTrio> _in3 = new List<ValueTrio>();
        private List<ValueQuartett> _in4 = new List<ValueQuartett>();
        private List<ValueQuintett> _in5 = new List<ValueQuintett>();
        private List<ValueSextett> _in6 = new List<ValueSextett>();
        private List<ValueDuo> _r2 = new List<ValueDuo>();
        private List<ValueTrio> _r3 = new List<ValueTrio>();
        private List<ValueQuartett> _r4 = new List<ValueQuartett>();
        private List<ValueQuintett> _r5 = new List<ValueQuintett>();
        private List<ValueSextett> _r6 = new List<ValueSextett>();

        private readonly List<int> _t0 = new List<int>(), _t1 = new List<int>(), _t2 = new List<int>(), _t3 = new List<int>(),
            _t4 = new List<int>(), _t5 = new List<int>(), _t6 = new List<int>();

        private int _mode;

        private readonly List<int> _used = new List<int>();

        public void Add(List<ValueDuo> va)
        {
            _in2 = va;
        }

        public void Add(List<ValueTrio> va)
        {
            _in3 = va;
        }

        public void Add(List<ValueQuartett> va)
        {
            _in4 = va;
        }

        public void Add(List<ValueQuintett> va)
        {
            _in5 = va;
        }

        public void Add(List<ValueSextett> va)
        {
            _in6 = va;
        }

        public void SetMode(int newMode)
        {
            // Debugging
            Console.WriteLine(@"Neuer Modus: " + newMode);
            MainForm.DebugForm.AddLine("Neuer Modus: " + newMode);

            // Set new mode
            _mode = newMode;
        }

        public bool Prepare()
        {
            // Bekomme 'mode' und bereite dementsprechend
            // die 'trues' vor
            var prepared = true;
            switch (_mode)
            {
                // In jedem Fall wird von true1 bis true-n geschaut und gespeichert
                case 2:
                    true_n(0); true_n(1); true_n(2);
                    break;

                case 3:
                    true_n(0); true_n(1); true_n(2);
                    true_n(3);
                    break;

                case 4:
                    true_n(0); true_n(1); true_n(2);
                    true_n(3); true_n(4);
                    break;

                case 5:
                    true_n(0); true_n(1); true_n(2);
                    true_n(3); true_n(4); true_n(5);
                    break;

                case 6:
                    true_n(0); true_n(1); true_n(2);
                    true_n(3); true_n(4); true_n(5);
                    true_n(6);
                    break;

                default:
                    prepared = false;
                    break;
            }
            Console.WriteLine(@"Is prepared: " + prepared);
            MainForm.DebugForm.AddLine("Prepared: " + prepared);
            return prepared;
        }

        public void Simple(bool prepared)
        {
            if (!prepared) return;
            switch (_mode)
            {
                case 2:
                    _r2 = new List<ValueDuo>();
                    Mode2();

                    _in2 = new List<ValueDuo>();
                    _in2 = Output.CheckDoubleInDuo(_r2);

                    Output.Duo(Output.CheckDoubleInDuo(_in2));
                    break;

                case 3:
                    for (var i = 0; i < 2; i++)
                    {
                        _r3 = new List<ValueTrio>();
                        Mode3();

                        _in3 = new List<ValueTrio>();
                        _in3 = Output.CheckDoubleInTrio(_r3);

                        _t0.Clear(); _t1.Clear(); _t2.Clear(); _t3.Clear();
                        _used.Clear();

                        for (var j = 0; j < _in3.Count; j++)
                        {
                            var cs = ValueTrio.Cs(_in3[j]);
                            if (cs == 0) _t0.Add(j);
                            if (cs == 1) _t1.Add(j);
                            if (cs == 2) _t2.Add(j);
                            if (cs == 3) _t3.Add(j);
                        }
                    }

                    Output.Trio(Output.CheckDoubleInTrio(_in3));
                    break;

                case 4:
                    for (var i = 0; i < 3; i++)
                    {
                        _r4 = new List<ValueQuartett>();
                        Mode4();

                        _in4 = new List<ValueQuartett>();
                        _in4 = Output.CheckDoubleInQuartett(_r4);

                        _t0.Clear(); _t1.Clear(); _t2.Clear(); _t3.Clear(); _t4.Clear();
                        _used.Clear();

                        for (var j = 0; j < _in4.Count; j++)
                        {
                            var cs = ValueQuartett.Cs(_in4[j]);
                            if (cs == 0) _t0.Add(j);
                            if (cs == 1) _t1.Add(j);
                            if (cs == 2) _t2.Add(j);
                            if (cs == 3) _t3.Add(j);
                            if (cs == 4) _t4.Add(j);
                        }
                    }

                    Output.Quartett(Output.CheckDoubleInQuartett(_in4));
                    break;

                case 5:
                    for (var i = 0; i < 4; i++)
                    {
                        Mode3();
                        _in5 = _r5;
                    }
                    break;

                case 6:
                    for (var i = 0; i < 5; i++)
                    {
                        Mode3();
                        _in6 = _r6;
                    }
                    break;
            }
        }

        private void Mode2()
        {
            // Für jeden in true_0
            foreach (var true0 in _t0)
            {
                // und jeden in true_1
                foreach (var true1 in _t1)
                {
                    var a = _in2[true0];
                    var b = _in2[true1];

                    if ((a.A == b.A) && (a.B != b.B))
                    {
                        _r2.Add(new ValueDuo(a.A, -1));
                        _used.Add(true0); _used.Add(true1);
                    }
                    if ((a.A != b.A) && (a.B == b.B))
                    {
                        _r2.Add(new ValueDuo(-1, a.B));
                        _used.Add(true0); _used.Add(true1);
                    }
                }
            }
            // Für jeden in true_1
            foreach (var true1 in _t1)
            {
                // und jeden in true_2
                foreach (var true2 in _t2)
                {
                    var a = _in2[true1];
                    var b = _in2[true2];

                    if ((a.A == b.A) && (a.B != b.B))
                    {
                        _r2.Add(new ValueDuo(a.A, -1));
                        _used.Add(true1); _used.Add(true2);
                    }
                    if ((a.A != b.A) && (a.B == b.B))
                    {
                        _r2.Add(new ValueDuo(-1, a.B));
                        _used.Add(true1); _used.Add(true2);
                    }
                }
            }

            // kontrolliere, ob alle aus t0 genutzt wurden
            foreach (var true0 in _t0)
            {
                if (_used.Contains(true0)) continue;
                _r2.Add(new ValueDuo(_in2[true0].A, _in2[true0].B));
                _used.Add(true0);
            }

            // kontrolliere, ob alle aus t1 genutzt wurden
            foreach (var true1 in _t1)
            {
                if (_used.Contains(true1)) continue;
                _r2.Add(new ValueDuo(_in2[true1].A, _in2[true1].B));
                _used.Add(true1);
            }

            // kontrolliere, ob alle aus t2 genutzt wurden
            foreach (var true2 in _t2)
            {
                if (_used.Contains(true2)) continue;
                _r2.Add(new ValueDuo(_in2[true2].A, _in2[true2].B));
                _used.Add(true2);
            }
        }

        private void Mode3()
        {
            // Für jeden in true_0
            foreach (var true0 in _t0)
            {
                // und jeden in true_1
                foreach (var true1 in _t1)
                {
                    var a = _in3[true0];
                    var b = _in3[true1];

                    if ((a.A == b.A) && (a.B == b.B) && (a.C != b.C))
                    {
                        _r3.Add(new ValueTrio(a.A, a.B, -1));
                        _used.Add(true0); _used.Add(true1);
                    }
                    else if ((a.A != b.A) && (a.B == b.B) && (a.C == b.C))
                    {
                        _r3.Add(new ValueTrio(-1, a.B, a.C));
                        _used.Add(true0); _used.Add(true1);
                    }
                    else if ((a.A == b.A) && (a.B != b.B) && (a.C == b.C))
                    {
                        _r3.Add(new ValueTrio(a.A, -1, a.C));
                        _used.Add(true0); _used.Add(true1);
                    }
                }
            }
            // Für jeden in true_1
            foreach (var true1 in _t1)
            {
                // und jeden in true_2
                foreach (var true2 in _t2)
                {
                    var a = _in3[true1];
                    var b = _in3[true2];

                    if ((a.A == b.A) && (a.B == b.B) && (a.C != b.C))
                    {
                        _r3.Add(new ValueTrio(a.A, a.B, -1));
                        _used.Add(true1); _used.Add(true2);
                    }
                    else if ((a.A != b.A) && (a.B == b.B) && (a.C == b.C))
                    {
                        _r3.Add(new ValueTrio(-1, a.B, a.C));
                        _used.Add(true1); _used.Add(true2);
                    }
                    else if ((a.A == b.A) && (a.B != b.B) && (a.C == b.C))
                    {
                        _r3.Add(new ValueTrio(a.A, -1, a.C));
                        _used.Add(true1); _used.Add(true2);
                    }
                }
            }
            // Für jeden in true_2
            foreach (var true2 in _t2)
            {
                // und jeden in true_3
                foreach (var true3 in _t3)
                {
                    var a = _in3[true2];
                    var b = _in3[true3];

                    if ((a.A == b.A) && (a.B == b.B) && (a.C != b.C))
                    {
                        _r3.Add(new ValueTrio(a.A, a.B, -1));
                        _used.Add(true2); _used.Add(true3);
                    }
                    else if ((a.A != b.A) && (a.B == b.B) && (a.C == b.C))
                    {
                        _r3.Add(new ValueTrio(-1, a.B, a.C));
                        _used.Add(true2); _used.Add(true3);
                    }
                    else if ((a.A == b.A) && (a.B != b.B) && (a.C == b.C))
                    {
                        _r3.Add(new ValueTrio(a.A, -1, a.C));
                        _used.Add(true2); _used.Add(true3);
                    }
                }
            }

            // kontrolliere, ob alle aus t0 genutzt wurden
            foreach (var true0 in _t0)
            {
                if (_used.Contains(true0)) continue;
                _r3.Add(new ValueTrio(_in3[true0].A, _in3[true0].B, _in3[true0].C));
                _used.Add(true0);
            }

            // kontrolliere, ob alle aus t1 genutzt wurden
            foreach (var true1 in _t1)
            {
                if (_used.Contains(true1)) continue;
                _r3.Add(new ValueTrio(_in3[true1].A, _in3[true1].B, _in3[true1].C));
                _used.Add(true1);
            }

            // kontrolliere, ob alle aus t2 genutzt wurden
            foreach (var true2 in _t2)
            {
                if (_used.Contains(true2)) continue;
                _r3.Add(new ValueTrio(_in3[true2].A, _in3[true2].B, _in3[true2].C));
                _used.Add(true2);
            }

            // kontrolliere, ob alle aus t3 genutzt wurden
            foreach (var true3 in _t3)
            {
                if (_used.Contains(true3)) continue;
                _r3.Add(new ValueTrio(_in3[true3].A, _in3[true3].B, _in3[true3].C));
                _used.Add(true3);
            }
        }

        private void Mode4()
        {
            // Für jeden in true_0
            foreach (var true0 in _t0)
            {
                // und jeden in true_1
                foreach (var true1 in _t1)
                {
                    var a = _in4[true0];
                    var b = _in4[true1];

                    if ((a.A == b.A) && (a.B == b.B) && (a.C == b.C) && (a.D != b.D))
                    { // abc-
                        _r4.Add(new ValueQuartett(a.A, a.B, a.C, -1));
                        _used.Add(true0); _used.Add(true1);
                    }
                    else if ((a.A == b.A) && (a.B == b.B) && (a.C != b.C) && (a.D == b.D))
                    { // ab-d
                        _r4.Add(new ValueQuartett(a.A, a.B, -1, a.D));
                        _used.Add(true0); _used.Add(true1);
                    }
                    else if ((a.A == b.A) && (a.B != b.B) && (a.C == b.C) && (a.D == b.D))
                    { // a-cd
                        _r4.Add(new ValueQuartett(a.A, -1, a.C, a.D));
                        _used.Add(true0); _used.Add(true1);
                    }
                    else if ((a.A != b.A) && (a.B == b.B) && (a.C == b.C) && (a.D == b.D))
                    { // -bcd
                        _r4.Add(new ValueQuartett(-1, a.B, a.C, a.D));
                        _used.Add(true0); _used.Add(true1);
                    }
                }
            }
            // Für jeden in true_1
            foreach (var true1 in _t1)
            {
                // und jeden in true_2
                foreach (var true2 in _t2)
                {
                    var a = _in4[true1];
                    var b = _in4[true2];

                    if ((a.A == b.A) && (a.B == b.B) && (a.C == b.C) && (a.D != b.D))
                    { // abc-
                        _r4.Add(new ValueQuartett(a.A, a.B, a.C, -1));
                        _used.Add(true1); _used.Add(true2);
                    }
                    else if ((a.A == b.A) && (a.B == b.B) && (a.C != b.C) && (a.D == b.D))
                    { // ab-d
                        _r4.Add(new ValueQuartett(a.A, a.B, -1, a.D));
                        _used.Add(true1); _used.Add(true2);
                    }
                    else if ((a.A == b.A) && (a.B != b.B) && (a.C == b.C) && (a.D == b.D))
                    { // a-cd
                        _r4.Add(new ValueQuartett(a.A, -1, a.C, a.D));
                        _used.Add(true1); _used.Add(true2);
                    }
                    else if ((a.A != b.A) && (a.B == b.B) && (a.C == b.C) && (a.D == b.D))
                    { // -bcd
                        _r4.Add(new ValueQuartett(-1, a.B, a.C, a.D));
                        _used.Add(true1); _used.Add(true2);
                    }
                }
            }
            // Für jeden in true_2
            foreach (var true2 in _t2)
            {
                // und jeden in true_3
                foreach (var true3 in _t3)
                {
                    var a = _in4[true2];
                    var b = _in4[true3];

                    if ((a.A == b.A) && (a.B == b.B) && (a.C == b.C) && (a.D != b.D))
                    { // abc-
                        _r4.Add(new ValueQuartett(a.A, a.B, a.C, -1));
                        _used.Add(true2); _used.Add(true3);
                    }
                    else if ((a.A == b.A) && (a.B == b.B) && (a.C != b.C) && (a.D == b.D))
                    { // ab-d
                        _r4.Add(new ValueQuartett(a.A, a.B, -1, a.D));
                        _used.Add(true2); _used.Add(true3);
                    }
                    else if ((a.A == b.A) && (a.B != b.B) && (a.C == b.C) && (a.D == b.D))
                    { // a-cd
                        _r4.Add(new ValueQuartett(a.A, -1, a.C, a.D));
                        _used.Add(true2); _used.Add(true3);
                    }
                    else if ((a.A != b.A) && (a.B == b.B) && (a.C == b.C) && (a.D == b.D))
                    { // -bcd
                        _r4.Add(new ValueQuartett(-1, a.B, a.C, a.D));
                        _used.Add(true2); _used.Add(true3);
                    }
                }
            }

            // Für jeden in true_3
            foreach (var true3 in _t3)
            {
                // und jeden in true_4
                foreach (var true4 in _t4)
                {
                    var a = _in4[true3];
                    var b = _in4[true4];

                    if ((a.A == b.A) && (a.B == b.B) && (a.C == b.C) && (a.D != b.D))
                    { // abc-
                        _r4.Add(new ValueQuartett(a.A, a.B, a.C, -1));
                        _used.Add(true3); _used.Add(true4);
                    }
                    else if ((a.A == b.A) && (a.B == b.B) && (a.C != b.C) && (a.D == b.D))
                    { // ab-d
                        _r4.Add(new ValueQuartett(a.A, a.B, -1, a.D));
                        _used.Add(true3); _used.Add(true4);
                    }
                    else if ((a.A == b.A) && (a.B != b.B) && (a.C == b.C) && (a.D == b.D))
                    { // a-cd
                        _r4.Add(new ValueQuartett(a.A, -1, a.C, a.D));
                        _used.Add(true3); _used.Add(true4);
                    }
                    else if ((a.A != b.A) && (a.B == b.B) && (a.C == b.C) && (a.D == b.D))
                    { // -bcd
                        _r4.Add(new ValueQuartett(-1, a.B, a.C, a.D));
                        _used.Add(true3); _used.Add(true4);
                    }
                }
            }

            // kontrolliere, ob alle aus t0 genutzt wurden
            foreach (var true0 in _t0)
            {
                if (_used.Contains(true0)) continue;
                _r4.Add(new ValueQuartett(_in4[true0].A, _in4[true0].B, _in4[true0].C, _in4[true0].D));
                _used.Add(true0);
            }

            // kontrolliere, ob alle aus t1 genutzt wurden
            foreach (var true1 in _t1)
            {
                if (_used.Contains(true1)) continue;
                _r4.Add(new ValueQuartett(_in4[true1].A, _in4[true1].B, _in4[true1].C, _in4[true1].D));
                _used.Add(true1);
            }

            // kontrolliere, ob alle aus t2 genutzt wurden
            foreach (var true2 in _t2)
            {
                if (_used.Contains(true2)) continue;
                _r4.Add(new ValueQuartett(_in4[true2].A, _in4[true2].B, _in4[true2].C, _in4[true2].D));
                _used.Add(true2);
            }

            // kontrolliere, ob alle aus t3 genutzt wurden
            foreach (var true3 in _t3)
            {
                if (_used.Contains(true3)) continue;
                _r4.Add(new ValueQuartett(_in4[true3].A, _in4[true3].B, _in4[true3].C, _in4[true3].D));
                _used.Add(true3);
            }

            // kontrolliere, ob alle aus t4 genutzt wurden
            foreach (var true4 in _t4)
            {
                if (_used.Contains(true4)) continue;
                _r4.Add(new ValueQuartett(_in4[true4].A, _in4[true4].B, _in4[true4].C, _in4[true4].D));
                _used.Add(true4);
            }
        }

        private void true_n(int round)
        {
            Console.WriteLine(@"Bekomme Stadien - Runde: " + round);
            MainForm.DebugForm.AddLine("Stadien - Runde: " + round);
            switch (_mode)
            {
                case 2:
                    // ValueDuo, t1 and t2 should be filled up
                    for (var i = 0; i < _in2.Count; i++)
                    {
                        // check for every ValueDuo the cross_sum
                        if (_in2[i].CrossSum != round) continue;
                        switch (round)
                        {
                            case 0:
                                _t0.Add(i);
                                break;

                            case 1:
                                _t1.Add(i);
                                break;

                            case 2:
                                _t2.Add(i);
                                break;
                        }
                    }
                    break;

                case 3:
                    // ValueTrio, t1, t2 and t3 should be filled up
                    for (var i = 0; i < _in3.Count; i++)
                    {
                        // check for every ValueTrio the cross_sum
                        if (_in3[i].CrossSum != round) continue;
                        switch (round)
                        {
                            case 0:
                                _t0.Add(i);
                                break;

                            case 1:
                                _t1.Add(i);
                                break;

                            case 2:
                                _t2.Add(i);
                                break;

                            case 3:
                                _t3.Add(i);
                                break;
                        }
                    }
                    break;

                case 4:
                    // ValueQuartett, t1, t2, t3 and t4 should be filled up
                    for (var i = 0; i < _in4.Count; i++)
                    {
                        // check for every ValueTrio the cross_sum
                        if (_in4[i].CrossSum != round) continue;
                        switch (round)
                        {
                            case 0:
                                _t0.Add(i);
                                break;

                            case 1:
                                _t1.Add(i);
                                break;

                            case 2:
                                _t2.Add(i);
                                break;

                            case 3:
                                _t3.Add(i);
                                break;

                            case 4:
                                _t4.Add(i);
                                break;
                        }
                    }
                    break;

                case 5:
                    // ValueQuintett, t1, t2, t3, t4 and t5 should be filled up
                    for (var i = 0; i < _in5.Count; i++)
                    {
                        // check for every ValueTrio the cross_sum
                        if (_in5[i].CrossSum != round) continue;
                        switch (round)
                        {
                            case 0:
                                _t0.Add(i);
                                break;

                            case 1:
                                _t1.Add(i);
                                break;

                            case 2:
                                _t2.Add(i);
                                break;

                            case 3:
                                _t3.Add(i);
                                break;

                            case 4:
                                _t4.Add(i);
                                break;

                            case 5:
                                _t5.Add(i);
                                break;
                        }
                    }
                    break;

                case 6:
                    // ValueSextett, t1, t2, t3, t4, t5 and t6 should be filled up
                    for (var i = 0; i < _in6.Count; i++)
                    {
                        // check for every ValueTrio the cross_sum
                        if (_in6[i].CrossSum != round) continue;
                        switch (round)
                        {
                            case 0:
                                _t0.Add(i);
                                break;

                            case 1:
                                _t1.Add(i);
                                break;

                            case 2:
                                _t2.Add(i);
                                break;

                            case 3:
                                _t3.Add(i);
                                break;

                            case 4:
                                _t4.Add(i);
                                break;

                            case 5:
                                _t5.Add(i);
                                break;

                            case 6:
                                _t6.Add(i);
                                break;
                        }
                    }
                    break;
            }
        }

        public List<ValueDuo> GetDuo()
        {
            return _in2;
        }

        public List<ValueTrio> GetTrio()
        {
            return _in3;
        }

        public List<ValueQuartett> GetQuartett()
        {
            return _in4;
        }
    }
}