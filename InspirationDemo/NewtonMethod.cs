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
    public partial class NewtonMethod : UserControl
    {
        public NewtonMethod()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewtonMethod_Load(object sender, EventArgs e)
        {

        }

        int iter;
        int ariphmetic_operations;
        int st;
        double epsilon;
        double x0, x1;
        double fx, dfx, temp, t;

        int test;

        private void linkNewton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkNewton_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HelpNewton metodichka1 = new HelpNewton();
            metodichka1.ShowDialog();
        }

        ExpressionParser myParse;
        Hashtable myHash;

        public int check_Newton()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            fx = dfx = 0;

            try
            {

                myHash.Clear();
                myHash.Add("x", x0.ToString());
                fx = myParse.Parse(txtBoxNewton_eq.Text, myHash);
                dfx = myParse.Parse(txtBoxNewton_diffeq.Text, myHash);


                if (double.IsNaN(fx) || double.IsNaN(dfx) || double.IsInfinity(fx) || double.IsInfinity(dfx) || dfx == 0) //Возможно тут ошибка
                {
                    MessageBox.Show("В данных точках функция бесконечна или неопределена!", "Ошибка в начальных приближениях", MessageBoxButtons.OK);
                    return 1;
                }

            }

            catch
            {
                MessageBox.Show("Неправильный ввод данных. \nПримечание: используйте точку для ввода десятичного числа,\nа также вводите просто функцию без =0. ", "Ошибка", MessageBoxButtons.OK);
                return 1;
            }

            return 0;
        }

        private void buttonSolveNewton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            StreamWriter fNewton = new StreamWriter("[Метод Ньютона]. Вычисления.txt");

            fNewton.WriteLine("МЕТОД НЬЮТОНА РЕШЕНИЯ НЕЛИНЕЙНОГО УРАВНЕНИЯ");

            iter = 0;

            try
            {
                myParse = new ExpressionParser();
                myHash = new Hashtable();

                x0 = double.Parse(x0NewtonTextBox.Text);
                epsilon = double.Parse(epsilonNewtonTextBox.Text);

                fNewton.WriteLine("Функция      f(x) = " + txtBoxNewton_eq.Text);
                fNewton.WriteLine("Производная df(x) = " + txtBoxNewton_diffeq.Text);
                fNewton.WriteLine("x0:  " + x0);
                fNewton.WriteLine("Точность:  " + epsilon);
                fNewton.WriteLine("Итерационная последовательность приближений:");
            }

            catch (FormatException)
            {
                fNewton.Close();
                File.Delete("[Метод Ньютона]. Вычисления.txt");
                MessageBox.Show("Неправильный ввод данных. \nПримечание: используйте точку для ввода десятичного числа,\nа также вводите просто функцию без =0. ", "Ошибка", MessageBoxButtons.OK);
                return; //Должно ли тут быть без 0 или 1??
            }

            test = check_Newton();

            if (test != 0)
            {
                fNewton.Close();
                File.Delete("[Метод Ньютона]. Вычисления.txt");
                return;// и тут?
            }

            //Счет степени
            t = epsilon;
            st = 0;
            while (t < 1)
            {
                t *= 10;
                st++;
            }

            do
            {
                iter++;
                fx = dfx = 0;

                myHash.Clear();
                myHash.Add("x", x0.ToString());
                fx = myParse.Parse(txtBoxNewton_eq.Text, myHash);
                dfx = myParse.Parse(txtBoxNewton_diffeq.Text, myHash);

                temp = x1;

                if (double.IsNaN(fx) || double.IsNaN(dfx) || double.IsInfinity(fx) || double.IsInfinity(dfx) || dfx == 0)
                {
                    fNewton.Close();
                    File.Delete("[Метод Ньютона]. Вычисления.txt");
                    MessageBox.Show("В точках приближения функция оказалась бесконечна или неопределена! Метод расходится.", "Ошибка в начальных приближениях", MessageBoxButtons.OK);
                    return;// ??
                }

                x1 = x0 - fx / dfx;
                x0 = x1;

                resultNewton.Items.Add(iter + ". " + x1);
                fNewton.WriteLine(Math.Round(x1, st));
            } while ((Math.Abs(temp - x0)) >= epsilon && iter < 10000);


            if (iter == 10000)
            {
                fNewton.Close();
                File.Delete("[Метод Ньютона]. Вычисления.txt");
                MessageBox.Show("Количество итераций превысило 10 000. Работа программы остановлена", "Предупреждение", MessageBoxButtons.OK);
                return;//??
            }


            resultNewton.Items.Add("_________________");//просто чтобы разделить результаты, которые выводятся в окне, а то при многочисленных использованиях там всё в перемешку
            ariphmetic_operations = 2 * iter;

            iterNewtonTextBox.Items.Add(iter + " итераций");
            rootNewtonTextBox.Items.Add("Корень: " + x1);
            operationsNewtonTextBox.Items.Add("Арифметических операций: " + ariphmetic_operations);

            fNewton.WriteLine("---------------------------------------------");
            fNewton.WriteLine("ИТОГО:");
            fNewton.WriteLine(iter + " итераций");
            fNewton.WriteLine("Корень: " + Math.Round(x1, st));
            fNewton.WriteLine("Арифметических операций: " + ariphmetic_operations);
            fNewton.Close();

            if (checkNewtonIfNeedFile.Checked == true)
            {
            }
            else
            {
                File.Delete("[Метод Ньютона]. Вычисления.txt");
            }

            MessageBox.Show("Корень уравнения " + Math.Round(x1, st) + " вычислен за " + iter + " итераций.", "МЕТОД НЬЮТОНА", MessageBoxButtons.OK);
            //MessageBox.Show("Корень уравнения " + Math.Round(x1, 5).ToString("0.00000") + " вычислен за " + iter + " итераций.", "МЕТОД НЬЮТОНА", MessageBoxButtons.OK);
        }

    }
}
