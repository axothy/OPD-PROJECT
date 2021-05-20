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
using System.Globalization;


namespace InspirationDemo
{
    public partial class SLAUForm : UserControl
    {
        int ariphmeticNumb = 0;
        public SLAUForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SLAUForm_Load(object sender, EventArgs e)
        {

        }

        ExpressionParser myParse;
        Hashtable myHash;

        double[] difVV(double[] V1, double[] V2)
        { //функция вычитания векторов
            int n = V1.Length;
            double[] V = new double[n];
            for (int ctr = 0; ctr < n; ctr++)
            {
                V[ctr] = V1[ctr] - V2[ctr];
                ariphmeticNumb++;
            }
            return V;
        }
        double normV(double[] V)
        {//бесконечная норма вектор
            double max = Math.Abs(V[0]);
            for (int ctr = 0; ctr < V.Length; ctr++)
                if (Math.Abs(V[ctr]) > max)
                    max = Math.Abs(V[ctr]);
            return max;
        }

        double[][] CreateMatrix(int size)
        {//инициализация матрицы
            double[][] Matrix = new double[size][];

            for (int i = 0; i < size; i++)
            {
                Matrix[i] = new double[size];
            }
            return Matrix;
        }

        double[] scalMV(double[][] A, double[] V)
        {//скалярное произведение матрицы на вектор
            double[] AV = new double[A.Length];
            for (int i = 0; i < A.Length; i++)
                for (int j = 0; j < A.Length; j++)
                {
                    AV[i] += V[j] * A[i][j];
                    ariphmeticNumb++;
                }
            return AV;
        }

        double[][] multMM(double[][] A1, double[][] A2)
        {//произведение двух матриц
            double[][] A = CreateMatrix(A1.Length);

            for (int i = 0; i < A1.Length; i++)
            {
                A[i] = new double[A1.Length];
                for (int j = 0; j < A1.Length; j++)
                {
                    for (int k = 0; k < A1.Length; k++)
                    {
                        A[i][j] += A1[i][k] * A2[k][j];
                        ariphmeticNumb++;
                    }
                }
            }
            return A;
        }

        double[][] difMM(double[][] A1, double[][] A2)
        {//разность двух матриц
            double[][] A = CreateMatrix(A1.Length);

            for (int i = 0; i < A1.Length; i++)
            {
                for (int j = 0; j < A1.Length; j++)
                {
                    A[i][j] = A1[i][j] - A2[i][j];
                    ariphmeticNumb++;
                }
            }
            return A;
        }

        double[] sumVV(double[] V1, double[] V2)
        {//сумма двух векторов
            double[] V = new double[V1.Length];
            for (int i = 0; i < V1.Length; i++)
            {
                V[i] = V1[i] + V2[i];
                ariphmeticNumb++;
            }
            return V;
        }

        double scalVV(double[] V1, double[] V2)
        {//функция скалярного умножения векторов
            double scal = 0;
            for (int i = 0; i < V1.Length; i++)
            {
                scal += V1[i] * V2[i];
                ariphmeticNumb += 2;
            }
            return scal;
        }
        double[] multKV(double k, double[] V)
        {//функция умножения вектора на число
            double[] kV = new double[V.Length];
            for (int i = 0; i < V.Length; i++)
            {
                kV[i] = k * V[i];
                ariphmeticNumb++;
            }
            return kV;
        }
        bool converge(double[] xk, double[] xkp, int n, double eps)
        {//проверка на условие останова
            double norm = 0;
            for (int i = 0; i < n; i++)
            {
                norm += (xk[i] - xkp[i]) * (xk[i] - xkp[i]);
                ariphmeticNumb += 4;
            }
            return (Math.Sqrt(norm) < eps);
        }
        bool diagonal(double[][] a, int n)
        {//проверка матрицы на диагональное преобладание
            int i, j, k = 1;
            double sum;
            for (i = 0; i < n; i++)
            {
                sum = 0;
                for (j = 0; j < n; j++) sum += Math.Abs(a[i][j]);
                sum -= Math.Abs(a[i][i]);
                if (sum > a[i][i])
                {
                    k = 0;
                }
            }
            if (k == 1)
                return true;
            else
                return false;
        }

