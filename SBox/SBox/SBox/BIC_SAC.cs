using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBox
{
    class BIC_SAC
    {
        public double BicSac(int[] s, int n, int m)
        {
            int[,] y = new int[n, m];
            double[,] z = new double[n, m];
            int[] c = new int[m];
            for (int i = 0; i < m; i++)
            {
                c[i] = (int)Math.Pow(2, i);
            }
            for (int x = 0; x < Math.Pow(2, m); x++)
            {
                for (int k = 0; k < m; k++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            y[i, j] = y[i, j] + (((s[x] >> i) & 1) ^ ((s[x] >> j) & 1)) ^ (((s[x ^ c[k]] >> i) & 1) ^ ((s[x ^ c[k]] >> j) & 1));
                        }
                    }
                }
            }

            double sumsac = 0;
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    z[i, j] = Math.Round(y[i, j] / (Math.Pow(2, m) * m), 4);
                    sumsac = sumsac + z[i, j];
                }
            }

            double avesumsac = Math.Round(sumsac / 56, 4);

            for (int i = 0; i < z.GetLength(0); i++)
            {
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    Console.Write(z[i, j] + "  ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            return avesumsac;
        }
    }
}
