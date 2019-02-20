using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBox
{
    class BIC_Nonlinearty
    {
        public void matrisYaz(double[,] sf)
        {
            Console.WriteLine();
            for (int i = 0; i < sf.GetLength(0); i++)
            {
                for (int l = 0; l < sf.GetLength(1); l++) Console.Write(sf[i, l] + "  ");
                Console.WriteLine();
            }
        }
        public int dianji(int x, int y, int m)
        {
            int[] r = new int[m];
            int[] t = new int[m];
            int z = 0;
            for (int i = 0; i < m; i++) r[i] = (x >> i) & 1;
            for (int i = 0; i < m; i++) t[i] = (y >> i) & 1;
            for (int i = 0; i < m; i++) z = z ^ (r[i] * t[i]);
            return z;
        }
        public double[,] Walsh(int m, int n, int[] s)
        {
            double[] nf = new double[1];
            double[] maxsf;
            double[,] sf;
            double[,] rmatris = new double[8, 8];
            for (int j = 0; j < n; j++)
            {
                sf = new double[n, (int)Math.Pow(2, n)];
                maxsf = new double[n];
                nf = new double[n];
                for (int i = 0; i < n; i++)
                {
                    for (int w = 0; w < Math.Pow(2, m); w++)
                    {
                        for (int x = 0; x < Math.Pow(2, m); x++)
                        {
                            sf[i, w] = sf[i, w] + Math.Pow((-1), (((s[x] >> i) & 1) ^ ((s[x] >> j) & 1) ^ (dianji(x, w, m))));
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int w = 0; w < Math.Pow(2, m); w++)
                    {
                        if (maxsf[i] < Math.Abs(sf[i, w]))
                        {
                            maxsf[i] = Math.Abs(sf[i, w]);
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    nf[i] = Math.Pow(2, m - 1) * (1 - Math.Pow(2, -m) * maxsf[i]);
                }
                //return nf; ana forma dondurulecek matris
                for (int i = 0; i < m; i++)
                {
                    rmatris[j, i] = nf[i];
                }
            }

            return rmatris;

        }
    }
}

