using System;
using System.Windows.Forms;

namespace LogicSimplifier
{
    public partial class MainForm : Form
    {
        public static bool Debug;
        public static Debug DebugForm = new Debug();

        public static About AboutWindow = new About();
        public static Dnf DnfWindow = new Dnf();
        public static Kv KvWindow = new Kv();
        public static OutputDnf OutputWindow = new OutputDnf();

        //public static EE eeWindow = new EE();
        public static Ee EeWindow;

        public MainForm()
        {
            InitializeComponent();
            DebugForm.Activate();
            DebugForm.Visible = false;
        }

        private void OnKey(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode);
            Console.WriteLine(e.Modifiers);
            if (!(e.KeyCode == Keys.D && e.Shift && e.Control))
                return;

            DebugForm.AddLine("ButtonClick: MainForm - Debug");
            if (!Debug)
            {
                about.Text = @"Über (Debug)";
                Debug = true;
                DebugForm.Visible = true;
            }
            else if (Debug)
            {
                about.Text = @"Über";
                Debug = false;
                DebugForm.Visible = false;
            }
        }

        private void DNFtoQMC_Click(object sender, EventArgs e)
        {
            DebugForm.AddLine("ButtonClick: MainForm - DNFtoQMC");

            if (DnfWindow.Visible)
                DnfWindow.Hide();
            else
            {
                DnfWindow = new Dnf();
                DnfWindow.Show();
            }
        }

        private void KVtoQMC_Click(object sender, EventArgs e)
        {
            DebugForm.AddLine("ButtonClick: MainForm - KVtoQMC");

            if (KvWindow.Visible)
                KvWindow.Hide();
            else
            {
                KvWindow = new Kv();
                KvWindow.Show();
            }
        }

        private void about_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DebugForm.AddLine("ButtonClick: MainForm - About");

                if (AboutWindow.Visible)
                    AboutWindow.Hide();
                else
                {
                    AboutWindow = new About();
                    AboutWindow.Show();
                }
            }
            /*if (e.Button == MouseButtons.Right && false)
            {
                DebugForm.AddLine("ButtonClick: MainForm - Debug");
                if (!_debug)
                {
                    about.Text = "Über (Debug)";
                    _debug = true;
                    DebugForm.Visible = true;
                }
                else if (_debug)
                {
                    about.Text = "Über";
                    _debug = false;
                    DebugForm.Visible = false;
                }
            }*/
            /*if (e.Button == MouseButtons.Right && false)
            {
                if (eeWindow.Visible)
                    eeWindow.Hide();
                else
                {
                    eeWindow = new EE();
                    eeWindow.Show();
                }
            }*/
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}