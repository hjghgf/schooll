using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class matrices
    {
        class matrix
        {
            public float[,] contains;
            public int str;
            public int stolb;

            public matrix(int l, int h)
            {
                str = l;
                stolb = h;
                contains = new float[l, h];
                Random r = new Random();

                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        contains[i, j] = r.Next(0, 4);
                    }
                }
            }

            public matrix(float[,] cont)
            {
                contains = cont;
                str = cont.GetLength(0);
                stolb = cont.GetLength(1);
            }

            public matrix()
            {

            }

            public matrix(int l, int h, int a)
            {
                str = l;
                stolb = h;
                contains = new float[l, h];
            }

            public void print()
            {
                for (int i = 0; i < str; i++)
                {
                    for (int j = 0; j < stolb; j++)
                    {
                        Console.Write(contains[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            public void multiply(float n)
            {
                for (int i = 0; i < stolb; i++)
                {
                    for (int j = 0; j < str; j++)
                    {
                        contains[i, j] *= n;
                    }
                }
            }

            public void sum(matrix newMatrix)
            {
                if (newMatrix.str == str && newMatrix.stolb == stolb)
                {
                    for (int i = 0; i < stolb; i++)
                    {
                        for (int j = 0; j < str; j++)
                        {
                            contains[i, j] += newMatrix.contains[i, j];
                        }
                    }
                }
            }

            public matrix multiplyTwoMatrix(matrix newMatrix)
            {
                var res = new matrix();

                if (this.str != newMatrix.stolb)
                {
                    res = new matrix(0, 0, 0);
                }
                else
                {
                    res = new matrix(this.str, newMatrix.stolb, 0);

                    for (int i = 0; i < newMatrix.stolb; i++)
                    {
                        for (int j = 0; j < this.str; j++)
                        {
                            for (int k = 0; k < this.stolb; k++)
                            {
                                res.contains[i, j] += this.contains[i, k] * newMatrix.contains[k, j];
                            }
                        }
                    }
                }

                return res;
            }

            public void sum(matrix matrix2, matrix matrix3)
            {
                if (matrix2.str == matrix3.str && matrix3.stolb == matrix2.stolb)
                {
                    for (int i = 0; i < stolb; i++)
                    {
                        for (int j = 0; j < str; j++)
                        {
                            contains[i, j] = matrix2.contains[i, j] + matrix3.contains[i, j];
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            var matrix1 = new matrix(2, 3);
            var matrix2 = new matrix(3, 2);

            matrix1.print();
            Console.WriteLine();
            matrix2.print();
            Console.WriteLine();

            var res = matrix1.multiplyTwoMatrix(matrix2);
            res.print();
        }

    }
}
