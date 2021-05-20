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


namespace InspirationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            help1.BringToFront();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void equationsForm1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            MainSidePanel.Height = button1.Height;
            MainSidePanel.Top = button1.Top;
            equationsForm1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainSidePanel.Height = button2.Height;
            MainSidePanel.Top = button2.Top;
            integralsForm1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainSidePanel.Height = button3.Height;
            MainSidePanel.Top = button3.Top;
            slauForm1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainSidePanel.Height = button4.Height;
            MainSidePanel.Top = button4.Top;
            interpolationForm1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainSidePanel.Height = button5.Height;
            MainSidePanel.Top = button5.Top;
            diffeqForm1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainSidePanel.Height = button6.Height;
            MainSidePanel.Top = button6.Top;
            help1.BringToFront();
        }

        private void integralsForm1_Load(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //createMatrix1.BringToFront();
        }

        private void home1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
