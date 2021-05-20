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
    public partial class EquationsForm : UserControl
    {
        public EquationsForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelNewton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EquationsForm_Load(object sender, EventArgs e)
        {

        }

        private void mpdMethod1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newtonMethod1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mpdMethod1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            secantMethod1.BringToFront();
        }
    }
}
