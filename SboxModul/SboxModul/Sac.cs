using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SboxModul
{
    class Sac
    {
        public double[,] z;
        public double maxy, miny, suma;
        public void sac(int n,int m,int[]s)
        {
            int[,] y = new int[n, m];
            z = new double[n, m];
            double v;
            double[] c = new double[m];
            for (int i = 0; i < m; i++) c[i] = Math.Pow(2, i);
            for(int x = 0; x < Math.Pow(2, m); x++)
            {
                for(int j = 0; j < m; j++)
                {
                    v = s[x] ^ s[x ^ (int)c[j]];
                    for(int i = 0; i < n; i++)
                    {
                        y[i, j] = y[i, j] + (((int)v >> i) & 1);
                    }
                }
            }

            for(int j = 0; j < m; j++)
            {
                for(int i = 0; i < n; i++)
                {
                    z[i, j] = Math.Round(y[i, j] / Math.Pow(2, m), 4);
                }
            }
            maxy = 0;
            suma = 0;
            miny = 255;
            for(int j = 0; j < m; j++)
            {
                for(int i = 0; i < n; i++)
                {
                    if (maxy < y[i, j]) maxy = y[i, j];
                    if (miny > y[i, j]) miny = y[i, j];
                    suma += y[i, j];
                }
            }
            maxy = Math.Round(maxy / Math.Pow(2, m), 4);
            miny = Math.Round(miny / Math.Pow(2, m), 4);
            suma = Math.Pow(suma / (Math.Pow(2, m) * m * n), 4);
        }
    }
}
