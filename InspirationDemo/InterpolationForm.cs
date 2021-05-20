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

    public partial class InterpolationForm : UserControl
    {

        public InterpolationForm()
        {
            InitializeComponent();
        }

        ExpressionParser myParse;
        Hashtable myHash1, myHash2;

        private void InterpolationForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //HelpPolynome metodichkap = new HelpPolynome();
           // metodichkap.ShowDialog();
        }

        private void Interpolate_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            xAnswer.Text = "";
            yAnswer.Text = "";
            resultError.Text = "";

            double a, b, h;
            int n;

            try
            {
                myParse = new ExpressionParser();
                myHash1 = new Hashtable();
                myHash2 = new Hashtable();

                a = double.Parse(aInterpolate.Text);
                b = double.Parse(bInterpolate.Text);

                n = int.Parse(nTxtBox.Text);
            }

            catch (FormatException)
            {
                MessageBox.Show("Неверно заданы данные. Советуем прочитать окно Помощи. ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if ((!LagrangeChoose.Checked) && (!NewtonChoose.Checked) && (!HermitChoose.Checked))
            {
                MessageBox.Show("Выберите полином. ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if ((!ChebyshevGridChoose.Checked) && (!StandartGridChoose.Checked))
            {
                MessageBox.Show("Выберите сетку. ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (b < a)
            {
                MessageBox.Show("Ошибка в промежутке ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (n<=0)
            {
                MessageBox.Show("Число n должно быть больше 0 ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (n>200)
            {
                MessageBox.Show("Число узлов не должно превышать 200 (Иначе полиномы будут сильно расходиться). ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            h = (b - a) / (n - 1);

            double[] x = new double[n];
            double[] y = new double[n];

            //Предварительное вычисление размера массива для массива ошибок
            double g = a;
            int o = 0;
            do
            {
                g = g + 0.01;
                o++;
            } while (g <= b);

            double[] err = new double[o];

            if (StandartGridChoose.Checked)
            {
                try
                {
                    for (int i = 0; i < n; i++)
                    {
                        myHash1.Clear();
                        x[i] = a + h * i;
                        myHash1.Add("x", x[i].ToString());
                        y[i] = myParse.Parse(txtBox_function.Text, myHash1);
                    }
                }

                catch
                {
                    // fDiffEq1.Close(); fDiffEq2.Close(); fDiffEq3.Close(); fDiffEq4.Close(); fDiffEq5.Close();
                    // File.Delete("[Метод Эйлера]. Вычисления.txt");
                    // File.Delete("[Метод РК-2]. Вычисления.txt");
                    // File.Delete("[Метод РК-3]. Вычисления.txt");
                    //File.Delete("[Метод РК-4]. Вычисления.txt");
                    MessageBox.Show("Неправильный ввод данных", "Ошибка", MessageBoxButtons.OK);
                    return;
                }
            }

            if (ChebyshevGridChoose.Checked)
            {
                try
                {
                    for (int i = 0; i < n; i++)
                    {
                        myHash1.Clear();
                        x[i] = (((a + b) / 2) + ((b - a) / 2) * Math.Cos(((Math.PI * (2 * i + 1)) / (2 * n + 2))));
                        myHash1.Add("x", x[i].ToString());
                        y[i] = myParse.Parse(txtBox_function.Text, myHash1);
                    }
                }

                catch
                {
                    // fDiffEq1.Close(); fDiffEq2.Close(); fDiffEq3.Close(); fDiffEq4.Close(); fDiffEq5.Close();
                    // File.Delete("[Метод Эйлера]. Вычисления.txt");
                    // File.Delete("[Метод РК-2]. Вычисления.txt");
                    // File.Delete("[Метод РК-3]. Вычисления.txt");
                    //File.Delete("[Метод РК-4]. Вычисления.txt");
                    MessageBox.Show("Неправильный ввод данных", "Ошибка", MessageBoxButtons.OK);
                    return;
                }
            }


            if (NewtonChoose.Checked)
            {
                double t;
                t = a;
                int m;
                m = 0;
                do
                {
                    double divided_difference = 0;
                    double summ = 0;
                    for (int k = 1; k < n; k++)
                    {
                        //Подсчет разделенных разностей
                        divided_difference = 0;
                        for (int i = 0; i <= k; i++)
                        {
                            double p = 1;
                            for (int j = 0; j <= k; j++)
                            {
                                if (j != i)
                                    p = p * (x[i] - x[j]);
                            }
                            divided_difference = divided_difference + y[i] / p;
                        }

                        //Произведение слагаемых П(x-xi) и разделенных разностей
                        for (int i = 0; i < k; i++)
                            divided_difference = divided_difference * (t - x[i]);
                        summ = summ + divided_difference; //Суммирование и получение полинома Ньютона
                    }

                    summ = (y[0] + summ);

                    
                    xAnswer.AppendText(t + "\n");
                    yAnswer.AppendText(summ + "\n");

                    if (CheckIfNeedErrors.Checked)
                    {
                        myHash1.Clear();
                        myHash1.Add("x", t.ToString());

                        err[m] = Math.Abs(summ - myParse.Parse(txtBox_function.Text, myHash1));
                    }
                    t = t + 0.01;
                    m++;

                } while (t <= b);

                if (CheckIfNeedErrors.Checked)
                {
                    double max_err = err[0];
                    for (int l = 1; l < n; l++)
                    {
                        if (max_err < err[l])
                            max_err = err[l];
                    }

                    resultError.Text = max_err.ToString();
                }
            }

            if (HermitChoose.Checked)
            {
                double[] dy = new double[n];
                const double delta = 1e-15;

                for (int i = 0; i < n; i++) {
                    myHash1.Clear(); myHash2.Clear();
                    myHash1.Add("x", (x[i] + delta).ToString());
                    myHash2.Add("x", (x[i] - delta).ToString());

                    dy[i] = (myParse.Parse(txtBox_function.Text, myHash1) - myParse.Parse(txtBox_function.Text, myHash2)) / (2.0 * delta);
                }

                double t;
                t = a;
                int m;
                m = 0;
                do
                {
                    double sum = 0;
                    double prod = 1;
                    double res = 0;

                    for (int j = 0; j < n; j++)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            if (k == j)
                                continue;
                            sum += (t - x[j]) / (x[j] - x[k]);
                            prod *= (t - x[k]) / (x[j] - x[k]) * (t - x[k]) / (x[j] - x[k]);
                        }
                        res += ((t - x[j]) * dy[j] + (1 - 2 * sum) * y[j]) * prod;
                        sum = 0;
                        prod = 1;
                    }

                    xAnswer.AppendText(t + "\n");
                    yAnswer.AppendText(res + "\n");

                    if (CheckIfNeedErrors.Checked)
                    {
                        myHash1.Clear();
                        myHash1.Add("x", t.ToString());

                        err[m] = Math.Abs(res - myParse.Parse(txtBox_function.Text, myHash1));
                    }
                    t = t + 0.01;
                    m++;

                } while (t <= b);

                if (CheckIfNeedErrors.Checked)
                {
                    double max_err = err[0];
                    for (int l = 1; l < n; l++)
                    {
                        if (max_err < err[l])
                            max_err = err[l];
                    }

                    resultError.Text = max_err.ToString();
                }
            }

            if (LagrangeChoose.Checked)
            {
                double t;
                t = a;
                int m;
                m = 0;
                do
                {
                    double summ = 0;
                    for (int i = 0; i < n; ++i)
                    {

                        double l = 1;
                        for (int j = 0; j < n; ++j)
                            if (j != i)
                                l *= (t - x[j]) / (x[i] - x[j]);
                        summ += y[i] * l;
                    }

                    xAnswer.AppendText(t + "\n");
                    yAnswer.AppendText(summ + "\n");

                    if (CheckIfNeedErrors.Checked)
                    {
                        myHash1.Clear();
                        myHash1.Add("x", t.ToString());

                        err[m] = Math.Abs(summ - myParse.Parse(txtBox_function.Text, myHash1));
                    }
                    t = t + 0.01;
                    m++;

                } while (t <= b);

                if (CheckIfNeedErrors.Checked)
                {
                    double max_err = err[0];
                    for (int l = 1; l < n; l++)
                    {
                        if (max_err < err[l])
                            max_err = err[l];
                    }

                    resultError.Text = max_err.ToString();
                }
            }


        }
    }
}

