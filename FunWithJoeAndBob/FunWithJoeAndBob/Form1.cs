﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithJoeAndBob
{
    public partial class Form1 : Form
    {
        private Guy joe;
        private Guy bob;
        private int bank = 100;

        public void UpdateForm()
        {
            JoesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            BobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            BanksCashLabel.Text = "The bank has $" + bank;
        }

        public Form1()
        {
            InitializeComponent();

            bob = new Guy()
            {
                Name = "Bob",
                Cash = 100,
            };

            joe = new Guy()
            {
                Name = "Joe",
                Cash = 50,
            };

            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            if (joe.Cash >= 10)
            {
                bob.Cash += bob.ReceiveCash(joe.GiveCash(10));
                UpdateForm();
            }
            else
            {
                MessageBox.Show("There is not enought money...");
            }
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            if (bob.Cash >= 5)
            {
                joe.ReceiveCash(bob.GiveCash(5));
                UpdateForm();
            }
            else
            {
                MessageBox.Show("there is not enought money...");
            }
        }
    }
}
