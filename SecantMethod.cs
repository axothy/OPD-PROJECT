using System;
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

        //Процедура проверяющая ошибки в начальных приближениях
        public int check_secant()
        {
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
                if (double.IsNaN(fx0) || double.IsNaN(fx1) || double.IsInfinity(fx0) || double.IsInfinity(fx0))
                {
                    MessageBox.Show("В данных точках функция бесконечна!", "Ошибка в начальных приближениях", MessageBoxButtons.OK);
                    return 1;
                }

                // Проверяем, что значение функции в x0 и x1 не равны (ибо в методе секущих деление на такой знаменатель)
                if (fx0 == fx1)
                {
                    MessageBox.Show("Значения функций в точках начальных приближений совпали!", "Ошибка в начальных приближениях", MessageBoxButtons.OK);
                    return 1;
                }
            }

            catch
            {
                MessageBox.Show("Неправильный ввод данных", "Ошибка", MessageBoxButtons.OK);
                return 1;
            }

            return 0;
        }

        //При нажатии на кнопку button1 (это у нас "Решить") будет выполняться следующая процедура
        private void button1_Click(object sender, EventArgs e)
        {
            iter = 0;
            x2 = 9999;

            try
            {
                myParse = new ExpressionParser();
                myHash = new Hashtable();

                x0 = double.Parse(x0SecantTextBox.Text);       //Читаем содержимое для x0
                x1 = double.Parse(x1SecantTextBox.Text);       //Читаем содержимое для x1
                epsilon = double.Parse(EpsilonSecantTextBox.Text);  //Читаем содержимое для точности
            }

            //Проверяем, не содержат ли введенные данные посторонних символов
            catch (FormatException)
            {
                MessageBox.Show("Неверно заданы данные. Советуем прочитать окно Помощи. ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            // Проверяем все начальные условия (проверка от дурака) вызывая check
            test = check_secant();

            if (test != 0)
                return;

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
                if (double.IsNaN(fx0) || double.IsNaN(fx1) || double.IsInfinity(fx0) || double.IsInfinity(fx0))
                {
                    MessageBox.Show("В данных точках функция бесконечна!", "Ошибка в начальных приближениях", MessageBoxButtons.OK);
                    return;
                }

                if (fx0 == fx1)
                {
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
                resultSecant.Items.Add(iter + ". " + x2);
            } while ((Math.Abs(temp - x2)) >= epsilon && iter < 10000); //условие останова

            //Если зациклится - то стоп
            if (iter == 10000)
            {
                MessageBox.Show("Количество итераций превысило 10 000. Работа программы остановлена", "Предупреждение", MessageBoxButtons.OK);
                return;
            }

            ariphmetic_operations = 5 * iter;
            // Вывод результата в боксы на форме
            iterSecantTextBox.Items.Add(iter + " итераций");
            rootSecantTextBox.Items.Add("Корень: " + x2);
            operationsSecantTextBox.Items.Add("Арифметических операций: " + ariphmetic_operations);
            //На всякий случай выведем еще и в окно 
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
