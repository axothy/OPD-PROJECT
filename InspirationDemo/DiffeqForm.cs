using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using info.lundin.math;
using System.Collections;

namespace InspirationDemo
{
    public partial class DiffeqForm : UserControl
    {
        public DiffeqForm()
        {
            InitializeComponent();
        }

        ExpressionParser myParse;
        Hashtable myHash1;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DiffeqForm_Load(object sender, EventArgs e)
        {

        }

        private void SolveDiffeq_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            xAnswer.Text = "";
            yAnswer.Text = "";
            resultError.Text = "";

            double a, b, x0, y0, h, x1, y1;

            try
            {
                myParse = new ExpressionParser();
                myHash1 = new Hashtable();

                a = double.Parse(aDiffeq.Text);
                b = double.Parse(bDiffeq.Text);
                h = double.Parse(step.Text);

                x0 = double.Parse(x0TxtBox.Text);
                y0 = double.Parse(y0TxtBox.Text);
            }

            catch (FormatException)
            {
                MessageBox.Show("Неверно заданы данные. Советуем прочитать окно Помощи. ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if ((!EulerChoose.Checked) && (!RK2Choose.Checked) && (!RK3Choose.Checked) && (!RK4Choose.Checked))
            {
                MessageBox.Show("Выберите метод. ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (b < a)
            {
                MessageBox.Show("Ошибка в промежутке интегрирования ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (h > 2)
            {
                MessageBox.Show("Шаг интегрирования слишком грубый ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (h < 0.0001)
            {
                MessageBox.Show("Шаг интегрирования слишком мал ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (h == 0 || h < 0)
            {
                MessageBox.Show("Шаг интегрирования должен быть больше нуля ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            double K1, K2, K3, K4, K5, max_err;
            int N;

            int k;
            double xnext, xcurr;
            xcurr = x0;
            for (k = 1; xcurr < b; k++)
            {
                xnext = xcurr + h;
                xcurr = xnext;
            }

            N = k;
            double[] err = new double[N];

            
            if (EulerChoose.Checked)
            {

                k = 0;
                try
                {
                    for (int i = 1; x0 < b; i++)
                    {
                        myHash1.Clear();

                        myHash1.Add("x", x0.ToString());
                        myHash1.Add("y", y0.ToString());

                        y1 = y0 + h * myParse.Parse(txtBox_function.Text, myHash1);
                        x1 = x0 + h;

                        xAnswer.AppendText(x1 + "\n");
                        yAnswer.AppendText(y1 + "\n");

                        myHash1.Clear();
                        myHash1.Add("x", x1.ToString());
                        if (CheckIfNeedErrors.Checked)
                        {
                            err[k]= Math.Abs(y1 - myParse.Parse(txtBox_Analytical.Text, myHash1));
                        }
                        x0 = x1;
                        y0 = y1;
                        k++;
                    }

                    if (CheckIfNeedErrors.Checked)
                    {
                        max_err = err[0];
                        for (int i = 1; i < k; i++)
                        {
                            if (max_err < err[i])
                                max_err = err[i];
                        }

                        resultError.Text = max_err.ToString();
                    }

                    else
                    {
                        resultError.Clear();
                    }

                }

                catch
                {
                    MessageBox.Show("Неправильный ввод данных", "Ошибка", MessageBoxButtons.OK);
                    return;
                }

            }

            
            if (RK2Choose.Checked)
            {
                k = 0;
                try
                {
                    x0 = a;
                    for (int i = 1; x0 < b; i++)
                    {
                        myHash1.Clear();

                        myHash1.Add("x", x0.ToString());
                        myHash1.Add("y", y0.ToString());

                        K1 = h * myParse.Parse(txtBox_function.Text, myHash1);

                        myHash1.Clear();
                        myHash1.Add("x", (x0 + h / 2.0).ToString());
                        myHash1.Add("y", (y0 + K1 / 2.0).ToString());

                        K2 = h * myParse.Parse(txtBox_function.Text, myHash1);

                        x1 = x0 + h;
                        y1 = y0 + K2;

                        xAnswer.AppendText(x1 + "\n");
                        yAnswer.AppendText(y1 + "\n");

                        myHash1.Clear();
                        myHash1.Add("x", x1.ToString());
                        if (CheckIfNeedErrors.Checked)
                        {
                            err[k] = Math.Abs(y1 - myParse.Parse(txtBox_Analytical.Text, myHash1));
                        }

                        x0 = x1;
                        y0 = y1;
                        k++;
                    }

                    if (CheckIfNeedErrors.Checked)
                    {
                        max_err = err[0];
                        for (int i = 1; i < k; i++)
                        {
                            if (max_err < err[i])
                                max_err = err[i];
                        }

                        resultError.Text = max_err.ToString();
                    }

                    else
                    {
                        resultError.Clear();
                    }
                }

                catch
                {
                    MessageBox.Show("Неправильный ввод данных", "Ошибка", MessageBoxButtons.OK);
                    return;
                }


            }

            if (RK3Choose.Checked)
            {
                k = 0;
                try
                {
                    for (int i = 1; x0 < b; i++)
                    {
                        myHash1.Clear();

                        myHash1.Add("x", x0.ToString());
                        myHash1.Add("y", y0.ToString());

                        K1 = h * myParse.Parse(txtBox_function.Text, myHash1);

                        myHash1.Clear();
                        myHash1.Add("x", (x0 + h / 2.0).ToString());
                        myHash1.Add("y", (y0 + K1 / 2.0).ToString());

                        K2 = h * myParse.Parse(txtBox_function.Text, myHash1);

                        myHash1.Clear();
                        myHash1.Add("x", (x0 + h).ToString());
                        myHash1.Add("y", (y0 + 2.0 * K2 - K1).ToString());

                        K3 = h * myParse.Parse(txtBox_function.Text, myHash1);

                        x1 = x0 + h;
                        y1 = y0 + (K1 + 4 * K2 + K3) / 6.0;

                        xAnswer.AppendText(x1 + "\n");
                        yAnswer.AppendText(y1 + "\n");

                        myHash1.Clear();
                        myHash1.Add("x", x1.ToString());
                        if (CheckIfNeedErrors.Checked)
                        {
                            err[k] = Math.Abs(y1 - myParse.Parse(txtBox_Analytical.Text, myHash1));
                        }

                        x0 = x1;
                        y0 = y1;
                        k++;
                    }

                    if (CheckIfNeedErrors.Checked)
                    {
                        max_err = err[0];
                        for (int i = 1; i < k; i++)
                        {
                            if (max_err < err[i])
                                max_err = err[i];
                        }

                        resultError.Text = max_err.ToString();
                    }

                    else
                    {
                        resultError.Clear();
                    }
                }

                catch
                {
                    MessageBox.Show("Неправильный ввод данных", "Ошибка", MessageBoxButtons.OK);
                    return;
                }
            }

            if (RK4Choose.Checked)
            {
                k = 0;
                try
                {
                    for (int i = 1; x0 < b; i++)
                    {
                        myHash1.Clear();

                        myHash1.Add("x", x0.ToString());
                        myHash1.Add("y", y0.ToString());

                        K1 = h * myParse.Parse(txtBox_function.Text, myHash1);

                        myHash1.Clear();
                        myHash1.Add("x", (x0 + h / 2.0).ToString());
                        myHash1.Add("y", (y0 + K1 / 2.0).ToString());

                        K2 = h * myParse.Parse(txtBox_function.Text, myHash1);

                        myHash1.Clear();
                        myHash1.Add("x", (x0 + h / 2.0).ToString());
                        myHash1.Add("y", (y0 + K2 / 2.0).ToString());

                        K3 = h * myParse.Parse(txtBox_function.Text, myHash1);

                        myHash1.Clear();
                        myHash1.Add("x", (x0 + h).ToString());
                        myHash1.Add("y", (y0 + K3).ToString());

                        K4 = h * myParse.Parse(txtBox_function.Text, myHash1);

                        x1 = x0 + h;
                        y1 = y0 + (K1 + 2 * K2 + 2 * K3 + K4) / 6.0;

                        xAnswer.AppendText(x1 + "\n");
                        yAnswer.AppendText(y1 + "\n");

                        myHash1.Clear();
                        myHash1.Add("x", x1.ToString());
                        if (CheckIfNeedErrors.Checked)
                        {
                            err[k] = Math.Abs(y1 - myParse.Parse(txtBox_Analytical.Text, myHash1));
                        }

                        x0 = x1;
                        y0 = y1;
                        k++;
                    }

                    if (CheckIfNeedErrors.Checked)
                    {
                        max_err = err[0];
                        for (int i = 1; i < k; i++)
                        {
                            if (max_err < err[i])
                                max_err = err[i];
                        }

                        resultError.Text = max_err.ToString();
                    }

                    else
                    {
                        resultError.Clear();
                    }
                }

                catch
                {
                    MessageBox.Show("Неправильный ввод данных", "Ошибка", MessageBoxButtons.OK);
                    return;
                }
            }

        }
    }
}
