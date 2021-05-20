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
using info.lundin.math; //Библиотека для чтения функции заданной выражением
using System.Collections;


namespace InspirationDemo
{
    public partial class SecantMethod : UserControl
    {
        // Объявляем переменные

        int iter;
        int ariphmetic_operations;
        double epsilon;
        double x0, x1, x2;
        double fx0, fx1, fx2, temp;

        int test;

        ExpressionParser myParse; //Переменная отвечающая за функцию, введенную выражением
        Hashtable myHash;

        private void linkSecant_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HelpSecant metodichka2 = new HelpSecant();
            metodichka2.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        //Процедура проверяющая ошибки в начальных приближениях
        public int check_secant()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            fx0 = fx1 = fx2 = 0;

            try
            {
                //Проверка на ошибки в начальных данных

                myHash.Clear();
                myHash.Add("x", x0.ToString()); //Задаем переменной "х" значение под "х0"
                fx0 = myParse.Parse(txtBoxSecant_eq.Text, myHash); //Подставляем x0 в введенную функцию

                //Тоже самое делаем и для x1
                myHash.Clear();
                myHash.Add("x", x1.ToString());
                fx1 = myParse.Parse(txtBoxSecant_eq.Text, myHash);

                // Теперь проверяем, не равна ли функция в точке x1/x0 бесконечностью
                if (double.IsNaN(fx0) || double.IsNaN(fx1) || double.IsInfinity(fx0) || double.IsInfinity(fx1))
                {
                    MessageBox.Show("В данных точках функция бесконечна или неопределена!", "Ошибка в начальных приближениях", MessageBoxButtons.OK);
                    return 1;
                }

                // Проверяем, что значение функции в x0 и x1 не равны (ибо в методе секущих деление на такой знаменатель)
                if (fx0 == fx1)
                {
                    MessageBox.Show("Значения функций в точках начальных приближений совпали! Возможно деление на 0.", "Ошибка в начальных приближениях", MessageBoxButtons.OK);
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

        //При нажатии на кнопку SolveSecant (это у нас "Решить") будет выполняться следующая процедура
        private void SolveSecant_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            StreamWriter fSecant = new StreamWriter("[Метод секущих]. Вычисления.txt");

            fSecant.WriteLine("МЕТОД СЕКУЩИХ РЕШЕНИЯ НЕЛИНЕЙНОГО УРАВНЕНИЯ");
            iter = 0;
            x2 = 9999;

            try
            {
                myParse = new ExpressionParser();
                myHash = new Hashtable();


                x0 = double.Parse(x0SecantTextBox.Text);       //Читаем содержимое для x0
                x1 = double.Parse(x1SecantTextBox.Text);       //Читаем содержимое для x1
                epsilon = double.Parse(epsilonSecantTextBox.Text);  //Читаем содержимое для точности

                fSecant.WriteLine("Функция f(x) = " + txtBoxSecant_eq.Text);
                fSecant.WriteLine("x0:  " + x0);
                fSecant.WriteLine("x1:  " + x1);
                fSecant.WriteLine("Точность:  " + epsilon);
                fSecant.WriteLine("Итерационная последовательность приближений:");

            }

            //Проверяем, не содержат ли введенные данные посторонних символов
            catch (FormatException)
            {
                fSecant.Close();
                File.Delete("[Метод секущих]. Вычисления.txt");
                MessageBox.Show("Неправильный ввод данных. \nПримечание: используйте точку для ввода десятичного числа,\nа также вводите просто функцию без =0. ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            // Проверяем все начальные условия (проверка от дурака) вызывая check
            test = check_secant();

            if (test != 0)
            {
                fSecant.Close();
                File.Delete("[Метод секущих]. Вычисления.txt");
                return;
            }

            double t;
            int st;
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
                fx0 = fx1 = fx2 = 0;

                myHash.Clear();
                myHash.Add("x", x0.ToString());
                fx0 = myParse.Parse(txtBoxSecant_eq.Text, myHash);

                myHash.Clear();
                myHash.Add("x", x1.ToString());
                fx1 = myParse.Parse(txtBoxSecant_eq.Text, myHash);

                temp = x2;

                //Теперь здесь - это общая проверка на все последующие вычисляемые приближения
                //в check_secant() была проверка только на начальные введенные данные
                if (double.IsNaN(fx0) || double.IsNaN(fx1) || double.IsInfinity(fx0) || double.IsInfinity(fx1))
                {
                    fSecant.Close();
                    File.Delete("[Метод секущих]. Вычисления.txt");
                    MessageBox.Show("В данных точках функция бесконечна или неопределена!", "Ошибка в начальных приближениях", MessageBoxButtons.OK);
                    return;
                }

                if (fx0 == fx1)
                {
                    fSecant.Close();
                    File.Delete("[Метод секущих]. Вычисления.txt");
                    MessageBox.Show("Значения функций в точках начальных приближений совпали!", "Ошибка в начальных приближениях", MessageBoxButtons.OK);
                    return;
                }

                //Формула секущих
                x2 = x1 - fx1 * ((x1 - x0) / (fx1 - fx0));

                //Для вычисленного x2 вычисляем значение функции в этой точке
                myHash.Clear();
                myHash.Add("x", x2.ToString());
                fx2 = myParse.Parse(txtBoxSecant_eq.Text, myHash);

                x0 = x1;
                x1 = x2;

                //Выводим каждое вычисленное значение функции в бокс вывода testvivod
                resultSecant.Items.Add(iter + ". " + Math.Round(x2, st));
                fSecant.WriteLine(Math.Round(x2, st));

            } while ((Math.Abs(temp - x2)) >= epsilon && iter < 10000); //условие останова

            //Если зациклится - то стоп
            if (iter == 10000)
            {
                fSecant.Close();
                File.Delete("[Метод секущих]. Вычисления.txt");
                MessageBox.Show("Количество итераций превысило 10 000. Работа программы остановлена", "Предупреждение", MessageBoxButtons.OK);
                return;
            }

            resultSecant.Items.Add("_________________");
            ariphmetic_operations = 5 * iter;
            // Вывод результата в боксы на форме

            iterSecantTextBox.Items.Add(iter + " итераций"); //сюда выведется кол-во итераций
            rootSecantTextBox.Items.Add("Корень: " + Math.Round(x2, st)); //а сюда выведется сам найденный корень
            operationsSecantTextBox.Items.Add("Арифметических операций: " + ariphmetic_operations);

            fSecant.WriteLine("---------------------------------------------");
            fSecant.WriteLine("ИТОГО:");
            fSecant.WriteLine(iter + " итераций");
            fSecant.WriteLine("Корень: " + Math.Round(x2, st));
            fSecant.WriteLine("Арифметических операций: " + ariphmetic_operations);
            fSecant.Close();

            if (checkSecantIfNeedFile.Checked == true)
            {
            }
            else
            {
                File.Delete("[Метод секущих]. Вычисления.txt");
            }

            //На всякий случай выведем результат еще и в отдельное всплывающее окно 
            MessageBox.Show("Корень уравнения " + Math.Round(x2, 5).ToString("0.00000") + " вычислен за " + iter + " итераций.", "МЕТОД СЕКУЩИХ", MessageBoxButtons.OK);
        }

        public SecantMethod()
        {
            InitializeComponent();
        }

        private void SecantMethod_Load(object sender, EventArgs e)
        {

        }
    }
}