        double[] GaussMethod(int size, string[] numbersMx, string[] numbersVr)
        {
            int i, j;

            double[][] mxAGauss = new double[size][];
            for (i = 0; i < size; i++)
            {
                mxAGauss[i] = new double[size + 1];
            }
            int cntr = 0;

            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {

                    mxAGauss[i][j] = double.Parse(numbersMx[cntr]);
                    cntr++;
                }
            }

            for (i = 0; i < size; i++)
            {
                mxAGauss[i][size] = double.Parse(numbersVr[i]);
            }

            int m, k;
            double aa, bb;

            for (k = 0; k < size; k++) //Поиск максимального элемента в первом столбце
            {
                aa = Math.Abs(mxAGauss[k][k]);
                i = k;
                for (m = k + 1; m < size; m++)
                    if (Math.Abs(mxAGauss[m][k]) > aa)
                    {
                        i = m;
                        aa = Math.Abs(mxAGauss[m][k]);
                    }

                if (aa == 0)   //проверка на нулевой элемент
                {
                    return null;// нужно ошыпку что нет решений
                }

                if (i != k)  //  перестановка i-ой строки, содержащей главный элемент k-ой строки
                {
                    for (j = k; j < size + 1; j++)
                    {
                        bb = mxAGauss[k][j];
                        mxAGauss[k][j] = mxAGauss[i][j];
                        mxAGauss[i][j] = bb;
                    }
                }
                aa = mxAGauss[k][k];//преобразование k-ой строки (Вычисление масштабирующих множителей)
                mxAGauss[k][k] = 1;
                for (j = k + 1; j < size + 1; j++)
                {
                    mxAGauss[k][j] /= aa;
                    ariphmeticNumb++;
                }
                for (i = k + 1; i < size; i++)//преобразование строк с помощью k-ой строки
                {
                    bb = mxAGauss[i][k];
                    mxAGauss[i][k] = 0;
                    if (bb != 0)
                        for (j = k + 1; j < size + 1; j++)
                        {
                            mxAGauss[i][j] += -bb * mxAGauss[k][j];
                            ariphmeticNumb += 2;
                        }
                }
            }

            double[] x = new double[size];

            for (i = size - 1; i >= 0; i--)   //Нахождение решений СЛАУ
            {
                x[i] = 0;
                aa = mxAGauss[i][size];
                for (j = size - 1; j > i; j--)
                {
                    aa += -mxAGauss[i][j] * x[j];
                    ariphmeticNumb += 2;
                }
                x[i] = aa;
            }

            return x;
        }

