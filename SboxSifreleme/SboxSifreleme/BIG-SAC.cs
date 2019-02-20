using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SboxSifreleme
{
    class BIG_SAC
    {
        Numpy np = new Numpy();
        int n = 8, m = 8;
        int[] c;
        int[,] y;
        public int[,] z;

        public double bigSac(int[] s)
        {
            c = new int[m];
            y = np.Zeros(n, m);
            z = np.Zeros(n, m);
            for (int i = 0; i < m; i++) c[i] = 2 ^ i;

            // fi ^ fj'nin bağımlılık matrisini hesaplar
            for(int x = 0; x < Math.Pow(2,m); x++)
            {
                for(int k = 0; k < m; k++)
                {
                    for(int j = 0; j < m; j++)
                    {
                        for(int i = 0; i < n; i++)
                        {
                            y[i,j]= y[i,j] + (((s[x] >> i) & 1) ^ ((s[x] >> j) & 1)) ^ (((s[x ^ c[k]] >> i) & 1) ^ ((s[x ^ c[k]] >> j) & 1));

                        }
                    }
                }
            }
            double sumsac = 0;
            //fi ^ fj'nin bağımlılık matrisindeki her elemanı hesaplar.
            for(int j = 0; j < m; j++)
            {
                for(int i = 0; i < n; i++)
                {
                    z[i, j] =Convert.ToInt32(Math.Round(y[i, j] / (Math.Pow(2, m) * m),4));
                    sumsac += z[i, j];
                }
            }
            double avesumsac = Math.Round(sumsac / 56, 4);
            return avesumsac;
        }
    }
}
