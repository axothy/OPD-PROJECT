using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspirationDemo
{
    public partial class Help : UserControl
    {
        public Help()
        {
            InitializeComponent();
            faQ_Main1.BringToFront();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            faQ_Equations1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            faQ_Main1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            faQ_Integrals1.BringToFront();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            faQ_Main1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            faQ_Diffequations1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            faQ_Interpolation1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            faQ_SLAE1.BringToFront();
        }
    }
}
