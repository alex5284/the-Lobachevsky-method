using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        int MatrixSize = 0;//розмір многочлена(найбільша сткпінь х)
        double[] A;//масив коефіцієнтів біля х
        string f;//задана функція
        double E, a, b, H;
       

        public Form1()
        {
            InitializeComponent();
        }

        void ReadMatrixFromGrid()
        {
            A = new double[MatrixSize + 1];//створюємо масив коеф

            for (int i = 0; i < MatrixSize + 1; i++)
            {
                A[i] = Convert.ToDouble(dgMatrix.Rows[1].Cells[i].Value);//запам'ятовуємо значення
            }
            ShowMatrixInGrid();
        }


        void ShowMatrixInGrid()
        {
            for (int i = 0; i < MatrixSize + 1; i++)
            {
                dgMatrix.Rows[1].Cells[i].Value = A[i].ToString();//показуємо значення масиву 
            }
        }

        void CreateMatrix()//створюємо панелі у DataDridView
        {
            MatrixSize = Convert.ToInt32(tbSize.Text);
            dgMatrix.Rows.Clear();
            dgMatrix.Columns.Clear(); // очищаем солонки
            dgMatrix.ColumnCount = MatrixSize + 2;
            dgMatrix.Rows.Add(2);
            for (int i = 0; i <= MatrixSize + 1; i++)
            {
                if (i < MatrixSize + 1)
                {
                    dgMatrix.Rows[0].Cells[i].Value = $" x^{MatrixSize - i}";
                }
                else dgMatrix.Rows[0].Cells[i].Value = " y";
            }

            for (int i = 0; i <= MatrixSize + 1; i++)
            {
                if (i < MatrixSize + 1) dgMatrix.Rows[1].Cells[i].Value = "1"; // записываем значеня в соответсвующие места
                else dgMatrix.Rows[1].Cells[i].Value = "0";
            }
        }
        void CreateMatrix1()
        {
            MatrixSize = Convert.ToInt32(tbSize.Text);
            dgMatrix.Rows.Clear();
            dgMatrix.Columns.Clear(); // очищаем солонки
            int j = 0;
            dgMatrix.ColumnCount = MatrixSize + 2;
            dgMatrix.Rows.Add(2);
            for (int i = 0; i <= MatrixSize + 1; i++)
            {
                if (i < MatrixSize + 1)
                {
                    dgMatrix.Rows[0].Cells[i].Value = $" x^{MatrixSize - i}";
                }
                else dgMatrix.Rows[0].Cells[i].Value = " y";
            }

            j = 1;
            dgMatrix.Rows[j].Cells[0].Value = "1";
            dgMatrix.Rows[j].Cells[1].Value = "5";
            dgMatrix.Rows[j].Cells[2].Value = "9";
            dgMatrix.Rows[j].Cells[3].Value = "5";
            dgMatrix.Rows[j].Cells[4].Value = "-1";
            dgMatrix.Rows[j].Cells[5].Value = "0";
        }
        void InitExpr()
        {
            E = 0.01;
            a = Convert.ToDouble(tbA.Text);
            b = Convert.ToDouble(tbB.Text);
            H = Convert.ToDouble(tbH.Text);

        }

        void F()//перетворюю масив коеф у рівняння f
        {
            A = new double[MatrixSize + 1];
            ReadMatrixFromGrid();
            f = " ";
            for (int i = 0; i < MatrixSize + 1; i++)
            {
                f += $"({dgMatrix[i, 1].Value}) * ";
                if (i < MatrixSize)
                {
                    f += $"{dgMatrix[i, 0].Value} + ";
                }
                else f += $"{dgMatrix[i, 0].Value}";
            }
        }
        void Afunc()
        {
            
            double X = a;
            F();
            MathExpression fun = new MathExpression(f);//берем функцию
            listBox1.Items.Clear();
            listBox3.Items.Clear();
            double previousF = 0;//попередне значення функції
            double previousX = a;//попередне значення х

            while (X <= b)
            {
                double f = fun.Calculate(X);

                if (Math.Sign(f) == 1)
                {
                    listBox1.Items.Add("X=" + X.ToString() + ", Sign f(x) = + ");
                }
                else
                {
                    listBox1.Items.Add("X=" + X.ToString() + ", Sign f(x) = - ");
                }

                try
                {//якщо попереднє значення функції не дорівнює нулю та знак значення ф відрізняється від попереднього значення ф
                    if (previousF != 0 && Math.Sign(previousF) != Math.Sign(f))
                    {
                        listBox3.Items.Add(previousX.ToString() + "; " + X.ToString());//записуемо проміжок від попереднього х до даного
                    }
                }
                catch//в іншому випадку проміжків немає
                {
                    listBox3.Items.Add("---");
                }

                if (X != a)//якщо х не дорівнює А
                {
                    previousF = f;//попереднє ф прирівнюємо до даного
                    previousX = X;//попереднє х прирівнюємо до даного
                }

                X += H;//збільшуємо крок 
            }

        }

        void Lobachevskogo()
        {
            F();
            MathExpression fun = new MathExpression(f);
            double X1 = a;
            listBox2.Items.Clear();
            A = new double[MatrixSize + 1];
            ReadMatrixFromGrid();
            InitExpr();
            double[] A1 = new double[MatrixSize + 1];
            double[] A2 = new double[MatrixSize + 1];
            double[] X = new double[MatrixSize];
            int k , iter, iter1, k1, k2;
            double S, res, m, x, tmp, max;
            for(int i = 0; i < MatrixSize+1; i++)
            {
                A1[i] = A[i];
            }
            iter = 0;
            do
            {
                k = 0;
                for(int i = 0; i < MatrixSize+1; i++)
                {
                    S = 0;
                    k1 = i - 1;
                    k2 = i + 1;
                    iter1 = 1;
                    while (true)
                    {
                        if (k1 < 0 || k2 > MatrixSize) break;
                        else
                        {
                            if(iter1 % 2 == 0) S = S + 2 * (A1[k1] * A1[k2]);//шукаю проміжні результати для знаходження наступних значень
                            else S = S - 2 * (A1[k1] * A1[k2]);
                        }

                        iter1++;
                        k1 = i - iter1;
                        k2 = i + iter1;
                    }
                    A2[i] = Math.Pow(A1[i], 2) + S;//шукаю по формулам масив значень після піднесення в степінь
                }

                for(int i = 0; i < MatrixSize+1; i++)
                {
                    res = Math.Round(Math.Pow(A1[i], 2),3);
                    tmp = Math.Round(A2[i],3) - res;
                    max = Math.Abs(A.Max());

                    if (max < 16)
                    {
                        if (Math.Abs(tmp) <= E || iter == 6) k++;//перевіряю умову виходу з ітераційного процессу
                    }
                    else
                    {
                        if (Math.Abs(tmp) <= E || iter == 5) k++;
                    }
                }

                for (int i = 0; i < MatrixSize + 1; i++)
                {
                    A1[i] = A2[i];
                }
                iter++;
            } 
            while (k != MatrixSize+1);

            m = Math.Pow(2, iter);

            for (int i = 0; i <= MatrixSize - 1; i++)
            {
                x = -A1[i + 1] / A1[i];//по формулам рахую х
                if (x < 0) X[i] = (-1) * Math.Pow(Math.Abs(x), 1 / m);
                else X[i] = Math.Pow(x, 1 / m);
            }
            for (int i = 0; i < MatrixSize; i++)//MatrixSize - count
            {
                double f = fun.Calculate(X[i]);
                if (Math.Round(f) != 0) X[i] = X[i] * (-1);
                f = fun.Calculate(X[i]);
                if (Math.Round(f) == 0) listBox2.Items.Add("x = " + X[i]);//виводжу х
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            CreateMatrix1();
        }

        private void btnLobachevskogo_Click(object sender, EventArgs e)
        {
            Lobachevskogo();
        }

        private void btnAnalitic_Click(object sender, EventArgs e)
        {
            InitExpr();
            Afunc();

        }

        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateMatrix();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
