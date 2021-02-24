using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
 (
      int nLeftRect,
      int nTopRect,
      int nRightRect,
      int nBottomRect,
      int nWidthEllipse,
         int nHeightEllipse

  );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panel1.Height = button1.Height;
            panel1.Top = button1.Top;
            panel1.Left = button1.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Height = button1.Height;
            panel1.Top = button1.Top;
            panel1.Left = button1.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Height = button2.Height;
            panel1.Top = button2.Top;
            panel1.Left = button2.Left;
            button2.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Height = button3.Height;
            panel1.Top = button3.Top;
            panel1.Left = button3.Left;
            button3.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
