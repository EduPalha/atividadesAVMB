/*
8) Ler uma matriz com 4x4 de inteiros e mostrar os números na 
ordem direta e inversa a que foram lidos.
*/

namespace ImersaoAVMB
{
    class Program
    {
        // cálculo do determinante é necessário para calcular cofator 
        public static double determinante(double[,] a, double k)
        {
            //matriz de ordem 4
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
                    det = det + s * (a[0, c] * determinante(b, k - 1));
                    s = -1 * s;
                }
            }

            return (det);
        }

        // cálculo do cofator é necessário para calcular matriz transposta 
        public static void cofator(double[,] num, double f)
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
                    double raiz = Math.Pow(-1, q + p);
                    fac[q, p] = raiz * determinante(b, f - 1);
                }
            }
            transposta(num, fac, f);
        }

        // cálculo da matriz transpota é necessário para calcular matriz inversa
        public static void transposta(double[,] num, double[,] fac, double r)
        {
            int i, j;
            double[,] b = new double[4, 4];
            double[,] mInversa = new double[4, 4];
            double d;

            for (i = 0; i < r; i++)
            {
                for (j = 0; j < r; j++)
                {
                    b[i, j] = fac[j, i];
                }
            }
            d = determinante(num, r);
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < r; j++)
                {
                    mInversa[i, j] = b[i, j] / d;
                }
            }
            Console.WriteLine("\n\nMatrix INVERSA:\n");

            for (i = 0; i < r; i++)
            {
                for (j = 0; j < r; j++)
                {
                    Console.Write(mInversa[i, j] + "          ");
                }
                Console.WriteLine("\t");
            }
        }


        static void Main(string[] args)
        {
            Random random = new Random();
            int ordem = 4;
            double[,] m = new double[ordem, ordem];
            double d, k = ordem;
            //popular matriz m
            Console.WriteLine("\n\nMatrix NORMAL:\n");
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    m[i, j] = random.Next(0, 10);
                    Console.Write(m[i,j] + "         ");
                }
                Console.WriteLine("\t");
            }
            
            d = determinante(m, k);
            if (d == 0)
            {
                Console.WriteLine("\nmInversa não foi possível!\n");
            }
            else
            {
                cofator(m, k);
            }


        }
    }
}
