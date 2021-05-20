using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;
using System.Collections;

namespace InspirationDemo
{

    public partial class RelaxationMethod : UserControl
    {
       
        public RelaxationMethod()
        {
            InitializeComponent();
        }

        
        private void MPDMethod_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }



       
        int iter;
        double epsilon;
        double x0, x, x_k;
        double fx, t, w;
        int st;

        int test;
        int ariphmetic_operations;

        ExpressionParser myParse;
        Hashtable myHash;

        
        
            public int check_relax()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            fx = 0;

            try
            {
                

                myHash.Clear();
                myHash.Add("x", x0.ToString()); 
                fx = myParse.Parse(txtBoxRelaxation_eq.Text, myHash); 


                
                if (double.IsNaN(fx) || double.IsInfinity(fx) )
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

        private void SolveRelaxation_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            iter = 0;
          

            try
            {
                myParse = new ExpressionParser();
                myHash = new Hashtable();

                x0 = double.Parse(x0RelaxationTextBox.Text);       
                t = double.Parse(tauRelaxationTextBox.Text);
                
                epsilon = double.Parse(epsilonRelaxationTextBox.Text);  
            }

            

            
            catch (FormatException)
            {
                MessageBox.Show("Неправильный ввод данных. \nПримечание: используйте точку для ввода десятичного числа,\nа также вводите просто функцию без =0. ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            test = check_relax();

            if (t <= 0)
            {
                test = 1;
                MessageBox.Show("Неверно задан параметр релаксации");
            }
                
                if (test != 0)
                return;
            x = 9999;
            resultRelaxation.Items.Clear();
            do
            {
                iter++;
                fx = 0;
                
                myHash.Clear();
                myHash.Add("x", x0.ToString());
                fx = myParse.Parse(txtBoxRelaxation_eq.Text, myHash);

                

               

                if (double.IsNaN(fx) || double.IsInfinity(fx) )
                {
                    MessageBox.Show("В данных точках функция бесконечна!", "Ошибка в начальных приближениях", MessageBoxButtons.OK);
                    return;
                }



                x_k = x0 - t * fx;
                x = x0;
                x0 = x_k;
               
             

                
                resultRelaxation.Items.Add(iter + ". " + x);
            } while ((Math.Abs(x - x0)) >= epsilon && iter < 10000); 

            
            if (iter == 10000)
            {
                MessageBox.Show("Количество итераций превысило 10 000. Работа программы остановлена", "Предупреждение", MessageBoxButtons.OK);
                return;
            }

            w = epsilon;
            st = 0;
            while (w < 1)
            {
                w *= 10;
                st++;
            }
            ariphmetic_operations = iter;
         
            iterRelaxationTextBox.Items.Clear();
            rootRelaxationTextBox.Items.Clear();
            operationsRelaxationTextBox.Items.Clear();
            iterRelaxationTextBox.Items.Add(iter + " итераций");
            rootRelaxationTextBox.Items.Add("Корень: " + x);
            operationsRelaxationTextBox.Items.Add("Арифметических операций: " + ariphmetic_operations);
            MessageBox.Show("Корень уравнения " + Math.Round(x, st) + " вычислен за " + iter + " итераций.", "МЕТОД НЬЮТОНА", MessageBoxButtons.OK);
            
        }




    }

    
}