        double[] JacobiMethod(int size, double[][] mxA, double[] b, double[] x0, double eps)
        {

            double[] x = new double[size];

            double[][] D = CreateMatrix(size);
            double[][] D_1 = CreateMatrix(size);


            for (int i = 0; i < size; i++)
            {
                D[i][i] = mxA[i][i];
            }

            for (int i = 0; i < size; i++)
            {
                D_1[i][i] = 1 / D[i][i];
                ariphmeticNumb++;
            }

            double[][] B = multMM(D_1, difMM(D, mxA));
            double[] g = scalMV(D_1, b);



            do
            {

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        x = sumVV(scalMV(B, x0), g);
                    }
                }
                if (normV(difVV(x, x0)) < eps)
                {
                    break;
                }
                else
                    for (int get = 0; get < size; get++)
                    {
                        x0[get] = x[get];
                    }
            } while (true);

            return x;
        }
        private void SolveIter_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            resultSLAU.Text = "";
            ariphmeticCNT.Text = "";

            myParse = new ExpressionParser();
            myHash = new Hashtable();

            int size;
            try
            {
                size = int.Parse(N.Text);
            }

            catch (FormatException)
            {
                MessageBox.Show("Неверно задан размер матрицы. ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (size <= 0)
            {
                MessageBox.Show("Размер матрицы должен быть больше 0 ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            string mxAs;
            string vrBs;
            string vrX0s;

            try
            {
                mxAs = string.Format(matrix_A.Text);
                vrBs = string.Format(vector_b.Text);
                vrX0s = string.Format(vector_x0.Text);
            }

            catch (FormatException)
            {
                MessageBox.Show("Неверно заданы матрица или векторы ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            string[] numbersMx = mxAs.Split(' ');
            string[] numbersVr = vrBs.Split(' ');
            string[] numbersX0 = vrX0s.Split(' ');

            if (numbersMx.Length != size * size)
            {
                MessageBox.Show("Матрица не соответствует своему размеру ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (numbersVr.Length != size)
            {
                MessageBox.Show("Вектор b не соответствует своему размеру ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            try
            {
                if (GaussChoose.Checked)
                {

                    double[] x = GaussMethod(size, numbersMx, numbersVr);

                    if (x == null)
                    {
                        return;
                    }

                    for (int i = 0; i < x.Length; i++)
                    {
                        resultSLAU.AppendText(x[i] + "\n");
                    }

                    ariphmeticCNT.AppendText(string.Concat(ariphmeticNumb));
                    ariphmeticNumb = 0;
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Матрица или вектор не соответствует своему размеру ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            try
            {
                if (JacobiChoose.Checked)
                {
                    double[][] mxA = new double[size][];

                    for (int i = 0; i < size; i++)
                    {
                        mxA[i] = new double[size];
                    }

                    int cntr = 0;
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            mxA[i][j] = double.Parse(numbersMx[cntr]);
                            cntr++;
                        }
                    }

                    if (!diagonal(mxA, mxA.Length))
                    {
                        return;
                    }

                    double[] b = new double[size];

                    for (int i = 0; i < size; i++)
                    {
                        b[i] = double.Parse(numbersVr[i]);
                    }

                    double[] x;
                    double[] x0 = new double[size];

                    for (int i = 0; i < size; i++)
                    {
                        x0[i] = double.Parse(numbersX0[i]);
                    }

                    string epsStr = string.Format(epsBox.Text);

                    double eps = double.Parse(epsStr);

                    //МЕТОД ЯКОБИ
                    x = JacobiMethod(size, mxA, b, x0, eps);

                    for (int i = 0; i < x.Length; i++)
                    {
                        resultSLAU.AppendText(x[i] + "\n");
                    }

                    ariphmeticCNT.AppendText(string.Concat(ariphmeticNumb));
                    ariphmeticNumb = 0;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Матрица или вектор не соответствует своему размеру ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            try
            {
                if (ZeidelGaussChoose.Checked)
                {
                    double[][] mxA = new double[size][];

                    for (int i = 0; i < size; i++)
                    {
                        mxA[i] = new double[size];
                    }

                    int cntr = 0;
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            mxA[i][j] = double.Parse(numbersMx[cntr]);
                            cntr++;
                        }
                    }
                    double[] b = new double[size];

                    for (int i = 0; i < size; i++)
                    {
                        b[i] = double.Parse(numbersVr[i]);
                    }

                    double[] x = new double[size];
                    double[] x0 = new double[size];

                    for (int i = 0; i < size; i++)
                    {
                        x0[i] = double.Parse(numbersX0[i]);
                    }

                    string epsStr = string.Format(epsBox.Text);

                    double eps = double.Parse(epsStr);

                    for (int i = 0; i < size; i++)
                        x[i] = double.Parse(numbersX0[i]);

                    if (diagonal(mxA, size))
                    {
                        do
                        {
                            for (int i = 0; i < size; i++)
                                x0[i] = x[i];
                            for (int i = 0; i < size; i++)
                            {
                                double var = 0;
                                for (int j = 0; j < i; j++)
                                {
                                    var += mxA[i][j] * x[j];
                                    ariphmeticNumb += 2;
                                }
                                for (int j = i + 1; j < size; j++)
                                {
                                    var += mxA[i][j] * x0[j];
                                    ariphmeticNumb += 2;
                                }
                                x[i] = (b[i] - var) / mxA[i][i];
                                ariphmeticNumb += 2;

                            }
                        } while (!converge(x, x0, size, eps));
                    }
                    else
                    {
                        return;
                    }

                    for (int i = 0; i < x.Length; i++)
                    {
                        resultSLAU.AppendText(x[i] + "\n");
                    }

                    ariphmeticCNT.AppendText(string.Concat(ariphmeticNumb));
                    ariphmeticNumb = 0;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Матрица или вектор не соответствует своему размеру ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            try
            {
                if (GradDescent.Checked)
                {
                    double delta = 0;
                    double[] w = new double[size];

                    double[][] mxA = new double[size][];

                    for (int i = 0; i < size; i++)
                    {
                        mxA[i] = new double[size];
                    }

                    int cntr = 0;
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            mxA[i][j] = double.Parse(numbersMx[cntr]);
                            cntr++;
                        }
                    }

                    double[] x0 = new double[size];

                    for (int i = 0; i < size; i++)
                    {
                        x0[i] = double.Parse(numbersX0[i]);
                    }

                    double[] b = new double[size];

                    for (int i = 0; i < size; i++)
                    {
                        b[i] = double.Parse(numbersVr[i]);
                    }

                    w = difVV(scalMV(mxA, x0), b);

                    string epsStr = string.Format(epsBox.Text);
                    double eps = double.Parse(epsStr);

                    double[] x = new double[size];

                    do
                    {
                        delta = scalVV(w, w) / scalVV(scalMV(mxA, w), w);
                        x = difVV(x0, multKV(delta, w));
                        w = difVV(w, multKV(delta, scalMV(mxA, w)));
                        if (normV(difVV(x0, x)) < eps)
                        {
                            break;
                        }
                        for (int i = 0; i < size; i++)
                        {
                            x0[i] = x[i];
                        }
                    } while (true);

                    for (int i = 0; i < x.Length; i++)
                    {
                        resultSLAU.AppendText(x[i] + "\n");
                    }

                    ariphmeticCNT.AppendText(string.Concat(ariphmeticNumb));
                    ariphmeticNumb = 0;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Матрица или вектор не соответствует своему размеру ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            try
            {
                if (Rotation.Checked)
                {
                    int i, j, k;

                    double[][] A = new double[size][];

                    for (i = 0; i < size; i++)
                    {
                        A[i] = new double[size];
                    }

                    int cntr = 0;
                    for (i = 0; i < size; i++)
                    {
                        for (j = 0; j < size; j++)
                        {
                            A[i][j] = double.Parse(numbersMx[cntr]);
                            cntr++;
                        }
                    }

                    double[] B = new double[size];

                    for (i = 0; i < size; i++)
                    {
                        B[i] = double.Parse(numbersVr[i]);
                    }


                    double ddd, alf, bet, A_ij, A_kj, b_i, b_k, s;
                    for (i = 0; i < size; i++)
                        for (k = i + 1; k < size; k++)
                        {
                            ddd = Math.Sqrt(A[i][i] * A[i][i] + A[k][i] * A[k][i]);
                            ariphmeticNumb += 4;
                            alf = A[i][i] / ddd;
                            ariphmeticNumb += 1;
                            bet = -A[k][i] / ddd;
                            ariphmeticNumb += 1;
                            for (j = i; j < size; j++)
                            {
                                A_ij = A[i][j] * alf - A[k][j] * bet;
                                ariphmeticNumb += 3;
                                A_kj = A[i][j] * bet + A[k][j] * alf;
                                ariphmeticNumb += 3;
                                A[i][j] = A_ij;
                                A[k][j] = A_kj;
                            }
                            b_i = B[i] * alf - B[k] * bet;
                            ariphmeticNumb += 3;
                            b_k = B[i] * bet + B[k] * alf;
                            ariphmeticNumb += 3;
                            B[i] = b_i;
                            B[k] = b_k;
                        }

                    double[] X = new double[size];

                    X[size - 1] = B[size - 1] / A[size - 1][size - 1];
                    ariphmeticNumb += 1;

                    for (i = (size - 2); i >= 0; i--)
                    {
                        s = 0;
                        for (j = i + 1; j < size - 1; j++)
                        {
                            s += A[i][j] * X[j];
                            ariphmeticNumb += 2;
                        }
                        X[i] = (B[i] - s) / A[i][i];
                        ariphmeticNumb += 2;
                    }

                    for (i = 0; i < X.Length; i++)
                    {
                        resultSLAU.AppendText(X[i] + "\n");
                    }

                    ariphmeticCNT.AppendText(string.Concat(ariphmeticNumb));
                    ariphmeticNumb = 0;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Матрица или вектор не соответствует своему размеру ", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if ((!GaussChoose.Checked) && (!ZeidelGaussChoose.Checked) && (!Rotation.Checked) && (!GradDescent.Checked) && (!JacobiChoose.Checked))
            {
                MessageBox.Show("Выберите метод. ", "Ошибка", MessageBoxButtons.OK);
                return;
            }


        }
        private void iterMethodsForm1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GradDescent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ZeidelGaussChoose_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void JacobiChoose_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
