using System;
using System.Windows.Forms;

namespace LogicSimplifier
{
    public partial class OutputDnf : Form
    {
        public OutputDnf()
        {
            InitializeComponent();
        }

        private static string[] _lines = new string[20];

        public void SetString(string[] input)
        {
            _lines = input;
            label1.Text = "";
            foreach (var t in _lines)
            {
                label1.Text += t + Environment.NewLine;
            }
        }

        public void AddLine(string line)
        {
            if (_lines[23] != "")
            {
                for (var i = 0; i < _lines.Length - 1; i++)
                {
                    _lines[i] = _lines[i + 1];
                }
                _lines[_lines.Length - 1] = line;
                SetString(_lines);
            }
            else
            {
                for (var i = 0; (i < _lines.Length); i++)
                {
                    if (_lines[i] != "") continue;

                    _lines[i] = line;
                    SetString(_lines);
                    return;
                }
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}