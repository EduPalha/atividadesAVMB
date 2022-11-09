/*
8) Ler uma matriz com 4x4 de inteiros e mostrar os números na 
ordem direta e inversa a que foram lidos.
*/

namespace ImersaoAVMB
{
    class Program
    {
        public static double determinant(double[,] a, float k)
        {
            double[,] b = new double[4, 4];
            double det = 0, s = 1;
            int i, j, m, n, c;
            if (k == 1)
            {
                return (a[0, 0]);
            }
            else
            {
                det = 0;
                for (c = 0; c < k; c++)
                {
                    m = 0;
                    n = 0;
                    for (i = 0; i < k; i++)
                    {
                        for (j = 0; j < k; j++)
                        {
                            b[i, j] = 0;
                            if (i != 0 && j != c)
                            {
                                b[m, n] = a[i, j];
                                if (n < (k - 2))
                                    n++;
                                else
                                {
                                    n = 0;
                                    m++;
                                }
                            }
                        }
                    }
                    det = det + s * (a[0, c] * determinant(b, k - 1));
                    s = -1 * s;
                }
            }

            return (det);
        }

        public static void cofactor(double[,] num, float f)
        {
            double[,] b = new double[4, 4];
            double[,] fac = new double[4, 4];
            int p, q, m, n, i, j;
            for (q = 0; q < f; q++)
            {
                for (p = 0; p < f; p++)
                {
                    m = 0;
                    n = 0;
                    for (i = 0; i < f; i++)
                    {
                        for (j = 0; j < f; j++)
                        {
                            if (i != q && j != p)
                            {
                                b[m, n] = num[i, j];
                                if (n < (f - 2))
                                    n++;
                                else
                                {
                                    n = 0;
                                    m++;
                                }
                            }
                        }
                    }
                    fac[q, p] = pow(-1, q + p) * determinant(b, f - 1);
                }
            }
            transpose(num, fac, f);
        }

        public static void transpose(float[,] num, double[,] fac, float r)
        {
            int i, j;
            double[,] b = new double[4, 4];
            double[,] inverse = new double[4, 4];
            double d;

            for (i = 0; i < r; i++)
            {
                for (j = 0; j < r; j++)
                {
                    b[i, j] = fac[j, i];
                }
            }
            d = determinant(num, r);
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < r; j++)
                {
                    inverse[i, j] = b[i, j] / d;
                }
            }
            Console.WriteLine("\n\nThe inverse of matrix is :");

            for (i = 0; i < r; i++)
            {
                for (j = 0; j < r; j++)
                {
                    Console.WriteLine("\t" + inverse[i, j]);
                }
                Console.WriteLine("");
            }
        }


        static void Main(string[] args)
        {
            Random random = new Random();
            double[,] m = new double[4, 4];
            double d, k;
            //popular matriz m
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    m[i, j] = random.Next(0, 10);
                    //Console.WriteLine(m[i,j]);
                }
            }
            
            d = determinant(a, k);
            if (d == 0)
            {
                Console.WriteLine("\nInverse of Entered Matrix is not possible\n");
            }
            else
            {
                cofactor(a, k);
            }


        }
    }
}
