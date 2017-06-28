using System;
using System.Windows.Forms;

namespace LogicSimplifier
{
    public partial class About : Form
    {
        private string _version = "";
        private string _data = "";

        public About()
        {
            InitializeComponent();
            SetAbout();
        }

        private void SetAbout()
        {
            _version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            _data =
@"Version " + _version + @"

This program is free software

Copyright (c) 2016 by ReisfresseDE

reisfressede@gmail.com";
            label3.Text = _data;
        }

        private void About_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}