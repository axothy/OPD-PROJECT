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
    public partial class IntegralsForm : UserControl
    {
        public IntegralsForm()
        {
            InitializeComponent();
        }

        ExpressionParser myParse;
        Hashtable myHash;


        private void IntegralsForm_Load(object sender, EventArgs e)
        {

        }


        private void SolveIntegral_Click_1(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            {

            double a, b, h;
            int n;

                try
                {
                    myParse = new ExpressionParser();
                    myHash = new Hashtable();

                    a = double.Parse(aIntegralTextBox.Text);
                    b = double.Parse(bIntergalTextBox.Text);
                    n = int.Parse(NumberOfNodestextBox.Text);
                }

                catch (FormatException)
                {
                    MessageBox.Show("Неверно заданы данные. Советуем прочитать окно Помощи. \nЗначения узлов, границы интервала и прочее вводите без степеней, без дробей, без чисел PI, e и прочее, а численно. ", "Ошибка", MessageBoxButtons.OK);
                    return;
                }

            if ((!LeftChoose.Checked) && (!RightChoose.Checked) && (!MiddleChoose.Checked) && (!TrapezoidalChoose.Checked) && (!SimpsonChoose.Checked))
            {
                MessageBox.Show("Выберите метод. ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (n <= 0)
            {
                MessageBox.Show("Число узлов должно быть больше нуля! ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

                if (n >= 10000000)
                {
                    MessageBox.Show("Число узлов слишком большое! ", "Ошибка", MessageBoxButtons.OK);
                    return;
                }

                if (b < a)
            {
                MessageBox.Show("Ошибка в промежутке интегрирования ", "Ошибка", MessageBoxButtons.OK);
                return;
            }


            double errorFact;
            double x = a;
            double integral, integral_true = 0, integral_b = 0, integral_a = 0; //integral_true  - это точное значение интеграла

            StreamWriter fIntegral1 = new StreamWriter("[Метод левых прямоугольников]. Вычисления.txt");
            StreamWriter fIntegral2 = new StreamWriter("[Метод правых прямоугольников]. Вычисления.txt");
            StreamWriter fIntegral3 = new StreamWriter("[Метод средних прямоугольников]. Вычисления.txt");
            StreamWriter fIntegral4 = new StreamWriter("[Метод трапеций]. Вычисления.txt");
            StreamWriter fIntegral5 = new StreamWriter("[Метод Симпсона]. Вычисления.txt");

            if (MiddleChoose.Checked)
            {
                integral = 0;
                h = (b - a) / ((double)n);

                try
                {
                    for (int i = 0; i < n; i++)
                    {
                        x += h / 2;
                        myHash.Clear();
                        myHash.Add("x", x.ToString());
                        integral += myParse.Parse(txtBox_function.Text, myHash);
                        x += h / 2;
                    }
                }

                catch
                    {
                        fIntegral1.Close(); fIntegral2.Close(); fIntegral3.Close(); fIntegral4.Close(); fIntegral5.Close();
                        File.Delete("[Метод левых прямоугольников]. Вычисления.txt");
                        File.Delete("[Метод правых прямоугольников]. Вычисления.txt");
                        File.Delete("[Метод трапеций]. Вычисления.txt");
                        File.Delete("[Метод Симпсона]. Вычисления.txt");
                        File.Delete("[Метод средних прямоугольников]. Вычисления.txt");
                        MessageBox.Show("Неправильный ввод данных", "Ошибка", MessageBoxButtons.OK);
                    return;
                }

                integral = h * integral;

                Hashtable myHash1, myHash2;

                errorFact = 0;
                if (CheckIfNeedErrors.Checked)
                {
                    try
                    {
                        myHash1 = new Hashtable();
                        myHash2 = new Hashtable();

                        myHash1.Clear();
                        myHash2.Clear();

                        myHash1.Add("x", b.ToString());
                        myHash2.Add("x", a.ToString());
                        integral_b = myParse.Parse(txtBox_F.Text, myHash1);
                        integral_a = myParse.Parse(txtBox_F.Text, myHash2);
                        integral_true = integral_b - integral_a;
                        }

                    catch
                    {
                        fIntegral1.Close(); fIntegral2.Close(); fIntegral3.Close(); fIntegral4.Close(); fIntegral5.Close();
                        File.Delete("[Метод левых прямоугольников]. Вычисления.txt");
                        File.Delete("[Метод правых прямоугольников]. Вычисления.txt");
                        File.Delete("[Метод трапеций]. Вычисления.txt");
                        File.Delete("[Метод Симпсона]. Вычисления.txt");
                        File.Delete("[Метод средних прямоугольников]. Вычисления.txt");
                        MessageBox.Show("Скорее всего, вы не ввели первообразную для нахождения погрешностей", "Ошибка", MessageBoxButtons.OK);
                        return;
                    }
                    errorFact = Math.Abs(integral - integral_true);
                }


                fIntegral3.WriteLine("Функция      f(x) = " + txtBox_function.Text);
                fIntegral3.WriteLine("Промежуток: [" + a + ";" + b + "]");
                fIntegral3.WriteLine("Кол-во узлов " + n);
                fIntegral3.WriteLine("Вычисленный интеграл " + integral);

                if (CheckIfNeedErrors.Checked)
                {
                    fIntegral3.WriteLine("Погрешность " + errorFact);
                }
                fIntegral1.Close(); fIntegral2.Close(); fIntegral3.Close(); fIntegral4.Close(); fIntegral5.Close();

                File.Delete("[Метод левых прямоугольников]. Вычисления.txt");
                File.Delete("[Метод правых прямоугольников]. Вычисления.txt");
                File.Delete("[Метод трапеций]. Вычисления.txt");
                File.Delete("[Метод Симпсона]. Вычисления.txt");

                resultIntegral.Text = integral.ToString();
                if (CheckIfNeedErrors.Checked)
                {
                    resultError.Text = errorFact.ToString();
                }
                else
                {
                    resultError.Clear();
                }

                if (!checkIntegralIfNeedFile.Checked)
                {
                    File.Delete("[Метод средних прямоугольников]. Вычисления.txt");
                }
            }

            if (LeftChoose.Checked)
            {

                integral = 0;
                h = (b - a) / ((double)n);

                try
                {
                    for (int i = 0; i < n; i++)
                    {
                        myHash.Clear();
                        myHash.Add("x", x.ToString());
                        integral += myParse.Parse(txtBox_function.Text, myHash);
                        x += h;
                    }
                }

                catch
                {
                     fIntegral1.Close(); fIntegral2.Close(); fIntegral3.Close(); fIntegral4.Close(); fIntegral5.Close();
                     File.Delete("[Метод левых прямоугольников]. Вычисления.txt");
                     File.Delete("[Метод правых прямоугольников]. Вычисления.txt");
                     File.Delete("[Метод трапеций]. Вычисления.txt");
                     File.Delete("[Метод Симпсона]. Вычисления.txt");
                     File.Delete("[Метод средних прямоугольников]. Вычисления.txt");
                     MessageBox.Show("Неправильный ввод данных", "Ошибка", MessageBoxButtons.OK);
                    return;
                }

                integral = h * integral;

                Hashtable myHash1, myHash2;
                    errorFact = 0;
                    if (CheckIfNeedErrors.Checked)
                    {
                        try
                        {
                            myHash1 = new Hashtable();
                            myHash2 = new Hashtable();

                            myHash1.Clear();
                            myHash2.Clear();

                            myHash1.Add("x", b.ToString());
                            myHash2.Add("x", a.ToString());
                            integral_b = myParse.Parse(txtBox_F.Text, myHash1);
                            integral_a = myParse.Parse(txtBox_F.Text, myHash2);
                            integral_true = integral_b - integral_a;
                        }

                        catch
                        {
                            fIntegral1.Close(); fIntegral2.Close(); fIntegral3.Close(); fIntegral4.Close(); fIntegral5.Close();
                            File.Delete("[Метод левых прямоугольников]. Вычисления.txt");
                            File.Delete("[Метод правых прямоугольников]. Вычисления.txt");
                            File.Delete("[Метод трапеций]. Вычисления.txt");
                            File.Delete("[Метод Симпсона]. Вычисления.txt");
                            File.Delete("[Метод средних прямоугольников]. Вычисления.txt");
                            MessageBox.Show("Скорее всего, вы не ввели первообразную для нахождения погрешностей", "Ошибка", MessageBoxButtons.OK);
                            return;
                        }
                        errorFact = Math.Abs(integral - integral_true);
                    }

                fIntegral1.WriteLine("Функция      f(x) = " + txtBox_function.Text);
                fIntegral1.WriteLine("Промежуток: [" + a + ";" + b + "]");
                fIntegral1.WriteLine("Кол-во узлов " + n);
                fIntegral1.WriteLine("Вычисленный интеграл " + integral);
                fIntegral1.WriteLine("Погрешность " + errorFact);

                fIntegral1.Close(); fIntegral2.Close(); fIntegral3.Close(); fIntegral4.Close(); fIntegral5.Close();
                File.Delete("[Метод средних прямоугольников]. Вычисления.txt");
                File.Delete("[Метод правых прямоугольников]. Вычисления.txt");
                File.Delete("[Метод трапеций]. Вычисления.txt");
                File.Delete("[Метод Симпсона]. Вычисления.txt");

                resultIntegral.Text = integral.ToString();
                if (CheckIfNeedErrors.Checked)
                {
                    resultError.Text = errorFact.ToString();
                }
                else
                {
                    resultError.Clear();
                }

                if (!checkIntegralIfNeedFile.Checked)
                {
                    File.Delete("[Метод левых прямоугольников]. Вычисления.txt");
                }
            }

            if (RightChoose.Checked)
            {
                integral = 0;
                h = (b - a) / ((double)n);

                try
                {
                    for (int i = 0; i < n; i++)
                    {
                        x += h;
                        myHash.Clear();
                        myHash.Add("x", x.ToString());
                        integral += myParse.Parse(txtBox_function.Text, myHash);
                    }
                }

                catch
                {
                        fIntegral1.Close(); fIntegral2.Close(); fIntegral3.Close(); fIntegral4.Close(); fIntegral5.Close();
                        File.Delete("[Метод левых прямоугольников]. Вычисления.txt");
                        File.Delete("[Метод правых прямоугольников]. Вычисления.txt");
                        File.Delete("[Метод трапеций]. Вычисления.txt");
                        File.Delete("[Метод Симпсона]. Вычисления.txt");
                        File.Delete("[Метод средних прямоугольников]. Вычисления.txt");
                        MessageBox.Show("Неправильный ввод данных", "Ошибка", MessageBoxButtons.OK);
                    return;
                }

                integral = h * integral;

                Hashtable myHash1, myHash2;
                myHash1 = new Hashtable();
                myHash2 = new Hashtable();

                    errorFact = 0;
                    if (CheckIfNeedErrors.Checked)
                    {
                        try
                        {
                            myHash1 = new Hashtable();
                            myHash2 = new Hashtable();

                            myHash1.Clear();
                            myHash2.Clear();

                            myHash1.Add("x", b.ToString());
                            myHash2.Add("x", a.ToString());
                            integral_b = myParse.Parse(txtBox_F.Text, myHash1);
                            integral_a = myParse.Parse(txtBox_F.Text, myHash2);
                            integral_true = integral_b - integral_a;
                        }

                        catch
                        {
                            fIntegral1.Close(); fIntegral2.Close(); fIntegral3.Close(); fIntegral4.Close(); fIntegral5.Close();
                            File.Delete("[Метод левых прямоугольников]. Вычисления.txt");
                            File.Delete("[Метод правых прямоугольников]. Вычисления.txt");
                            File.Delete("[Метод трапеций]. Вычисления.txt");
                            File.Delete("[Метод Симпсона]. Вычисления.txt");
                            File.Delete("[Метод средних прямоугольников]. Вычисления.txt");
                            MessageBox.Show("Скорее всего, вы не ввели первообразную для нахождения погрешностей", "Ошибка", MessageBoxButtons.OK);
                            return;
                        }
                        errorFact = Math.Abs(integral - integral_true);
                    }


                fIntegral2.WriteLine("Функция      f(x) = " + txtBox_function.Text);
                fIntegral2.WriteLine("Промежуток: [" + a + ";" + b + "]");
                fIntegral2.WriteLine("Кол-во узлов " + n);
                fIntegral2.WriteLine("Вычисленный интеграл " + integral);
                fIntegral2.WriteLine("Погрешность " + errorFact);

                fIntegral1.Close(); fIntegral2.Close(); fIntegral3.Close(); fIntegral4.Close(); fIntegral5.Close();
                File.Delete("[Метод средних прямоугольников]. Вычисления.txt");
                File.Delete("[Метод левых прямоугольников]. Вычисления.txt");
                File.Delete("[Метод трапеций]. Вычисления.txt");
                File.Delete("[Метод Симпсона]. Вычисления.txt");

                resultIntegral.Text = integral.ToString();

                if (CheckIfNeedErrors.Checked)
                {
                    resultError.Text = errorFact.ToString();
                }
                else
                {
                    resultError.Clear();
                }

                if (!checkIntegralIfNeedFile.Checked)
                {
                    File.Delete("[Метод правых прямоугольников]. Вычисления.txt");
                }
            }


            if (TrapezoidalChoose.Checked)
            {
                    integral = 0;
                    h = (b - a) / ((double)n);

                    Hashtable myHash1, myHash2, myHash3;
                    myHash1 = new Hashtable();
                    myHash2 = new Hashtable();
                    myHash3 = new Hashtable();

                    try
                    {
                        for (int step = 0; step < n; step++)
                        {
                            myHash.Clear();
                            myHash.Add("x", (a+step*h).ToString());
                            integral += 2 * myParse.Parse(txtBox_function.Text, myHash);
                        }
                        integral *= h / 2;
                    }

                    catch
                    {
                        fIntegral1.Close(); fIntegral2.Close(); fIntegral3.Close(); fIntegral4.Close(); fIntegral5.Close();
                        File.Delete("[Метод левых прямоугольников]. Вычисления.txt");
                        File.Delete("[Метод правых прямоугольников]. Вычисления.txt");
                        File.Delete("[Метод трапеций]. Вычисления.txt");
                        File.Delete("[Метод Симпсона]. Вычисления.txt");
                        File.Delete("[Метод средних прямоугольников]. Вычисления.txt");
                        MessageBox.Show("Неправильный ввод данных", "Ошибка", MessageBoxButtons.OK);
                        return;
                    }

                    Hashtable myHash4, myHash5;
                    errorFact = 0;
                    if (CheckIfNeedErrors.Checked)
                    {
                        try
                        {
                            myHash4 = new Hashtable();
                            myHash5 = new Hashtable();

                            myHash4.Clear();
                            myHash5.Clear();

                            myHash4.Add("x", b.ToString());
                            myHash5.Add("x", a.ToString());
                            integral_b = myParse.Parse(txtBox_F.Text, myHash4);
                            integral_a = myParse.Parse(txtBox_F.Text, myHash5);
                            integral_true = integral_b - integral_a;
                        }

                        catch
                        {
                            fIntegral1.Close(); fIntegral2.Close(); fIntegral3.Close(); fIntegral4.Close(); fIntegral5.Close();
                            File.Delete("[Метод левых прямоугольников]. Вычисления.txt");
                            File.Delete("[Метод правых прямоугольников]. Вычисления.txt");
                            File.Delete("[Метод трапеций]. Вычисления.txt");
                            File.Delete("[Метод Симпсона]. Вычисления.txt");
                            File.Delete("[Метод средних прямоугольников]. Вычисления.txt");
                            MessageBox.Show("Скорее всего, вы не ввели первообразную для нахождения погрешностей", "Ошибка", MessageBoxButtons.OK);
                            return;
                        }
                        errorFact = Math.Abs(integral - integral_true);
                    }

                    fIntegral5.WriteLine("Функция      f(x) = " + txtBox_function.Text);
                    fIntegral5.WriteLine("Промежуток: [" + a + ";" + b + "]");
                    fIntegral5.WriteLine("Кол-во узлов " + n);
                    fIntegral5.WriteLine("Вычисленный интеграл " + integral);
                    fIntegral5.WriteLine("Погрешность " + errorFact);

                    fIntegral1.Close(); fIntegral2.Close(); fIntegral3.Close(); fIntegral4.Close(); fIntegral5.Close();
                    File.Delete("[Метод средних прямоугольников]. Вычисления.txt");
                    File.Delete("[Метод правых прямоугольников]. Вычисления.txt");
                    File.Delete("[Метод Cимпсона]. Вычисления.txt");
                    File.Delete("[Метод левых прямоугольников]. Вычисления.txt");

                    resultIntegral.Text = integral.ToString();

                    if (CheckIfNeedErrors.Checked)
                    {
                        resultError.Text = errorFact.ToString();
                    }
                    else
                    {
                        resultError.Clear();
                    }

                    if (!checkIntegralIfNeedFile.Checked)
                    {
                        File.Delete("[Метод трапеций]. Вычисления.txt");
                    }
                }


            if (SimpsonChoose.Checked)
            {
                integral = 0;
                h = (b - a) / ((double)n);

                  Hashtable myHash1, myHash2, myHash3;
                  myHash1 = new Hashtable();
                  myHash2 = new Hashtable();
                  myHash3 = new Hashtable();

                    try
                    {
                        for (int step = 0; step < n; step++)
                        {
                            double x1 = a + step * h;
                            double x2 = a + (step + 1) * h;
                            myHash1.Clear(); myHash2.Clear(); myHash3.Clear();

                            myHash1.Add("x", x1.ToString());
                            myHash2.Add("x", (0.5 * (x1 + x2)).ToString());
                            myHash3.Add("x", x2.ToString());

                            integral += (x2 - x1) / 6.0 * (myParse.Parse(txtBox_function.Text, myHash1) + 4.0 * myParse.Parse(txtBox_function.Text, myHash2) + myParse.Parse(txtBox_function.Text, myHash3));
                        }
                    }

                catch
                    {
                        fIntegral1.Close(); fIntegral2.Close(); fIntegral3.Close(); fIntegral4.Close(); fIntegral5.Close();
                        File.Delete("[Метод левых прямоугольников]. Вычисления.txt");
                        File.Delete("[Метод правых прямоугольников]. Вычисления.txt");
                        File.Delete("[Метод трапеций]. Вычисления.txt");
                        File.Delete("[Метод Симпсона]. Вычисления.txt");
                        File.Delete("[Метод средних прямоугольников]. Вычисления.txt");
                        MessageBox.Show("Неправильный ввод данных", "Ошибка", MessageBoxButtons.OK);
                        return;
                    }

                    Hashtable myHash4, myHash5;
                    errorFact = 0;
                    if (CheckIfNeedErrors.Checked)
                    {
                        try
                        {
                            myHash4 = new Hashtable();
                            myHash5 = new Hashtable();

                            myHash4.Clear();
                            myHash5.Clear();

                            myHash4.Add("x", b.ToString());
                            myHash5.Add("x", a.ToString());
                            integral_b = myParse.Parse(txtBox_F.Text, myHash4);
                            integral_a = myParse.Parse(txtBox_F.Text, myHash5);
                            integral_true = integral_b - integral_a;
                        }

                        catch
                        {
                            fIntegral1.Close(); fIntegral2.Close(); fIntegral3.Close(); fIntegral4.Close(); fIntegral5.Close();
                            File.Delete("[Метод левых прямоугольников]. Вычисления.txt");
                            File.Delete("[Метод правых прямоугольников]. Вычисления.txt");
                            File.Delete("[Метод трапеций]. Вычисления.txt");
                            File.Delete("[Метод Симпсона]. Вычисления.txt");
                            File.Delete("[Метод средних прямоугольников]. Вычисления.txt");
                            MessageBox.Show("Скорее всего, вы не ввели первообразную для нахождения погрешностей", "Ошибка", MessageBoxButtons.OK);
                            return;
                        }
                        errorFact = Math.Abs(integral - integral_true);
                    }

                fIntegral5.WriteLine("Функция      f(x) = " + txtBox_function.Text);
                fIntegral5.WriteLine("Промежуток: [" + a + ";" + b + "]");
                fIntegral5.WriteLine("Кол-во узлов " + n);
                fIntegral5.WriteLine("Вычисленный интеграл " + integral);
                fIntegral5.WriteLine("Погрешность " + errorFact);

                fIntegral1.Close(); fIntegral2.Close(); fIntegral3.Close(); fIntegral4.Close(); fIntegral5.Close();
                File.Delete("[Метод средних прямоугольников]. Вычисления.txt");
                File.Delete("[Метод правых прямоугольников]. Вычисления.txt");
                File.Delete("[Метод трапеций]. Вычисления.txt");
                File.Delete("[Метод левых прямоугольников]. Вычисления.txt");

                    resultIntegral.Text = integral.ToString();

                    if (CheckIfNeedErrors.Checked)
                    {
                        resultError.Text = errorFact.ToString();
                    }
                    else
                    {
                        resultError.Clear();
                    }

                    if (!checkIntegralIfNeedFile.Checked)
                    {
                        File.Delete("[Метод Симпсона]. Вычисления.txt");
                    }
                }
        }
    }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NumberOfNodestextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultIntegral_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrapezoidalChoose_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
