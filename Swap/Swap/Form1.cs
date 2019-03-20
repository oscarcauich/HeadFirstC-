using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap
{
    public partial class Form1 : Form
    {
        Elephant Lucinda;
        Elephant Lloyd;
        public Form1()
        {
            InitializeComponent();
            Lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lloyd.whoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lucinda.whoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = Lucinda;
            Lucinda = Lloyd;
            Lloyd = holder;
            MessageBox.Show("Objects swap");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lloyd.TellMe("Hi", Lucinda);

            Lloyd.SpeakTo(Lucinda, "Hello");

            Lloyd = Lucinda;
            Lloyd.EarSize = 4321;
            Lloyd.whoAmI();
        }
    }
}
