﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sloppy_Joe_s_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MenuMaker1 menu = new MenuMaker1() { Randomizer = new Random()};

            label1.Text = menu.GetMenuItem();
            label2.Text = menu.GetMenuItem();
            label3.Text = menu.GetMenuItem();
            label4.Text = menu.GetMenuItem();
            label5.Text = menu.GetMenuItem();
            label6.Text = menu.GetMenuItem();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
